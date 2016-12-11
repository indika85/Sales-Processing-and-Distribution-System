namespace SellIt
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grdSearch = new System.Windows.Forms.DataGridView();
            this.NewCust = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new EnhancedGlassButton.GlassButton();
            this.btnClr = new EnhancedGlassButton.GlassButton();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.numCLimit = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.arrowDown = new System.Windows.Forms.PictureBox();
            this.lblTrash = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNoOfRc = new System.Windows.Forms.Label();
            this.rbCompany = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.rbCusName = new System.Windows.Forms.RadioButton();
            this.btnCancel = new EnhancedGlassButton.GlassButton();
            this.rbCusCode = new System.Windows.Forms.RadioButton();
            this.btnSearch = new EnhancedGlassButton.GlassButton();
            this.label13 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            this.NewCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCLimit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(84, 67);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(338, 20);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(84, 97);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(338, 20);
            this.txtLName.TabIndex = 2;
            this.txtLName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(84, 163);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(338, 20);
            this.txtCompany.TabIndex = 3;
            this.txtCompany.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(84, 239);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddr.Size = new System.Drawing.Size(338, 116);
            this.txtAddr.TabIndex = 6;
            this.txtAddr.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Credit Limit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Balance";
            // 
            // grdSearch
            // 
            this.grdSearch.AllowUserToAddRows = false;
            this.grdSearch.AllowUserToDeleteRows = false;
            this.grdSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdSearch.Location = new System.Drawing.Point(18, 45);
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.ReadOnly = true;
            this.grdSearch.RowHeadersVisible = false;
            this.grdSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSearch.Size = new System.Drawing.Size(480, 255);
            this.grdSearch.TabIndex = 18;
            this.tt.SetToolTip(this.grdSearch, "Double-Click on a row to edit it");
            this.grdSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdSearch_MouseDown);
            this.grdSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grdSearch_MouseMove);
            this.grdSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSearch_CellMouseDoubleClick);
            this.grdSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdSearch_MouseUp);
            // 
            // NewCust
            // 
            this.NewCust.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NewCust.Controls.Add(this.label15);
            this.NewCust.Controls.Add(this.txtNIC);
            this.NewCust.Controls.Add(this.label11);
            this.NewCust.Controls.Add(this.txtMobile);
            this.NewCust.Controls.Add(this.txtPhone);
            this.NewCust.Controls.Add(this.btnAdd);
            this.NewCust.Controls.Add(this.btnClr);
            this.NewCust.Controls.Add(this.numBalance);
            this.NewCust.Controls.Add(this.numCLimit);
            this.NewCust.Controls.Add(this.lblId);
            this.NewCust.Controls.Add(this.label9);
            this.NewCust.Controls.Add(this.label8);
            this.NewCust.Controls.Add(this.label7);
            this.NewCust.Controls.Add(this.txtAddr);
            this.NewCust.Controls.Add(this.label6);
            this.NewCust.Controls.Add(this.label5);
            this.NewCust.Controls.Add(this.label4);
            this.NewCust.Controls.Add(this.txtCompany);
            this.NewCust.Controls.Add(this.label3);
            this.NewCust.Controls.Add(this.txtLName);
            this.NewCust.Controls.Add(this.label2);
            this.NewCust.Controls.Add(this.txtFName);
            this.NewCust.Controls.Add(this.label1);
            this.NewCust.Location = new System.Drawing.Point(9, 41);
            this.NewCust.Name = "NewCust";
            this.NewCust.Size = new System.Drawing.Size(454, 487);
            this.NewCust.TabIndex = 19;
            this.NewCust.TabStop = false;
            this.NewCust.Text = "Customer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "NIC";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(83, 129);
            this.txtNIC.MaxLength = 10;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(109, 20);
            this.txtNIC.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(325, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Please fill the following details to add a new customer to the system.";
            // 
            // txtMobile
            // 
            this.txtMobile.AsciiOnly = true;
            this.txtMobile.HidePromptOnLeave = true;
            this.txtMobile.Location = new System.Drawing.Point(322, 199);
            this.txtMobile.Mask = "0000000000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PromptChar = ' ';
            this.txtMobile.RejectInputOnFirstFailure = true;
            this.txtMobile.Size = new System.Drawing.Size(100, 20);
            this.txtMobile.TabIndex = 30;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.AllowPromptAsInput = false;
            this.txtPhone.AsciiOnly = true;
            this.txtPhone.HidePromptOnLeave = true;
            this.txtPhone.Location = new System.Drawing.Point(84, 195);
            this.txtPhone.Mask = "0000000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PromptChar = ' ';
            this.txtPhone.RejectInputOnFirstFailure = true;
            this.txtPhone.Size = new System.Drawing.Size(108, 20);
            this.txtPhone.TabIndex = 29;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimateGlow = true;
            this.btnAdd.Location = new System.Drawing.Point(347, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClr
            // 
            this.btnClr.AnimateGlow = true;
            this.btnClr.Location = new System.Drawing.Point(242, 455);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 25;
            this.btnClr.Text = "Clear";
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // numBalance
            // 
            this.numBalance.DecimalPlaces = 2;
            this.numBalance.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBalance.Location = new System.Drawing.Point(322, 366);
            this.numBalance.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numBalance.Name = "numBalance";
            this.numBalance.Size = new System.Drawing.Size(100, 20);
            this.numBalance.TabIndex = 24;
            this.numBalance.ThousandsSeparator = true;
            this.numBalance.Enter += new System.EventHandler(this.numBalance_Enter);
            // 
            // numCLimit
            // 
            this.numCLimit.DecimalPlaces = 2;
            this.numCLimit.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCLimit.Location = new System.Drawing.Point(84, 366);
            this.numCLimit.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numCLimit.Name = "numCLimit";
            this.numCLimit.Size = new System.Drawing.Size(108, 20);
            this.numCLimit.TabIndex = 23;
            this.numCLimit.ThousandsSeparator = true;
            this.numCLimit.Enter += new System.EventHandler(this.numCLimit_Enter);
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(84, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(108, 20);
            this.lblId.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.arrowDown);
            this.groupBox1.Controls.Add(this.lblTrash);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblNoOfRc);
            this.groupBox1.Controls.Add(this.rbCompany);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.txtSearchKey);
            this.groupBox1.Controls.Add(this.rbCusName);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.rbCusCode);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.grdSearch);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(472, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 487);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Search";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 427);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(393, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "You can delete a record by Draging it from the Gata grid and dropping it to the b" +
                "in.\r\n";
            // 
            // arrowDown
            // 
            this.arrowDown.Image = ((System.Drawing.Image)(resources.GetObject("arrowDown.Image")));
            this.arrowDown.Location = new System.Drawing.Point(445, 330);
            this.arrowDown.Name = "arrowDown";
            this.arrowDown.Size = new System.Drawing.Size(36, 42);
            this.arrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowDown.TabIndex = 44;
            this.arrowDown.TabStop = false;
            // 
            // lblTrash
            // 
            this.lblTrash.AllowDrop = true;
            this.lblTrash.Image = ((System.Drawing.Image)(resources.GetObject("lblTrash.Image")));
            this.lblTrash.Location = new System.Drawing.Point(428, 359);
            this.lblTrash.Name = "lblTrash";
            this.lblTrash.Size = new System.Drawing.Size(70, 78);
            this.lblTrash.TabIndex = 43;
            this.lblTrash.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragDrop);
            this.lblTrash.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragEnter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 445);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(490, 1);
            this.textBox2.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(337, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Insert the Customer code, customer name or company name to search";
            // 
            // lblNoOfRc
            // 
            this.lblNoOfRc.AutoSize = true;
            this.lblNoOfRc.Location = new System.Drawing.Point(22, 306);
            this.lblNoOfRc.Name = "lblNoOfRc";
            this.lblNoOfRc.Size = new System.Drawing.Size(109, 13);
            this.lblNoOfRc.TabIndex = 39;
            this.lblNoOfRc.Text = "No of Records Found";
            this.lblNoOfRc.Visible = false;
            // 
            // rbCompany
            // 
            this.rbCompany.AutoSize = true;
            this.rbCompany.Location = new System.Drawing.Point(227, 379);
            this.rbCompany.Name = "rbCompany";
            this.rbCompany.Size = new System.Drawing.Size(69, 17);
            this.rbCompany.TabIndex = 33;
            this.rbCompany.Text = "Company";
            this.rbCompany.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "You can search and edit customer details here.";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(18, 325);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 32;
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(21, 352);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(216, 20);
            this.txtSearchKey.TabIndex = 31;
            this.tt.SetToolTip(this.txtSearchKey, "Type % to represent any number of characters\r\nType _ to represent any one  charac" +
                    "ter");
            this.txtSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchKey_KeyDown);
            // 
            // rbCusName
            // 
            this.rbCusName.AutoSize = true;
            this.rbCusName.Location = new System.Drawing.Point(121, 379);
            this.rbCusName.Name = "rbCusName";
            this.rbCusName.Size = new System.Drawing.Size(100, 17);
            this.rbCusName.TabIndex = 30;
            this.rbCusName.Text = "Customer Name";
            this.rbCusName.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimateGlow = true;
            this.btnCancel.GlowColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(423, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbCusCode
            // 
            this.rbCusCode.AutoSize = true;
            this.rbCusCode.Checked = true;
            this.rbCusCode.Location = new System.Drawing.Point(18, 379);
            this.rbCusCode.Name = "rbCusCode";
            this.rbCusCode.Size = new System.Drawing.Size(97, 17);
            this.rbCusCode.TabIndex = 29;
            this.rbCusCode.TabStop = true;
            this.rbCusCode.Text = "Customer Code";
            this.rbCusCode.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimateGlow = true;
            this.btnSearch.Location = new System.Drawing.Point(297, 352);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(6, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(376, 82);
            this.label13.TabIndex = 40;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 5000;
            this.tt.InitialDelay = 500;
            this.tt.IsBalloon = true;
            this.tt.ReshowDelay = 100;
            this.tt.ShowAlways = true;
            this.tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt.ToolTipTitle = "Quick Help";
            // 
            // pictureBox2
            // 

            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1012, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(750, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Mosfly International";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SellIt.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(951, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 538);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewCust);
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "OK";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            this.NewCust.ResumeLayout(false);
            this.NewCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCLimit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grdSearch;
        private System.Windows.Forms.GroupBox NewCust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.NumericUpDown numCLimit;
        private System.Windows.Forms.ToolTip tt;
        private EnhancedGlassButton.GlassButton btnClr;
        private EnhancedGlassButton.GlassButton btnAdd;
        private EnhancedGlassButton.GlassButton btnSearch;
        private EnhancedGlassButton.GlassButton btnCancel;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.RadioButton rbCusName;
        private System.Windows.Forms.RadioButton rbCusCode;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.RadioButton rbCompany;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNoOfRc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.Label lblTrash;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNIC;
    }
}