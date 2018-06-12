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
            FrmSplash splashForm = new FrmSplash();
            FrmDBsetup dbsetupForm = new FrmDBsetup();

            //Application.Run(mainForm);
            Application.Run(splashForm);

            if(splashForm.isAppLoaded())
                Application.Run(mainForm);
            //Application.Run(loginForm);

            /*if (loginForm.isAuthenticated()) {
                Application.Run(mainForm);
            }
            if (loginForm.goToRegister()) {
				Application.Run(dbsetupForm);
                if (regForm.goToLogin()) {
                    Application.Restart();
                }
				if (dbsetupForm.isSet()) {
					Application.Run(regForm);
					if(regForm.isAuthenticated())
                        Application.Run(mainForm);
                }
            }*/
        }
    }
}
