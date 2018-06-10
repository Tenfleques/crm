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
        public DataTable getSpecialOffers(String where) {
            DataTable table = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT [SpecialOfferID]
                ,[Description]
                ,[DiscountPct]
                ,[Type]
                ,[Category]
                ,[StartDate]
                ,[EndDate]
                ,[MinQty]
                ,[MaxQty]
            FROM [AdventureWorks2016].[Sales].[SpecialOffer] " +
            where +
            " ORDER BY [StartDate], [EndDate] DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            return table;
        }
        public DataTable getProducts() {
            DataTable table = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT [ProductID],[Name]   FROM [Production].[vProductAndDescription] 
                WHERE CultureID = 'en'";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            return table;
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
                string sqlQuery = @"SELECT TOP 10 concat(LastName,' ',FirstName) n, SalesYTD s FROM Sales.vSalesPerson ORDER BY s DESC";

                //sqlQuery = @"select sys.tables.name as TableNmae, sys.schemas.name as SchemaName from sys.tables inner join sys.schemas on sys.tables.schema_id = sys.schemas.schema_id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            return table;
        }
        public DataTable getSalesPersons() {
            DataTable table = new DataTable();            
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT concat(LastName,' ',FirstName) n, BusinessEntityID bid FROM Sales.vSalesPerson";
            
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            return table;
        }
        public DataTable getCustomersByCountry() {
            DataTable table = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT c.BusinessEntityID 
	          ,c.PhoneNumber
	          ,c.EmailAddress
	          ,c.City
	          ,c.StateProvinceName
	          ,c.CountryRegionName 
              ,CONCAT(c.FirstName, ' ', c.LastName) Name
          FROM Sales.vIndividualCustomer c";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            return table;
        }
        public DataTable getCustomerSupport(int businessID) {
            DataTable table = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                string sqlQuery = @"SELECT c.BusinessEntityID 
	            ,c.PhoneNumber
	            ,c.EmailAddress
	            ,c.City
	            ,c.StateProvinceName
	            ,c.CountryRegionName 
                ,CONCAT(c.FirstName, ' ', c.LastName) Name
                ,[supportid]
                ,[message]
                ,[date]
                ,[messageid]
                ,[replyto]
                ,CONCAT(e.FirstName, ' ', e.LastName) support
            FROM [Sales].[CustomerHelp] ch
            JOIN Sales.vIndividualCustomer c            
            ON c.BusinessEntityID = ch.customerid
            JOIN HumanResources.vEmployee e
            ON e.BusinessEntityID = ch.supportid";

                if(businessID > 0)
                    sqlQuery += " WHERE c.BusinessEntityID = " +businessID;
                sqlQuery += " ORDER BY [date] DESC"; 

                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn)) {
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(table);
                }
            }
            return table;
        }

        //insertions

        public String insertSpecialOffer(String description, Double discount, String type, String category, String startdate, String enddate, int minqty, int maxqty) {
            Dictionary<String, String> sqlParams = new Dictionary<String,String>(){
                {"discription",description },
                {"discount", discount.ToString() },
                {"type",type },
                {"category",category },
                {"startdate",startdate },
                {"enddate",enddate },
                {"minqty",minqty.ToString() },
                {"maxqty",maxqty.ToString() }
            };
            String message = "";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.AdventureWorks2016Data)) {
                using (SqlCommand command = new SqlCommand()) {
                    command.Connection = connection;            // <== lacking
                    command.CommandType = CommandType.Text;
                    String placeholders = "";
                    foreach (KeyValuePair<String, String> pair in sqlParams) {
                        if (placeholders.Length > 0)
                            placeholders += ",@" + pair.Key;
                        else
                            placeholders += "@" + pair.Key;
                        command.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                    }
                    command.CommandText = "INSERT INTO Sales.SpecialOffer ([Description], [DiscountPct], [Type], [Category], [StartDate], [EndDate], [MinQty], [MaxQty])VALUES (" + placeholders + ")";                    
                    try {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        message = "Зафиксированные записи: " + recordsAffected;
                    } catch (SqlException e) {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.Errors);
                        message = "Произошла ошибка, и запись не удалось сохранить";
                    } finally {
                        connection.Close();
                    }
                }                
            }
            return message;
        }
    }
}
