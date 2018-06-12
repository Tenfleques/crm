using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm {
    public partial class FrmMain : Form {
        Queries queries = new Queries();
        Utils utils = new Utils();
        DataTable specialOffers;
        DataTable customersByCountry;
        int lastSupportMessage = -1;
        Dictionary<string, List<KeyValuePair<string, string>>> countriesToCustomers;

        public FrmMain() {
            
            InitializeComponent();
            //some settings
            listViewSettings();

            getTopSellers();
            getProductsStats();
            populateSalesPersons();
            specialOfferCategories();
            specialOfferTypes();
            populateProducts();

            specialOffers = queries.getSpecialOffers("");
            populateSpecialOffers();

            //customers support page            
            countriesToCustomers = new Dictionary<string, List<KeyValuePair<string, string>>>();
            customersByCountry = queries.getCustomersByCountry();

            foreach (DataRow dr in customersByCountry.Rows) {
                string key = dr[5].ToString();
                KeyValuePair<String, String> customerCard = utils.customerCard(dr);

                if (countriesToCustomers.ContainsKey(key)) {
                    countriesToCustomers[key].Add(customerCard);
                } else {
                    countriesToCustomers.Add(key, new List<KeyValuePair<String, String>>() { customerCard });
                }
            }
            listCustomersByCountry();
            listCustomerSupportTimeline();
            
        }
        //settings
        private void listViewSettings() {
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = this.listViewSpecialOffers.Width;
            this.listViewSpecialOffers.Columns.Add(header);
        }
        //end settings
        private void initTabHumanResources() {            
            populateTaskListBox();
            refreshEmployeeTasks();
            String emp = this.comboBoxSalesPersons.Text;
            this.labelTellWhoseTasks.Text = Constants.viewWhoseTasks(emp);
            this.labelActiveSalesManTip.Text = Constants.assignTasksTip(emp);
        }
        private void refreshEmployeeTasks() {
            this.flowLayoutPanelEmployeeTasks.Controls.Clear();
            DataTable salesPersonTasks;
            Dictionary<int, List<Label>> empTask = new Dictionary<int, List<Label>>();
            salesPersonTasks = queries.getEmployeeTasks();
            foreach (DataRow empTaskRow in salesPersonTasks.Rows) {
                int empNamekey = Convert.ToInt32(empTaskRow[1]);
                if (!empTask.ContainsKey(empNamekey))
                    empTask.Add(empNamekey, new List<Label>());
                Label taskBox = utils.taskCard(empTaskRow);
                empTask[empNamekey].Add(taskBox);
            }
            int currEmployee = Convert.ToInt32(this.comboBoxSalesPersons.SelectedValue);
            if (empTask.ContainsKey(currEmployee)) {
                foreach (Label taskBox in empTask[currEmployee]) {
                    taskBox.Width = this.flowLayoutPanelEmployeeTasks.Width;
                    Console.WriteLine(taskBox.Width +" : "+ this.flowLayoutPanelEmployeeTasks.Width);
                    this.flowLayoutPanelEmployeeTasks.Controls.Add(taskBox);
                }
            }
        }
        //events
        private void customerHelpCurrentView(String[] card) {
            if (card.Length == 2) {
                int businessID = Convert.ToInt32(card[0]);
                this.richTextBoxCustomerProfile.Text = card[1];
                Console.WriteLine(businessID);
                DataTable supportStream = queries.getCustomerSupport(businessID);
                populateSupportStream(supportStream);
            }
        }
        
        private void buttonCloseSupportTicket_Click(object sender, EventArgs e) {
            if (lastSupportMessage < 0)
                return;
            String[] tagInfo = this.flowLayoutPanelActiveSupport.Controls[lastSupportMessage].Tag.ToString().Split('*');
            if (tagInfo.Length == 2) {
                String businessId = tagInfo[0];
                String replyTo = tagInfo[1];
                String success = queries.writeSupportComment(Constants.closedTicket, businessId, replyTo, Constants.defaultSupportID.ToString());
                DataTable support = queries.getCustomerSupport(Convert.ToInt32(businessId));
                populateSupportStream(support);
            }
        }
        //end of events 

        //business report tab
        public void getProductsStats() {
            DataTable table = queries.getProductsStats();
            Double unitsSold = 0.0;
            Double valueSales = 0.0;
            foreach (DataRow dr in table.Rows) {
                unitsSold += Convert.ToDouble(dr[1]);
                valueSales += Convert.ToDouble(dr[2]);
            }
            this.lblNumProducts.Text = table.Rows.Count.ToString();
            this.lblUnitsSold.Text = unitsSold.ToString("$ 0,.#K", CultureInfo.InvariantCulture);
            this.lblValueTotalSales.Text = valueSales.ToString("$ 0,,.##M", CultureInfo.InvariantCulture);
        }
        private void getTopSellers() {
            DataTable table = queries.getTopSellers();            
            foreach (DataRow dr in table.Rows) {
                this.chartProductSales.Series[0].Points.AddXY(dr[0], dr[1]);
            }
        }
        //end of business reports tab
        //start of customer support page
        private void listCustomersByCountry() {
            foreach (var card in countriesToCustomers) {
                this.treeViewClientsByCountry.Nodes.Add(card.Key,card.Key);
                this.treeViewClientsByCountry.Nodes[card.Key].Tag = "";
                foreach (var customer in card.Value) {
                    this.treeViewClientsByCountry.Nodes[card.Key].Nodes.Add(customer.Key, customer.Key);
                    this.treeViewClientsByCountry.Nodes[card.Key].Nodes[customer.Key].Tag = customer.Value;
                }                
            }            
        } 
        private void listCustomerSupportTimeline() {
            DataTable supportStream = queries.getCustomerSupport(-1); //get all support, last message
            foreach(DataRow dr in supportStream.Rows) {
                Label txtBox = utils.supportCard(dr);
                txtBox.BackColor = Color.White;
                txtBox.Width = this.tabPageChats.Width;
                txtBox.Click += new System.EventHandler(fromTLCustomerSupportView_Click);
                this.flowLayoutPanelHelpLine.Controls.Add(txtBox);
            }
        }

        private void populateSupportStream(DataTable support) {
            this.flowLayoutPanelActiveSupport.Controls.Clear();
            lastSupportMessage = -1;
            foreach (DataRow supportRow in support.Rows) {
                Label txtBox = utils.supportCard(supportRow);                
                txtBox.MaximumSize = new Size(320, 0);
                txtBox.Tag = supportRow[Constants.customerRecordSuppotIndices["BusinessEntityID"]] 
                    + "*" 
                    + supportRow[Constants.customerRecordSuppotIndices["messageid"]];

                
                //customer id and reply to

                this.flowLayoutPanelActiveSupport.Controls.Add(txtBox);
                this.flowLayoutPanelActiveSupport.AutoScrollPosition = new Point(txtBox.Left, txtBox.Top);
                lastSupportMessage++;
            }
            
        }
        //end of customer support page
        //employeee Tasks tab
        private void populateTaskListBox() {
            DataTable table = queries.getAllTasks();
            DataTable dt = new DataTable();
            dt.Columns.Add("Task", typeof(string));
            dt.Columns.Add("TaskDescription", typeof(string));
            dt.Columns.Add("TaskID", typeof(int));
            foreach (DataRow dr in table.Rows) {
                DataRow row = dt.NewRow();
                row["TaskID"] = dr[0];
                row["Task"] = dr[1];
                row["TaskDescription"] = dr[2];
                dt.Rows.Add(row);
            }

            this.listBoxTasks.DataSource = dt;
            this.listBoxTasks.DisplayMember = "Task";
            this.listBoxTasks.ValueMember = "TaskID";
        }

        //end of employee tasks tab
        //special offers page [Marketing]
        private void populateSalesPersons() {
            DataTable table = queries.getSalesPersons();
            DataTable dt = new DataTable();
            dt.Columns.Add("SalesPerson", typeof(string));
            dt.Columns.Add("BusinessID", typeof(int));
            foreach (DataRow dr in table.Rows) {
                DataRow row = dt.NewRow();
                row["SalesPerson"] = dr[0];
                row["BusinessID"] = dr[1];
                dt.Rows.Add(row);
            }

            this.comboBoxSalesPersons.DataSource = dt;
            this.comboBoxSalesPersons.DisplayMember = "SalesPerson";
            this.comboBoxSalesPersons.ValueMember = "BusinessID";
        }
        private void specialOfferTypes() {
            DataTable dt = new DataTable();

            dt.Columns.Add("caption", typeof(string));
            dt.Columns.Add("value", typeof(string));
            foreach (KeyValuePair<String, String> pair in Constants.specialOfferTypes) {
                DataRow row = dt.NewRow();
                row["caption"] = pair.Value;
                row["value"] = pair.Key;
                dt.Rows.Add(row);
            }
            this.comboBoxOfferType.DataSource = dt;
            this.comboBoxOfferType.DisplayMember = "caption";
            this.comboBoxOfferType.ValueMember = "value";

        }
        private void specialOfferCategories() {
            DataTable dt = new DataTable();
            dt.Columns.Add("caption", typeof(string));
            dt.Columns.Add("value", typeof(string));

            foreach(KeyValuePair<String, String> pair in Constants.specialOfferCategories) {
                DataRow row = dt.NewRow();
                row["caption"] = pair.Value;
                row["value"] = pair.Key;
                dt.Rows.Add(row);
            }
            this.comboBoxOfferCategory.DataSource = dt;
            this.comboBoxOfferCategory.DisplayMember = "caption";
            this.comboBoxOfferCategory.ValueMember = "value";
        }
        private void populateProducts() {
            DataTable table = queries.getProducts();

            DataTable dt = new DataTable();
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductID", typeof(int));
            foreach (DataRow dr in table.Rows) {
                DataRow row = dt.NewRow();
                row["ProductID"] = dr[0];
                row["ProductName"] = dr[1];
                dt.Rows.Add(row);
            }

            this.comboBoxOfferProduct.DataSource = dt;
            this.comboBoxOfferProduct.DisplayMember = "ProductName";
            this.comboBoxOfferProduct.ValueMember = "ProductID";
        }
        
        private void populateSpecialOffers() {
            this.listViewSpecialOffers.Items.Clear();
            foreach (DataRow dr in specialOffers.Rows) {
                String description = dr[1].ToString();
                ListViewItem lsV = new ListViewItem(description);
                lsV.Tag = dr[1].ToString() + "\n" +
                    (Convert.ToDouble(dr[2]) * 100).ToString() + "% скидка\nТипа: " +
                    dr[3].ToString() + "\nКатегория: " +
                    dr[4].ToString() + "\nДата начала: " +
                    dr[5].ToString() + "\nДата оканчания: " +
                    dr[6].ToString() + "\nМин. Количество: " +
                    dr[7].ToString() + "\nМакс. Количество: " +
                    dr[8].ToString() + "\n";   
                this.listViewSpecialOffers.Items.Add(lsV);
            }            
            
        }
        
        

        //end of marketing page
        //saving special offer
        

        private void FrmMain_Load(object sender, EventArgs e) {
            this.listBoxTasks.SelectionMode = SelectionMode.MultiExtended;
            this.listViewSpecialOffers.Click += new System.EventHandler(listViewSpecialOffers_ItemActivate);
            this.treeViewClientsByCountry.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeViewNode_Click);
            this.flowLayoutPanelActiveSupport.HorizontalScroll.Enabled = false;
            initTabHumanResources();
        }
        private void listViewSpecialOffers_ItemActivate(object sender, EventArgs e) {
            this.richTextBoxSpecialInfoDetails.Text = this.listViewSpecialOffers.SelectedItems[0].Tag.ToString();
        }
        private void btnSaveCampaign_Click(object sender, EventArgs e) {
            if (this.txtOfferDescription.Text == "") {
                //error
                return;
            }
            this.richTextBoxSpecialInfoDetails.Text = queries.insertSpecialOffer(this.txtOfferDescription.Text,
                Convert.ToDouble(this.numericUpDownOfferDiscount.Value),
                this.comboBoxOfferType.SelectedValue.ToString(),
                this.comboBoxOfferCategory.SelectedValue.ToString(),
                this.dateTimePickerOfferStartDate.Value.ToString("yyyy-MM-dd"),
                this.dateTimePickerOfferEnddate.Value.ToString("yyyy-MM-dd"),
                Convert.ToInt32(this.numericUpDownOfferMin.Value),
                Convert.ToInt32(this.numericUpDownOfferMax.Value));
            specialOffers = queries.getSpecialOffers("");
            populateSpecialOffers();
        }
        private void comboBoxSalesPersons_SelectedIndexChanged(object sender, EventArgs e) {
            String emp = this.comboBoxSalesPersons.Text;
            this.labelTellWhoseTasks.Text = Constants.viewWhoseTasks(emp);
            this.labelActiveSalesManTip.Text = Constants.assignTasksTip(emp);
            refreshEmployeeTasks();
        }
        
        private void btnSaveNewTask_Click(object sender, EventArgs e) {
            this.labelErrorMissingTaskInfo.Text = "";
            if (txtTaskTitle.Text.Length < 1
                || textBoxTaskDescription.Text.Length < 1) {
                this.labelErrorMissingTaskInfo.Text = Constants.errorMissingTaskInfo;
                return;
            }
            String msg = queries.insertNewTask(textBoxTaskDescription.Text,
                txtTaskTitle.Text,
                dateTimePickerTasksStartDate.Value.ToString("yyyy-MM-dd"),
                dateTimePickerTaskEndDate.Value.ToString("yyyy-MM-dd"));
            Console.WriteLine(msg);
            populateTaskListBox();           

        }

        private void btnSaveAssignments_Click(object sender, EventArgs e) {
            int empID = Convert.ToInt32(this.comboBoxSalesPersons.SelectedValue);
            List<int> newTasks = new List<int>();
            int selectedEmpKey = Convert.ToInt32(comboBoxSalesPersons.SelectedValue);
            
            foreach (DataRowView sl in this.listBoxTasks.SelectedItems) {
                int taskid = Convert.ToInt32(sl.Row["TaskID"]);
                newTasks.Add(taskid);
            }
            String success = queries.assignEmployeeNewTask(newTasks, empID);
            if (success.Contains(Constants.recordWrittenToDB(1).Substring(0, 6))) {
                refreshEmployeeTasks();
            }
        }
        private void tabsMain_SelectedIndexChanged(Object sender, EventArgs e) {
            switch (this.tabsMain.SelectedTab.Name) {
                case "tabBusinessReporting":
                    break;
                case "tabHumanResource":
                    initTabHumanResources();
                    break;
            }
        }
        private void treeViewNode_Click(object sender, TreeNodeMouseClickEventArgs e) {
            String[] card = e.Node.Tag.ToString().Split('*');
            customerHelpCurrentView(card);
        }
        private void fromTLCustomerSupportView_Click(object sender, EventArgs e) {
            Label initiator = sender as Label;

            String[] card = initiator.Tag.ToString().Split('*');
            customerHelpCurrentView(card);
            customerHelpCurrentView(card);
            customerHelpCurrentView(card);
        }
        private void btnSendMsg_Click(object sender, EventArgs e) {
            if (lastSupportMessage < 0)
                return;
            String[] tagInfo = this.flowLayoutPanelActiveSupport.Controls[lastSupportMessage].Tag.ToString().Split('*');
            if (tagInfo.Length == 2) {
                String businessId = tagInfo[0];
                String replyTo = tagInfo[1];
                if (this.txtSupportClient.Text.Length > 0) {
                    String success = queries.writeSupportComment(this.txtSupportClient.Text, businessId, replyTo, Constants.defaultSupportID.ToString());

                    if (success.Contains(Constants.recordWrittenToDB(1).Substring(0, 6))) {
                        this.txtSupportClient.Clear();
                        DataTable support = queries.getCustomerSupport(Convert.ToInt32(businessId));
                        populateSupportStream(support);
                    }
                }
            }
        }

        private void buttonPrintReport_Click(object sender, EventArgs e) {
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            pd.Print();
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev) {
            // Create and initialize print font 
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10);
            Rectangle myRec = new System.Drawing.Rectangle(10, 30, 800, 600);
            ev.Graphics.DrawString("Лучшие продавцы", printFont, Brushes.Black, 10, 10);
            this.chartProductSales.Printing.PrintPaint(ev.Graphics, myRec);
           
        }
    }
}
