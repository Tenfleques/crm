using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm {
    public class Queries {
        //10 biggest customers with DENSE_RANK().

        public void getTopBiggestCustomersOverDenseRank() {
            var sql = "WITH CTE AS(SELECT CustomerID, TotSales= SUM(Subtotal),                 DR = DENSE_RANK() OVER(ORDER BY SUM(Subtotal) DESC)            FROM Sales.SalesOrderHeader" +
                " GROUP BY CustomerID) SELECT* FROM CTE WHERE DR <= 10 ORDER BY DR, CustomerID;";
        } 
    }
}
