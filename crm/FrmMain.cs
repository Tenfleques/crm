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
        DataTable specialOffers; 
        public FrmMain() {
            InitializeComponent();
            getTopSellers();
            getProductsStats();
            populateSalesPersons();
            specialOfferCategories();
            specialOfferTypes();
            populateProducts();

            specialOffers = queries.getSpecialOffers("");
            populateSpecialOffers();
        }

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
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = this.listViewSpecialOffers.Width;
            this.listViewSpecialOffers.Columns.Add(header);
            this.listViewSpecialOffers.Click += new System.EventHandler(listViewSpecialOffers_ItemActivate);
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
    }
}
