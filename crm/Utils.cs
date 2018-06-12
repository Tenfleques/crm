using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm {
    class Utils {
        public KeyValuePair<String,String> customerCard(DataRow customer) {
            String card = "";
            String name = customer[6].ToString();
            card += customer[0] + "*"; //businessID
            card += name + "\n"; //name
            card += customer[1] + "\n"; //Phone number
            card += customer[2] + "\n"; //email address
            card += customer[3] + "\n"; //City
            card += customer[4] + ", "; //State/Province
            card += customer[5]; //Country
            return new KeyValuePair<String, String>(name, card );
        }
        public Label supportCard(DataRow supportRow) {
            /*
             ,[supportid] 7
                ,[message] 8
                ,[date] 9
                ,[messageid] 10
                ,[replyto] 11
                ,CONCAT(e.FirstName, ' ', e.LastName) support 12
             */
            String card = Environment.NewLine + " ";
            card += supportRow[Constants.customerRecordSuppotIndices["date"]] + Environment.NewLine + "  "; //date
            if (Convert.ToInt32(supportRow[Constants.customerRecordSuppotIndices["clientwritten"]]) == 1)
                card += supportRow[Constants.customerRecordSuppotIndices["name"]] + Environment.NewLine + " ";
            else 
                card += "[помошь]" + supportRow[Constants.customerRecordSuppotIndices["support"]] + Environment.NewLine + "  ";
            card += supportRow[Constants.customerRecordSuppotIndices["message"]].ToString() + Environment.NewLine + "  ";

            Label lab = new Label();
            lab.Text = card;
            lab.BorderStyle = BorderStyle.None;
            var margin = lab.Margin;
            margin.Top = 1;
            lab.Margin = margin;
            lab.Cursor = Cursors.Arrow;
            lab.Tag = customerCard(supportRow).Value;
            lab.AutoSize = true;
            lab.Anchor = (AnchorStyles.Bottom & AnchorStyles.Right);
            return lab;
        }
    }
}
