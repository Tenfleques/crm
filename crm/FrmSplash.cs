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
    public partial class FrmSplash : Form {
        private bool appLoaded;
        Timer timer = new Timer();
        Timer progressTimer = new Timer();
        public FrmSplash() {
            InitializeComponent();
            appLoaded = false;

            this.progressBarLoading.Style = ProgressBarStyle.Continuous;
            this.progressBarLoading.ForeColor = Color.Black;

            int milliSeconds = 10000, steps = 5;

            progressTimer.Enabled = true;
            progressTimer.Start();
            progressTimer.Interval = milliSeconds / steps;
            this.progressBarLoading.Maximum = steps;

            progressTimer.Tick += new EventHandler(progress_Tick);
        }
        void progress_Tick(object sender, EventArgs e) {
            if (this.progressBarLoading.Value < this.progressBarLoading.Maximum) {
                this.progressBarLoading.Value++;
            } else {
                appLoaded = true;
                progressTimer.Stop();
                this.Close();
            }
        }
        public bool isAppLoaded() {
            return appLoaded;
        }
    }
}
