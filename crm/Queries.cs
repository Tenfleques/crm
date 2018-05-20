using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace crm {
    public class Queries {
        //10 biggest customers with DENSE_RANK().

        public void getTopBiggestCustomersOverDenseRank() {
            var sql = "WITH CTE AS(SELECT CustomerID, TotSales= SUM(Subtotal),                 DR = DENSE_RANK() OVER(ORDER BY SUM(Subtotal) DESC)            FROM Sales.SalesOrderHeader" +
                " GROUP BY CustomerID) SELECT* FROM CTE WHERE DR <= 10 ORDER BY DR, CustomerID;";
        }
        public DataTable getProductsStats() {
            DataTable table = new DataTable();
            //in some of your methods:
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT p.Name, sum(s.OrderQty) unitssold, sum(s.UnitPrice*s.OrderQty) valuesales FROM Sales.SalesOrderDetail s join  Production.Product p on p.ProductID = s.ProductID 
                  GROUP BY p.Name";
                /*sqlQuery = @"select sys.tables.name as TableNmae, sys.schemas.name as SchemaName from sys.tables inner join sys.schemas on sys.tables.schema_id = sys.schemas.schema_id";*/
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            return table;
        }
        public DataTable getTopSellers() {
            DataTable table = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT TOP 10 concat(LastName,' ',FirstName) n, SalesYTD s FROM Sales.vSalesPerson ";

                //sqlQuery = @"select sys.tables.name as TableNmae, sys.schemas.name as SchemaName from sys.tables inner join sys.schemas on sys.tables.schema_id = sys.schemas.schema_id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            return table;
        }
    }
}
