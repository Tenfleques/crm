using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm {
    public partial class FrmDBsetup : Form {
        private bool allSet = false;
        public FrmDBsetup() {
            InitializeComponent();
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCompany.Text = Properties.Settings.Default.userCompany;
            this.lblAdmin.Text = Properties.Settings.Default.adminEmail;
        }
        private bool saveDBSettings() {
            if (this.txtHost.TextLength == 0 ||
                this.txtUsername.TextLength == 0 ||
                this.txtUsername.TextLength == 0) {
                this.lblErrorMessage.Text = "Необходимо запольнить все поля!";
                return false;
            }
            /*if() successful connect and setup
             * Properties.Settings.Default["SomeProperty"] = "Some Value";
             *   Properties.Settings.Default.Save();
             *   allSet = true;
             * */
            return false;
        }
        public bool isSet() {
            return allSet;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (this.saveDBSettings()) {
                this.Close();
            }
        }
    }
}
