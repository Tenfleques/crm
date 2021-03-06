﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crm {
    public partial class FrmDBsetup : Form {
        private bool allSet = false;
        public FrmDBsetup() {
            InitializeComponent();
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
        }
        private bool saveDBSettings() {
            if (this.txtHost.TextLength == 0 ||
                this.txtUsername.TextLength == 0 ||
                this.txtPassword.TextLength == 0) {
                this.lblErrorMessage.Text = "Необходимо запольнить все поля!";
                return false;
            }
            this.lblErrorMessage.Text = "";
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
			allSet = true;
			this.Close();
            if (this.saveDBSettings()) {
                this.Close();
            }
        }
    }
}
