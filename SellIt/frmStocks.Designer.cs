namespace SellIt
{
    partial class frmStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStocks));
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.cmProd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pCode = new System.Windows.Forms.ToolStripMenuItem();
            this.pName = new System.Windows.Forms.ToolStripMenuItem();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbGONID = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.arrowDown = new System.Windows.Forms.PictureBox();
            this.lblTrash = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new EnhancedGlassButton.GlassButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenGrn = new EnhancedGlassButton.GlassButton();
            this.btnAdd = new EnhancedGlassButton.GlassButton();
            this.lblStock = new System.Windows.Forms.Label();
            this.grdGRN = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResStocks = new System.Windows.Forms.MaskedTextBox();
            this.glassButton2 = new EnhancedGlassButton.GlassButton();
            this.glassButton1 = new EnhancedGlassButton.GlassButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGRN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProd
            // 
            this.cmbProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProd.ContextMenuStrip = this.cmProd;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(72, 57);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(169, 21);
            this.cmbProd.TabIndex = 0;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // cmProd
            // 
            this.cmProd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCode,
            this.pName});
            this.cmProd.Name = "cmProd";
            this.cmProd.Size = new System.Drawing.Size(153, 48);
            // 
            // pCode
            // 
            this.pCode.Checked = true;
            this.pCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pCode.Name = "pCode";
            this.pCode.Size = new System.Drawing.Size(152, 22);
            this.pCode.Text = "Product Code";
            this.pCode.Click += new System.EventHandler(this.pCode_Click);
            // 
            // pName
            // 
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(152, 22);
            this.pName.Text = "Product Name";
            this.pName.Click += new System.EventHandler(this.pName_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(339, 58);
            this.numStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(106, 20);
            this.numStock.TabIndex = 1;
            this.numStock.Enter += new System.EventHandler(this.numStock_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbGONID);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblGen);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.arrowDown);
            this.groupBox2.Controls.Add(this.lblTrash);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnGenGrn);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lblStock);
            this.groupBox2.Controls.Add(this.grdGRN);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.pb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numStock);
            this.groupBox2.Controls.Add(this.cmbProd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 588);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Level";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "GON No.";
            // 
            // cmbGONID
            // 
            this.cmbGONID.AllowDrop = true;
            this.cmbGONID.FormattingEnabled = true;
            this.cmbGONID.Location = new System.Drawing.Point(189, 2);
            this.cmbGONID.Name = "cmbGONID";
            this.cmbGONID.Size = new System.Drawing.Size(121, 21);
            this.cmbGONID.TabIndex = 51;
            this.cmbGONID.SelectedIndexChanged += new System.EventHandler(this.cmbGONID_SelectedIndexChanged);
            this.cmbGONID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGONID_KeyDown);
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblID.Location = new System.Drawing.Point(448, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(98, 22);
            this.lblID.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "GRN No.";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(4, 570);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(155, 13);
            this.lblGen.TabIndex = 38;
            this.lblGen.Text = "Genarating GRN. Please wait...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(421, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "You can change the ROL and the Max stock levels by selecting the Edit Special opt" +
                "ion.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 351);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(393, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "You can delete a record by Draging it from the Gata grid and dropping it to the b" +
                "in.";
            // 
            // arrowDown
            // 
            this.arrowDown.Image = ((System.Drawing.Image)(resources.GetObject("arrowDown.Image")));
            this.arrowDown.Location = new System.Drawing.Point(559, 410);
            this.arrowDown.Name = "arrowDown";
            this.arrowDown.Size = new System.Drawing.Size(36, 42);
            this.arrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowDown.TabIndex = 46;
            this.arrowDown.TabStop = false;
            // 
            // lblTrash
            // 
            this.lblTrash.AllowDrop = true;
            this.lblTrash.Image = ((System.Drawing.Image)(resources.GetObject("lblTrash.Image")));
            this.lblTrash.Location = new System.Drawing.Point(542, 439);
            this.lblTrash.Name = "lblTrash";
            this.lblTrash.Size = new System.Drawing.Size(70, 78);
            this.lblTrash.TabIndex = 45;
            this.lblTrash.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragDrop);
            this.lblTrash.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Shows the current stock level.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 549);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(622, 1);
            this.textBox2.TabIndex = 43;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimateGlow = true;
            this.btnCancel.GlowColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(529, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Please selectthe product and quantity to add new stocks.";
            // 
            // btnGenGrn
            // 
            this.btnGenGrn.AnimateGlow = true;
            this.btnGenGrn.Location = new System.Drawing.Point(507, 354);
            this.btnGenGrn.Name = "btnGenGrn";
            this.btnGenGrn.Size = new System.Drawing.Size(97, 47);
            this.btnGenGrn.TabIndex = 40;
            this.btnGenGrn.Text = "Genarate\r\nGRN";
            this.btnGenGrn.Click += new System.EventHandler(this.btnGenGrn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimateGlow = true;
            this.btnAdd.Location = new System.Drawing.Point(529, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(569, 526);
            this.lblStock.Name = "lblStock";
            this.lblStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStock.Size = new System.Drawing.Size(43, 13);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "............";
            // 
            // grdGRN
            // 
            this.grdGRN.AllowUserToAddRows = false;
            this.grdGRN.AllowUserToDeleteRows = false;
            this.grdGRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGRN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.ROL,
            this.Max});
            this.grdGRN.Location = new System.Drawing.Point(11, 94);
            this.grdGRN.Name = "grdGRN";
            this.grdGRN.RowHeadersVisible = false;
            this.grdGRN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGRN.Size = new System.Drawing.Size(606, 254);
            this.grdGRN.TabIndex = 15;
            this.grdGRN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdGRN_MouseDown);
            this.grdGRN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGRN_CellContentDoubleClick);
            this.grdGRN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grdGRN_MouseMove);
            this.grdGRN.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGRN_CellContentDoubleClick);
            this.grdGRN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdGRN_MouseUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Received Stock";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "New Stock";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ROL
            // 
            this.ROL.HeaderText = "ROL";
            this.ROL.Name = "ROL";
            this.ROL.ReadOnly = true;
            // 
            // Max
            // 
            this.Max.HeaderText = "Max (ROQ)";
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResStocks);
            this.groupBox1.Controls.Add(this.glassButton2);
            this.groupBox1.Controls.Add(this.glassButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(11, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Recieved Stocks";
            // 
            // txtResStocks
            // 
            this.txtResStocks.Location = new System.Drawing.Point(115, 25);
            this.txtResStocks.Name = "txtResStocks";
            this.txtResStocks.Size = new System.Drawing.Size(79, 20);
            this.txtResStocks.TabIndex = 56;
            // 
            // glassButton2
            // 
            this.glassButton2.AnimateGlow = true;
            this.glassButton2.Location = new System.Drawing.Point(305, 23);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(75, 23);
            this.glassButton2.TabIndex = 55;
            this.glassButton2.Text = "Cancel";
            this.glassButton2.Click += new System.EventHandler(this.glassButton2_Click);
            // 
            // glassButton1
            // 
            this.glassButton1.AnimateGlow = true;
            this.glassButton1.Location = new System.Drawing.Point(224, 23);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(75, 23);
            this.glassButton1.TabIndex = 54;
            this.glassButton1.Text = "Set";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Recieved Stocks";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 39);
            this.label6.TabIndex = 41;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(11, 524);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(551, 17);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(611, 59);
            this.label7.TabIndex = 38;
            // 
            // pictureBox2
            // 

            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(446, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mosfly International";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SellIt.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(604, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmStocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.frmStocks_Load);
            this.cmProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGRN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdGRN;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private EnhancedGlassButton.GlassButton btnAdd;
        private EnhancedGlassButton.GlassButton btnGenGrn;
        private System.Windows.Forms.Label label6;
        private EnhancedGlassButton.GlassButton btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.Label lblTrash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip cmProd;
        private System.Windows.Forms.ToolStripMenuItem pCode;
        private System.Windows.Forms.ToolStripMenuItem pName;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbGONID;
        private EnhancedGlassButton.GlassButton glassButton2;
        private EnhancedGlassButton.GlassButton glassButton1;
        private System.Windows.Forms.MaskedTextBox txtResStocks;
    }
}