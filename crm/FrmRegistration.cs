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
    public partial class FrmRegistration : Form {
        private String errorMessage;
        private bool gotologin;
        private bool authenticated;
        public FrmRegistration() {
            InitializeComponent();
            gotologin = false;
            authenticated = false;
            errorMessage = "Необходимо запольнить все поля!";
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
        }
        private bool validateInput() {
            if (this.txtCompany.TextLength == 0 ||
                this.txtEmail.TextLength == 0 ||
                this.txtPassword.TextLength == 0) {
                errorMessage = "Необходимо запольнить все поля!";
                return false;
            }
            if(this.txtPassword.Text != this.txtRepeatPassword.Text) {
                errorMessage = "Пароли не совпадают!" + this.txtPassword.Text +" - " + this.txtRepeatPassword;
                return false;
            }

            Properties.Settings.Default["userCompany"] = this.txtCompany.Text;
            Properties.Settings.Default["adminEmail"] = this.txtEmail.Text;
            Properties.Settings.Default["adminPassword"] = this.txtPassword.Text;
            authenticated = true;

            Properties.Settings.Default.Save();
            return true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
            gotologin = true;
        }
        public bool goToLogin() {
            return gotologin;
        }
        private void btnRegister_Click(object sender, EventArgs e) {
            if (!validateInput()) {
                this.lblErrorText.Text = errorMessage;
            } else { 
                //go to register company and initial user
                authenticated = true;
                Close();
            }
        }
        public bool isAuthenticated() {
            return authenticated;
        }
    }
}

