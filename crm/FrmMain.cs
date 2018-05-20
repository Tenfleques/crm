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
        //public event EventHandler SelectedIndexChanged;
        public FrmMain() {
            InitializeComponent();
            getTopSellers();
            getProductsStats();
        }

        private void btnPost_Click(object sender, EventArgs e) {
           
        }

        private void tabsMain_SelectedIndexChanged(Object sender, TabControlEventArgs e) {

            /*System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "TabPage", e.TabPage);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "TabPageIndex", e.TabPageIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Action", e.Action);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Selected Event");*/
        }
        private void tabsMain_SelectedIndexChanged(Object sender, EventArgs e) {

            //MessageBox.Show(e.ToString());

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
                //Console.WriteLine(dr[0] + " " + dr[1]);
                this.chartProductSales.Series[0].Points.AddXY(dr[0], dr[1]);
            }
        }        
    }
}
