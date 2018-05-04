using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FrmLogin loginForm = new FrmLogin();
            FrmRegistration regForm = new FrmRegistration();
            FrmMain mainForm = new FrmMain();

            Application.Run(loginForm);

            if (loginForm.isAuthenticated()) {
                Application.Run(mainForm);
            }
            if (loginForm.goToRegister()) {
                Application.Run(regForm);
                if (regForm.goToLogin()) {
                    Application.Restart();
                }
                if (regForm.isAuthenticated()) {
                    Application.Run(mainForm);
                }
            }
        }
    }
}
