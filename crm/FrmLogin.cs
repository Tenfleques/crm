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
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
        }
        public bool isAuthenticated() {

            if(this.txtEmail.TextLength == 0 ||
                 this.txtPassword.TextLength == 0)
                this.lblLoginError.Text = "Необходимо запольнить все поля!";
            /*if() //dblogin
             *  authenticated = true;
             *else
             *   this.lblLoginError.Text = "Эл. почта/ пароль не неверный";
             */
            return authenticated;            
        }
        public bool goToRegister() {
            return register;
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            if (isAuthenticated()) {
                Close();
            }            
        }

        private void lnkGoToRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            register = true;
            Close();
        }
    }
}
