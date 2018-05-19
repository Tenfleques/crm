using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm {
    public partial class FrmMain : Form {
        DataTable table;
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
            table = new DataTable();
            //in some of your methods:
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT Production.Product.Name, sum(s.OrderQty) unitssold, sum(s.TotalDue) valuesales FROM Production.Product join Sales.SalesOrderDetail s on Production.Product.ProductID = s.ProductID 
                  GROUP BY Product.Name";
                /*sqlQuery = @"select sys.tables.name as TableNmae, sys.schemas.name as SchemaName from sys.tables inner join sys.schemas on sys.tables.schema_id = sys.schemas.schema_id";*/
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            
            foreach (DataRow dr in table.Rows) {
                Console.WriteLine(dr[0] + " " + dr[1]);
                //this.chartProductSales.Series[0].Points.AddXY(dr[0], dr[1]);
            }
        }
        private void getTopSellers() {
            table = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT TOP 10 concat(LastName,' ',FirstName) n, SalesYTD s FROM Sales.vSalesPerson ";

                //sqlQuery = @"select sys.tables.name as TableNmae, sys.schemas.name as SchemaName from sys.tables inner join sys.schemas on sys.tables.schema_id = sys.schemas.schema_id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            foreach (DataRow dr in table.Rows) {
                //Console.WriteLine(dr[0] + " " + dr[1]);
                this.chartProductSales.Series[0].Points.AddXY(dr[0], dr[1]);
            }
        }        
    }
}
