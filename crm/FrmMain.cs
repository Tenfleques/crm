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
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e) {
           
        }

        private void label11_Click(object sender, EventArgs e) {
            //describe the list
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2016DataSet);

        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e) {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2016DataSet);

        }
    }
}
