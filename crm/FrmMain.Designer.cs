namespace crm {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabsMain = new System.Windows.Forms.TabControl();
            this.tabSalesForce = new System.Windows.Forms.TabPage();
            this.tabCustomerService = new System.Windows.Forms.TabPage();
            this.tabMarketing = new System.Windows.Forms.TabPage();
            this.tabBusinessReporting = new System.Windows.Forms.TabPage();
            this.tabAnalytics = new System.Windows.Forms.TabPage();
            this.listWorkers = new System.Windows.Forms.ListView();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.groupBoxAddWorker = new System.Windows.Forms.GroupBox();
            this.tabHumanResource = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveNewWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAssignResponsibilty = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.btnSaveAssignments = new System.Windows.Forms.Button();
            this.tabsMain.SuspendLayout();
            this.groupBoxAddWorker.SuspendLayout();
            this.tabHumanResource.SuspendLayout();
            this.groupBoxAssignResponsibilty.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsMain
            // 
            this.tabsMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsMain.Controls.Add(this.tabSalesForce);
            this.tabsMain.Controls.Add(this.tabHumanResource);
            this.tabsMain.Controls.Add(this.tabCustomerService);
            this.tabsMain.Controls.Add(this.tabMarketing);
            this.tabsMain.Controls.Add(this.tabBusinessReporting);
            this.tabsMain.Controls.Add(this.tabAnalytics);
            this.tabsMain.ItemSize = new System.Drawing.Size(110, 30);
            this.tabsMain.Location = new System.Drawing.Point(12, 12);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.Padding = new System.Drawing.Point(20, 5);
            this.tabsMain.SelectedIndex = 0;
            this.tabsMain.Size = new System.Drawing.Size(780, 480);
            this.tabsMain.TabIndex = 0;
            // 
            // tabSalesForce
            // 
            this.tabSalesForce.Location = new System.Drawing.Point(4, 34);
            this.tabSalesForce.Name = "tabSalesForce";
            this.tabSalesForce.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesForce.Size = new System.Drawing.Size(772, 442);
            this.tabSalesForce.TabIndex = 0;
            this.tabSalesForce.Text = "Отдел продаж";
            // 
            // tabCustomerService
            // 
            this.tabCustomerService.Location = new System.Drawing.Point(4, 34);
            this.tabCustomerService.Name = "tabCustomerService";
            this.tabCustomerService.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerService.Size = new System.Drawing.Size(772, 442);
            this.tabCustomerService.TabIndex = 2;
            this.tabCustomerService.Text = "Обслуживание клиентов";
            // 
            // tabMarketing
            // 
            this.tabMarketing.Location = new System.Drawing.Point(4, 34);
            this.tabMarketing.Name = "tabMarketing";
            this.tabMarketing.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarketing.Size = new System.Drawing.Size(772, 442);
            this.tabMarketing.TabIndex = 3;
            this.tabMarketing.Text = "Маркетинг";
            // 
            // tabBusinessReporting
            // 
            this.tabBusinessReporting.Location = new System.Drawing.Point(4, 34);
            this.tabBusinessReporting.Name = "tabBusinessReporting";
            this.tabBusinessReporting.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusinessReporting.Size = new System.Drawing.Size(772, 442);
            this.tabBusinessReporting.TabIndex = 4;
            this.tabBusinessReporting.Text = "Бизнес-отчетность";
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Location = new System.Drawing.Point(4, 34);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalytics.Size = new System.Drawing.Size(772, 442);
            this.tabAnalytics.TabIndex = 5;
            this.tabAnalytics.Text = "Аналитика";
            // 
            // listWorkers
            // 
            this.listWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listWorkers.Location = new System.Drawing.Point(440, 40);
            this.listWorkers.Name = "listWorkers";
            this.listWorkers.Size = new System.Drawing.Size(325, 390);
            this.listWorkers.TabIndex = 0;
            this.listWorkers.UseCompatibleStateImageBehavior = false;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchEmployee.Location = new System.Drawing.Point(440, 10);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(325, 20);
            this.txtSearchEmployee.TabIndex = 3;
            // 
            // groupBoxAddWorker
            // 
            this.groupBoxAddWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddWorker.Controls.Add(this.txtName);
            this.groupBoxAddWorker.Controls.Add(this.txtEmail);
            this.groupBoxAddWorker.Controls.Add(this.label2);
            this.groupBoxAddWorker.Controls.Add(this.btnSaveNewWorker);
            this.groupBoxAddWorker.Controls.Add(this.label1);
            this.groupBoxAddWorker.Location = new System.Drawing.Point(6, 35);
            this.groupBoxAddWorker.Name = "groupBoxAddWorker";
            this.groupBoxAddWorker.Size = new System.Drawing.Size(428, 175);
            this.groupBoxAddWorker.TabIndex = 8;
            this.groupBoxAddWorker.TabStop = false;
            this.groupBoxAddWorker.Text = "Добавьте новый сотрудник";
            // 
            // tabHumanResource
            // 
            this.tabHumanResource.Controls.Add(this.groupBoxAssignResponsibilty);
            this.tabHumanResource.Controls.Add(this.groupBoxAddWorker);
            this.tabHumanResource.Controls.Add(this.txtSearchEmployee);
            this.tabHumanResource.Controls.Add(this.listWorkers);
            this.tabHumanResource.Location = new System.Drawing.Point(4, 34);
            this.tabHumanResource.Name = "tabHumanResource";
            this.tabHumanResource.Padding = new System.Windows.Forms.Padding(3);
            this.tabHumanResource.Size = new System.Drawing.Size(772, 442);
            this.tabHumanResource.TabIndex = 1;
            this.tabHumanResource.Text = "Управление персоналом";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(75, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(75, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(335, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // btnSaveNewWorker
            // 
            this.btnSaveNewWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNewWorker.Location = new System.Drawing.Point(75, 115);
            this.btnSaveNewWorker.Name = "btnSaveNewWorker";
            this.btnSaveNewWorker.Size = new System.Drawing.Size(335, 23);
            this.btnSaveNewWorker.TabIndex = 11;
            this.btnSaveNewWorker.Text = "Добавьте";
            this.btnSaveNewWorker.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Эл. почта";
            // 
            // groupBoxAssignResponsibilty
            // 
            this.groupBoxAssignResponsibilty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAssignResponsibilty.Controls.Add(this.btnSaveAssignments);
            this.groupBoxAssignResponsibilty.Controls.Add(this.listBoxTasks);
            this.groupBoxAssignResponsibilty.Controls.Add(this.comboBoxWorker);
            this.groupBoxAssignResponsibilty.Controls.Add(this.label4);
            this.groupBoxAssignResponsibilty.Controls.Add(this.label3);
            this.groupBoxAssignResponsibilty.Location = new System.Drawing.Point(7, 217);
            this.groupBoxAssignResponsibilty.Name = "groupBoxAssignResponsibilty";
            this.groupBoxAssignResponsibilty.Size = new System.Drawing.Size(427, 213);
            this.groupBoxAssignResponsibilty.TabIndex = 9;
            this.groupBoxAssignResponsibilty.TabStop = false;
            this.groupBoxAssignResponsibilty.Text = "Назначить задачу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сотрудник";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Задачи";
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(74, 39);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(335, 21);
            this.comboBoxWorker.TabIndex = 2;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(74, 77);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(335, 95);
            this.listBoxTasks.TabIndex = 3;
            // 
            // btnSaveAssignments
            // 
            this.btnSaveAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAssignments.Location = new System.Drawing.Point(74, 184);
            this.btnSaveAssignments.Name = "btnSaveAssignments";
            this.btnSaveAssignments.Size = new System.Drawing.Size(335, 23);
            this.btnSaveAssignments.TabIndex = 4;
            this.btnSaveAssignments.Text = "Сохранить";
            this.btnSaveAssignments.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.tabsMain);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "FrmMain";
            this.Text = "СРМ";
            this.tabsMain.ResumeLayout(false);
            this.groupBoxAddWorker.ResumeLayout(false);
            this.groupBoxAddWorker.PerformLayout();
            this.tabHumanResource.ResumeLayout(false);
            this.tabHumanResource.PerformLayout();
            this.groupBoxAssignResponsibilty.ResumeLayout(false);
            this.groupBoxAssignResponsibilty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsMain;
        private System.Windows.Forms.TabPage tabSalesForce;
        private System.Windows.Forms.TabPage tabCustomerService;
        private System.Windows.Forms.TabPage tabMarketing;
        private System.Windows.Forms.TabPage tabBusinessReporting;
        private System.Windows.Forms.TabPage tabAnalytics;
        private System.Windows.Forms.TabPage tabHumanResource;
        private System.Windows.Forms.GroupBox groupBoxAssignResponsibilty;
        private System.Windows.Forms.Button btnSaveAssignments;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxAddWorker;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveNewWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.ListView listWorkers;
    }
}