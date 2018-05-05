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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabsMain = new System.Windows.Forms.TabControl();
            this.tabSalesForce = new System.Windows.Forms.TabPage();
            this.groupBoxWall = new System.Windows.Forms.GroupBox();
            this.groupBoxTl = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.tabHumanResource = new System.Windows.Forms.TabPage();
            this.groupBoxAssignResponsibilty = new System.Windows.Forms.GroupBox();
            this.btnSaveAssignments = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxAddWorker = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveNewWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.listWorkers = new System.Windows.Forms.ListView();
            this.tabCustomerService = new System.Windows.Forms.TabPage();
            this.groupBoxAddClient = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomerRating = new System.Windows.Forms.ComboBox();
            this.lblSaveCustomerError = new System.Windows.Forms.Label();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxClientSupport = new System.Windows.Forms.GroupBox();
            this.groupBoxCurrentMessage = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.tabMarketing = new System.Windows.Forms.TabPage();
            this.groupBoxCreateCampaign = new System.Windows.Forms.GroupBox();
            this.btnSaveCampaign = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCampaignName = new System.Windows.Forms.TextBox();
            this.lblTargetClients = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxCreateGroup = new System.Windows.Forms.GroupBox();
            this.btnSaveQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtQueryLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxClientGroups = new System.Windows.Forms.GroupBox();
            this.tabBusinessReporting = new System.Windows.Forms.TabPage();
            this.tabAnalytics = new System.Windows.Forms.TabPage();
            this.tabsMain.SuspendLayout();
            this.tabSalesForce.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHumanResource.SuspendLayout();
            this.groupBoxAssignResponsibilty.SuspendLayout();
            this.groupBoxAddWorker.SuspendLayout();
            this.tabCustomerService.SuspendLayout();
            this.groupBoxAddClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabMarketing.SuspendLayout();
            this.groupBoxCreateCampaign.SuspendLayout();
            this.groupBoxCreateGroup.SuspendLayout();
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
            this.tabSalesForce.Controls.Add(this.groupBoxWall);
            this.tabSalesForce.Controls.Add(this.groupBoxTl);
            this.tabSalesForce.Controls.Add(this.groupBox1);
            this.tabSalesForce.Location = new System.Drawing.Point(4, 34);
            this.tabSalesForce.Name = "tabSalesForce";
            this.tabSalesForce.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesForce.Size = new System.Drawing.Size(772, 442);
            this.tabSalesForce.TabIndex = 0;
            this.tabSalesForce.Text = "Отдел продаж";
            // 
            // groupBoxWall
            // 
            this.groupBoxWall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxWall.Location = new System.Drawing.Point(7, 201);
            this.groupBoxWall.Name = "groupBoxWall";
            this.groupBoxWall.Size = new System.Drawing.Size(434, 235);
            this.groupBoxWall.TabIndex = 4;
            this.groupBoxWall.TabStop = false;
            this.groupBoxWall.Text = "Лента сообщения";
            // 
            // groupBoxTl
            // 
            this.groupBoxTl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTl.Location = new System.Drawing.Point(447, 6);
            this.groupBoxTl.Name = "groupBoxTl";
            this.groupBoxTl.Size = new System.Drawing.Size(319, 430);
            this.groupBoxTl.TabIndex = 3;
            this.groupBoxTl.TabStop = false;
            this.groupBoxTl.Text = "Лента новостей";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPost);
            this.groupBox1.Controls.Add(this.txtPost);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сообщения";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 43);
            this.listBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Видимость";
            // 
            // btnPost
            // 
            this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPost.Location = new System.Drawing.Point(337, 125);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(79, 43);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "отправить сообщение";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtPost
            // 
            this.txtPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPost.Location = new System.Drawing.Point(20, 24);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(396, 70);
            this.txtPost.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сотрудник";
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
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchEmployee.Location = new System.Drawing.Point(440, 10);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(325, 20);
            this.txtSearchEmployee.TabIndex = 3;
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
            // tabCustomerService
            // 
            this.tabCustomerService.Controls.Add(this.groupBoxAddClient);
            this.tabCustomerService.Controls.Add(this.groupBoxClientSupport);
            this.tabCustomerService.Controls.Add(this.groupBoxCurrentMessage);
            this.tabCustomerService.Controls.Add(this.groupBox2);
            this.tabCustomerService.Location = new System.Drawing.Point(4, 34);
            this.tabCustomerService.Name = "tabCustomerService";
            this.tabCustomerService.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerService.Size = new System.Drawing.Size(772, 442);
            this.tabCustomerService.TabIndex = 2;
            this.tabCustomerService.Text = "Обслуживание клиентов";
            // 
            // groupBoxAddClient
            // 
            this.groupBoxAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddClient.Controls.Add(this.comboBoxCustomerRating);
            this.groupBoxAddClient.Controls.Add(this.lblSaveCustomerError);
            this.groupBoxAddClient.Controls.Add(this.btnSaveClient);
            this.groupBoxAddClient.Controls.Add(this.textBox3);
            this.groupBoxAddClient.Controls.Add(this.textBox2);
            this.groupBoxAddClient.Controls.Add(this.textBox1);
            this.groupBoxAddClient.Controls.Add(this.label14);
            this.groupBoxAddClient.Controls.Add(this.label13);
            this.groupBoxAddClient.Controls.Add(this.label12);
            this.groupBoxAddClient.Controls.Add(this.label11);
            this.groupBoxAddClient.Location = new System.Drawing.Point(5, 5);
            this.groupBoxAddClient.Name = "groupBoxAddClient";
            this.groupBoxAddClient.Size = new System.Drawing.Size(420, 225);
            this.groupBoxAddClient.TabIndex = 3;
            this.groupBoxAddClient.TabStop = false;
            this.groupBoxAddClient.Text = "Добавьте Клиента";
            // 
            // comboBoxCustomerRating
            // 
            this.comboBoxCustomerRating.FormattingEnabled = true;
            this.comboBoxCustomerRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxCustomerRating.Location = new System.Drawing.Point(105, 145);
            this.comboBoxCustomerRating.Name = "comboBoxCustomerRating";
            this.comboBoxCustomerRating.Size = new System.Drawing.Size(309, 21);
            this.comboBoxCustomerRating.TabIndex = 10;
            // 
            // lblSaveCustomerError
            // 
            this.lblSaveCustomerError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveCustomerError.AutoSize = true;
            this.lblSaveCustomerError.Location = new System.Drawing.Point(105, 25);
            this.lblSaveCustomerError.Name = "lblSaveCustomerError";
            this.lblSaveCustomerError.Size = new System.Drawing.Size(0, 13);
            this.lblSaveCustomerError.TabIndex = 9;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClient.Location = new System.Drawing.Point(105, 180);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(309, 23);
            this.btnSaveClient.TabIndex = 8;
            this.btnSaveClient.Text = "Сохранить";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(105, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(310, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(105, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(105, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Рейтинг";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Эл. Почта";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Телефон";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Имя/Название";
            // 
            // groupBoxClientSupport
            // 
            this.groupBoxClientSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClientSupport.Location = new System.Drawing.Point(5, 234);
            this.groupBoxClientSupport.Name = "groupBoxClientSupport";
            this.groupBoxClientSupport.Size = new System.Drawing.Size(420, 196);
            this.groupBoxClientSupport.TabIndex = 2;
            this.groupBoxClientSupport.TabStop = false;
            this.groupBoxClientSupport.Text = "Лента обслуживания клинтов";
            // 
            // groupBoxCurrentMessage
            // 
            this.groupBoxCurrentMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCurrentMessage.Location = new System.Drawing.Point(434, 7);
            this.groupBoxCurrentMessage.Name = "groupBoxCurrentMessage";
            this.groupBoxCurrentMessage.Size = new System.Drawing.Size(332, 294);
            this.groupBoxCurrentMessage.TabIndex = 1;
            this.groupBoxCurrentMessage.TabStop = false;
            this.groupBoxCurrentMessage.Text = "Активный чат";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSendMsg);
            this.groupBox2.Controls.Add(this.txtComment);
            this.groupBox2.Location = new System.Drawing.Point(434, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сообщение с клиентами";
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMsg.Location = new System.Drawing.Point(5, 100);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(320, 23);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Отправьте";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(5, 20);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(320, 77);
            this.txtComment.TabIndex = 0;
            // 
            // tabMarketing
            // 
            this.tabMarketing.Controls.Add(this.groupBoxCreateCampaign);
            this.tabMarketing.Controls.Add(this.groupBoxCreateGroup);
            this.tabMarketing.Controls.Add(this.groupBoxClientGroups);
            this.tabMarketing.Location = new System.Drawing.Point(4, 34);
            this.tabMarketing.Name = "tabMarketing";
            this.tabMarketing.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarketing.Size = new System.Drawing.Size(772, 442);
            this.tabMarketing.TabIndex = 3;
            this.tabMarketing.Text = "Маркетинг";
            // 
            // groupBoxCreateCampaign
            // 
            this.groupBoxCreateCampaign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCreateCampaign.Controls.Add(this.btnSaveCampaign);
            this.groupBoxCreateCampaign.Controls.Add(this.txtDescription);
            this.groupBoxCreateCampaign.Controls.Add(this.txtCampaignName);
            this.groupBoxCreateCampaign.Controls.Add(this.lblTargetClients);
            this.groupBoxCreateCampaign.Controls.Add(this.label10);
            this.groupBoxCreateCampaign.Controls.Add(this.label9);
            this.groupBoxCreateCampaign.Controls.Add(this.label8);
            this.groupBoxCreateCampaign.Location = new System.Drawing.Point(6, 176);
            this.groupBoxCreateCampaign.Name = "groupBoxCreateCampaign";
            this.groupBoxCreateCampaign.Size = new System.Drawing.Size(484, 259);
            this.groupBoxCreateCampaign.TabIndex = 2;
            this.groupBoxCreateCampaign.TabStop = false;
            this.groupBoxCreateCampaign.Text = "Создать маркетинговую кампанию";
            // 
            // btnSaveCampaign
            // 
            this.btnSaveCampaign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCampaign.Location = new System.Drawing.Point(94, 232);
            this.btnSaveCampaign.Name = "btnSaveCampaign";
            this.btnSaveCampaign.Size = new System.Drawing.Size(215, 23);
            this.btnSaveCampaign.TabIndex = 6;
            this.btnSaveCampaign.Text = "Сохранить";
            this.btnSaveCampaign.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(95, 90);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 135);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCampaignName
            // 
            this.txtCampaignName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCampaignName.Location = new System.Drawing.Point(95, 50);
            this.txtCampaignName.Name = "txtCampaignName";
            this.txtCampaignName.Size = new System.Drawing.Size(215, 20);
            this.txtCampaignName.TabIndex = 4;
            // 
            // lblTargetClients
            // 
            this.lblTargetClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetClients.AutoSize = true;
            this.lblTargetClients.Location = new System.Drawing.Point(315, 90);
            this.lblTargetClients.Name = "lblTargetClients";
            this.lblTargetClients.Size = new System.Drawing.Size(44, 13);
            this.lblTargetClients.TabIndex = 3;
            this.lblTargetClients.Text = "пусто...";
            this.lblTargetClients.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Список целевых групп. \r\nВыбрать из групп клиентов";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Описание";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Метка";
            // 
            // groupBoxCreateGroup
            // 
            this.groupBoxCreateGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCreateGroup.Controls.Add(this.btnSaveQuery);
            this.groupBoxCreateGroup.Controls.Add(this.txtQuery);
            this.groupBoxCreateGroup.Controls.Add(this.txtQueryLabel);
            this.groupBoxCreateGroup.Controls.Add(this.label7);
            this.groupBoxCreateGroup.Controls.Add(this.label6);
            this.groupBoxCreateGroup.Location = new System.Drawing.Point(5, 5);
            this.groupBoxCreateGroup.Name = "groupBoxCreateGroup";
            this.groupBoxCreateGroup.Size = new System.Drawing.Size(485, 165);
            this.groupBoxCreateGroup.TabIndex = 1;
            this.groupBoxCreateGroup.TabStop = false;
            this.groupBoxCreateGroup.Text = "Создать группа клиентов";
            // 
            // btnSaveQuery
            // 
            this.btnSaveQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveQuery.Location = new System.Drawing.Point(94, 134);
            this.btnSaveQuery.Name = "btnSaveQuery";
            this.btnSaveQuery.Size = new System.Drawing.Size(385, 25);
            this.btnSaveQuery.TabIndex = 4;
            this.btnSaveQuery.Text = "Сохранить";
            this.btnSaveQuery.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(95, 66);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(384, 62);
            this.txtQuery.TabIndex = 3;
            // 
            // txtQueryLabel
            // 
            this.txtQueryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueryLabel.Location = new System.Drawing.Point(95, 30);
            this.txtQueryLabel.Name = "txtQueryLabel";
            this.txtQueryLabel.Size = new System.Drawing.Size(384, 20);
            this.txtQueryLabel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Запрос";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Метка";
            // 
            // groupBoxClientGroups
            // 
            this.groupBoxClientGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClientGroups.Location = new System.Drawing.Point(500, 5);
            this.groupBoxClientGroups.Name = "groupBoxClientGroups";
            this.groupBoxClientGroups.Size = new System.Drawing.Size(260, 430);
            this.groupBoxClientGroups.TabIndex = 0;
            this.groupBoxClientGroups.TabStop = false;
            this.groupBoxClientGroups.Text = "Группы Клиентов";
            // 
            // tabBusinessReporting
            // 
            this.tabBusinessReporting.Location = new System.Drawing.Point(4, 34);
            this.tabBusinessReporting.Name = "tabBusinessReporting";
            this.tabBusinessReporting.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusinessReporting.Size = new System.Drawing.Size(772, 442);
            this.tabBusinessReporting.TabIndex = 4;
            this.tabBusinessReporting.Text = "Бизнес-отчеты";
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.tabsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "FrmMain";
            this.Text = "СРМ";
            this.tabsMain.ResumeLayout(false);
            this.tabSalesForce.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabHumanResource.ResumeLayout(false);
            this.tabHumanResource.PerformLayout();
            this.groupBoxAssignResponsibilty.ResumeLayout(false);
            this.groupBoxAssignResponsibilty.PerformLayout();
            this.groupBoxAddWorker.ResumeLayout(false);
            this.groupBoxAddWorker.PerformLayout();
            this.tabCustomerService.ResumeLayout(false);
            this.groupBoxAddClient.ResumeLayout(false);
            this.groupBoxAddClient.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabMarketing.ResumeLayout(false);
            this.groupBoxCreateCampaign.ResumeLayout(false);
            this.groupBoxCreateCampaign.PerformLayout();
            this.groupBoxCreateGroup.ResumeLayout(false);
            this.groupBoxCreateGroup.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxTl;
        private System.Windows.Forms.GroupBox groupBoxWall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.GroupBox groupBoxClientSupport;
        private System.Windows.Forms.GroupBox groupBoxCurrentMessage;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.GroupBox groupBoxCreateGroup;
        private System.Windows.Forms.Button btnSaveQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtQueryLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxClientGroups;
        private System.Windows.Forms.GroupBox groupBoxCreateCampaign;
        private System.Windows.Forms.Label lblTargetClients;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveCampaign;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCampaignName;
        private System.Windows.Forms.GroupBox groupBoxAddClient;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxCustomerRating;
        private System.Windows.Forms.Label lblSaveCustomerError;
    }
}