using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        //events
        private void btnPost_Click(object sender, EventArgs e) {
           
        }
        private void tabsMain_SelectedIndexChanged(Object sender, EventArgs e) {
            //MessageBox.Show(e.ToString());
            //Console.WriteLine();            
            switch (this.tabsMain.SelectedTab.Name) {
                case "tabBusinessReporting":                   
                    break;
            }
        }
        private void treeViewNode_Click(object sender, TreeNodeMouseClickEventArgs e) {
            String[] card = e.Node.Tag.ToString().Split('*');
            customerHelpCurrentView(card);
        }
        private void fromTLCustomerSupportView_Click(object sender, EventArgs e) {
            RichTextBox initiator = sender as RichTextBox;
            
            String[] card = initiator.Tag.ToString().Split('*');
            customerHelpCurrentView(card);
        }
        private void customerHelpCurrentView(String[] card) {
            if (card.Length == 2) {
                int businessID = Convert.ToInt32(card[0]);
                this.richTextBoxCustomerProfile.Text = card[1];
                Console.WriteLine(businessID);
                DataTable supportStream = queries.getCustomerSupport(businessID);
                populateSupportStream(supportStream);
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
            this.treeViewClientsByCountry.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeViewNode_Click);
        } 
        private void listCustomerSupportTimeline() {
            DataTable supportStream = queries.getCustomerSupport(-1); //get all support, last message
            foreach(DataRow dr in supportStream.Rows) {
                RichTextBox txtBox = utils.supportCard(dr);
                txtBox.BackColor = Color.White;
                txtBox.Width = this.tabPageChats.Width;
                txtBox.Click += new System.EventHandler(fromTLCustomerSupportView_Click);
                this.flowLayoutPanelHelpLine.Controls.Add(txtBox);
            }
        }

        private void populateSupportStream(DataTable support) {            
            foreach (DataRow supportRow in support.Rows) {
                RichTextBox txtBox = utils.supportCard(supportRow);
                txtBox.Width = this.groupBoxCurrentMessage.Width;
                this.flowLayoutPanelActiveSupport.Controls.Add(txtBox);
            }
        }
        //end of customer support page

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
            this.listViewSpecialOffers.Click += new System.EventHandler(listViewSpecialOffers_ItemActivate);
        }
        
        private void listViewSpecialOffers_ItemActivate(object sender, EventArgs e) {
            this.richTextBoxSpecialInfoDetails.Text = this.listViewSpecialOffers.SelectedItems[0].Tag.ToString();
        }

        //saving special offer
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

        private void FrmMain_Load(object sender, EventArgs e) {

        }

        //end of marketing page
    }
}
