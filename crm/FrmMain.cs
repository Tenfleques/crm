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

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crmDataSet);

        }

        private void FrmMain_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'crmDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.crmDataSet.Inventory);

        }
    }
}
