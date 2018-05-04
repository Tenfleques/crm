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
    public partial class FrmLogin : Form {
        private bool authenticated;
        private bool register;
        public FrmLogin() {
            InitializeComponent();
            authenticated = false;
            register = false;
        }
        public bool isAuthenticated() {
            return authenticated;
        }
        public bool goToRegister() {
            return register;
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            if (isAuthenticated()) {
                Close();
            } else {
                this.lblLoginError.ForeColor = System.Drawing.Color.Red;
                this.lblLoginError.Text = "Эл. почта/ пароль не неверный";
            }            
        }

        private void lnkGoToRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            register = true;
            Close();
        }
    }
}
