namespace SellIt
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClr = new EnhancedGlassButton.GlassButton();
            this.btnAdd = new EnhancedGlassButton.GlassButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpAcc = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.arrowDown = new System.Windows.Forms.PictureBox();
            this.lblTrash = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new EnhancedGlassButton.GlassButton();
            this.lblNoOfRc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearch = new EnhancedGlassButton.GlassButton();
            this.lblSearchStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.grdSearch = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grpAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnClr);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.grpAcc);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Deatils";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(316, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Please fill the following details to add a new Branch to the system.";
            // 
            // btnClr
            // 
            this.btnClr.AnimateGlow = true;
            this.btnClr.Location = new System.Drawing.Point(196, 479);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 28;
            this.btnClr.Text = "Clear";
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimateGlow = true;
            this.btnAdd.Location = new System.Drawing.Point(299, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "To edit User Account Details, Use the role manager";
            this.label10.Visible = false;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(112, 102);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(227, 20);
            this.txtLName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Last Name";
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(112, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(84, 24);
            this.lblId.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "User #";
            // 
            // grpAcc
            // 
            this.grpAcc.Controls.Add(this.label9);
            this.grpAcc.Controls.Add(this.cmbRole);
            this.grpAcc.Controls.Add(this.txtConfPass);
            this.grpAcc.Controls.Add(this.label5);
            this.grpAcc.Controls.Add(this.txtPass);
            this.grpAcc.Controls.Add(this.label4);
            this.grpAcc.Controls.Add(this.txtId);
            this.grpAcc.Controls.Add(this.label3);
            this.grpAcc.Controls.Add(this.label15);
            this.grpAcc.Location = new System.Drawing.Point(11, 240);
            this.grpAcc.Name = "grpAcc";
            this.grpAcc.Size = new System.Drawing.Size(363, 134);
            this.grpAcc.TabIndex = 6;
            this.grpAcc.TabStop = false;
            this.grpAcc.Text = "User Account Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbRole.Location = new System.Drawing.Point(125, 99);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(227, 21);
            this.cmbRole.TabIndex = 7;
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(125, 73);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(227, 20);
            this.txtConfPass.TabIndex = 6;
            this.txtConfPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirmation password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(125, 47);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(227, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(227, 20);
            this.txtId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Id";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(5, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(358, 118);
            this.label15.TabIndex = 34;
            this.label15.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(112, 136);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(227, 73);
            this.txtDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.arrowDown);
            this.groupBox3.Controls.Add(this.lblTrash);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.lblNoOfRc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.lblSearchStatus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSearchKey);
            this.groupBox3.Controls.Add(this.grdSearch);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(418, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 510);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 451);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(393, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "You can delete a record by Draging it from the Gata grid and dropping it to the b" +
                "in.\r\n";
            // 
            // arrowDown
            // 
            this.arrowDown.Image = ((System.Drawing.Image)(resources.GetObject("arrowDown.Image")));
            this.arrowDown.Location = new System.Drawing.Point(403, 353);
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
            this.lblTrash.Location = new System.Drawing.Point(386, 382);
            this.lblTrash.Name = "lblTrash";
            this.lblTrash.Size = new System.Drawing.Size(70, 78);
            this.lblTrash.TabIndex = 43;
            this.lblTrash.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragDrop);
            this.lblTrash.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragEnter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 468);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 1);
            this.textBox2.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimateGlow = true;
            this.btnCancel.Location = new System.Drawing.Point(359, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNoOfRc
            // 
            this.lblNoOfRc.AutoSize = true;
            this.lblNoOfRc.Location = new System.Drawing.Point(6, 348);
            this.lblNoOfRc.Name = "lblNoOfRc";
            this.lblNoOfRc.Size = new System.Drawing.Size(109, 13);
            this.lblNoOfRc.TabIndex = 37;
            this.lblNoOfRc.Text = "No of Records Found";
            this.lblNoOfRc.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "You can search and edit User details here.";
            // 
            // btnSearch
            // 
            this.btnSearch.AnimateGlow = true;
            this.btnSearch.Location = new System.Drawing.Point(263, 395);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchStatus
            // 
            this.lblSearchStatus.AutoSize = true;
            this.lblSearchStatus.Location = new System.Drawing.Point(8, 448);
            this.lblSearchStatus.Name = "lblSearchStatus";
            this.lblSearchStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSearchStatus.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "User Name";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(86, 398);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(147, 20);
            this.txtSearchKey.TabIndex = 11;
            this.txtSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchKey_KeyDown);
            // 
            // grdSearch
            // 
            this.grdSearch.AllowUserToAddRows = false;
            this.grdSearch.AllowUserToDeleteRows = false;
            this.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdSearch.Location = new System.Drawing.Point(6, 45);
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.ReadOnly = true;
            this.grdSearch.RowHeadersVisible = false;
            this.grdSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSearch.Size = new System.Drawing.Size(450, 298);
            this.grdSearch.TabIndex = 0;
            this.grdSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdSerarch_MouseDown);
            this.grdSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSerarch_CellDoubleClick);
            this.grdSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grdSerarch_MouseMove);
            this.grdSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdSerarch_MouseUp);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(10, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(349, 45);
            this.label14.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(698, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Mosfly International";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SellIt.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(858, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 

            this.pictureBox2.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 555);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUsers";
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsers_FormClosing);
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAcc.ResumeLayout(false);
            this.grpAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpAcc;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdSearch;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Label lblSearchStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EnhancedGlassButton.GlassButton btnClr;
        private EnhancedGlassButton.GlassButton btnAdd;
        private EnhancedGlassButton.GlassButton btnSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNoOfRc;
        private EnhancedGlassButton.GlassButton btnCancel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.Label lblTrash;
        private System.Windows.Forms.Label label15;
    }
}