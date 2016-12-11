namespace SellIt
{
    partial class frmGON
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGON));
            this.grdGON = new System.Windows.Forms.DataGridView();
            this.iCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addProductsBelowReorderLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numOrdQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGONNo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBr = new System.Windows.Forms.ComboBox();
            this.rbSTN = new System.Windows.Forms.RadioButton();
            this.rbGON = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.arrowDown = new System.Windows.Forms.PictureBox();
            this.lblTrash = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new EnhancedGlassButton.GlassButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new EnhancedGlassButton.GlassButton();
            this.btnGenerate = new EnhancedGlassButton.GlassButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdGON)).BeginInit();
            this.mnuCtx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGON
            // 
            this.grdGON.AllowUserToAddRows = false;
            this.grdGON.AllowUserToDeleteRows = false;
            this.grdGON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iCode,
            this.iName,
            this.iDesc,
            this.CurrStock,
            this.iRol,
            this.iMax,
            this.ordQty,
            this.price});
            this.grdGON.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdGON.Location = new System.Drawing.Point(19, 205);
            this.grdGON.Name = "grdGON";
            this.grdGON.ReadOnly = true;
            this.grdGON.RowHeadersVisible = false;
            this.grdGON.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGON.Size = new System.Drawing.Size(689, 217);
            this.grdGON.TabIndex = 0;
            this.grdGON.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdGON_MouseDown);
            this.grdGON.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grdGON_MouseMove);
            this.grdGON.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdGON_MouseUp);
            this.grdGON.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdGON_KeyDown);
            this.grdGON.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grdGON_RowsRemoved);
            this.grdGON.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdGON_KeyUp);
            // 
            // iCode
            // 
            this.iCode.HeaderText = "Item Code";
            this.iCode.Name = "iCode";
            this.iCode.ReadOnly = true;
            // 
            // iName
            // 
            this.iName.HeaderText = "Item Name";
            this.iName.Name = "iName";
            this.iName.ReadOnly = true;
            // 
            // iDesc
            // 
            this.iDesc.HeaderText = "Description";
            this.iDesc.Name = "iDesc";
            this.iDesc.ReadOnly = true;
            // 
            // CurrStock
            // 
            this.CurrStock.HeaderText = "Current Stock";
            this.CurrStock.Name = "CurrStock";
            this.CurrStock.ReadOnly = true;
            // 
            // iRol
            // 
            this.iRol.HeaderText = "ROL";
            this.iRol.Name = "iRol";
            this.iRol.ReadOnly = true;
            // 
            // iMax
            // 
            this.iMax.HeaderText = "Max Stock";
            this.iMax.Name = "iMax";
            this.iMax.ReadOnly = true;
            // 
            // ordQty
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.ordQty.HeaderText = "Order Qty";
            this.ordQty.Name = "ordQty";
            this.ordQty.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // mnuCtx
            // 
            this.mnuCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsBelowReorderLevelToolStripMenuItem});
            this.mnuCtx.Name = "mnuCtx";
            this.mnuCtx.Size = new System.Drawing.Size(245, 26);
            // 
            // addProductsBelowReorderLevelToolStripMenuItem
            // 
            this.addProductsBelowReorderLevelToolStripMenuItem.Name = "addProductsBelowReorderLevelToolStripMenuItem";
            this.addProductsBelowReorderLevelToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.addProductsBelowReorderLevelToolStripMenuItem.Text = "Add products below reorder level";
            this.addProductsBelowReorderLevelToolStripMenuItem.Click += new System.EventHandler(this.addProductsBelowReorderLevelToolStripMenuItem_Click);
            // 
            // cmbProd
            // 
            this.cmbProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(72, 88);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(197, 21);
            this.cmbProd.TabIndex = 4;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(14, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Right Click on Add button to automatically add products which are below the re-or" +
                "der level";
            // 
            // numOrdQty
            // 
            this.numOrdQty.Location = new System.Drawing.Point(333, 90);
            this.numOrdQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOrdQty.Name = "numOrdQty";
            this.numOrdQty.Size = new System.Drawing.Size(82, 20);
            this.numOrdQty.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(279, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(519, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mosfly International";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblGONNo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbBr);
            this.panel1.Controls.Add(this.rbSTN);
            this.panel1.Controls.Add(this.rbGON);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.arrowDown);
            this.panel1.Controls.Add(this.lblTrash);
            this.panel1.Controls.Add(this.lblGen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numOrdQty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbProd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(8, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 541);
            this.panel1.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Total Amount : ";
            // 
            // lblGONNo
            // 
            this.lblGONNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGONNo.Enabled = false;
            this.lblGONNo.Location = new System.Drawing.Point(583, 7);
            this.lblGONNo.Name = "lblGONNo";
            this.lblGONNo.Size = new System.Drawing.Size(97, 18);
            this.lblGONNo.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(523, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "GON No :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(421, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Branch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(185, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Requesting from";
            // 
            // cmbBr
            // 
            this.cmbBr.Enabled = false;
            this.cmbBr.FormattingEnabled = true;
            this.cmbBr.Location = new System.Drawing.Point(271, 51);
            this.cmbBr.Name = "cmbBr";
            this.cmbBr.Size = new System.Drawing.Size(121, 21);
            this.cmbBr.TabIndex = 58;
            // 
            // rbSTN
            // 
            this.rbSTN.AutoSize = true;
            this.rbSTN.Location = new System.Drawing.Point(40, 55);
            this.rbSTN.Name = "rbSTN";
            this.rbSTN.Size = new System.Drawing.Size(134, 17);
            this.rbSTN.TabIndex = 57;
            this.rbSTN.Text = "Stock Requisition Note";
            this.rbSTN.UseVisualStyleBackColor = true;
            // 
            // rbGON
            // 
            this.rbGON.AutoSize = true;
            this.rbGON.Checked = true;
            this.rbGON.Location = new System.Drawing.Point(40, 32);
            this.rbGON.Name = "rbGON";
            this.rbGON.Size = new System.Drawing.Size(111, 17);
            this.rbGON.TabIndex = 56;
            this.rbGON.TabStop = true;
            this.rbGON.Text = "Goods Order Note";
            this.rbGON.UseVisualStyleBackColor = true;
            this.rbGON.CheckedChanged += new System.EventHandler(this.rbGON_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(69, 475);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(393, 13);
            this.label23.TabIndex = 55;
            this.label23.Text = "You can delete a record by Draging it from the Gata grid and dropping it to the b" +
                "in.";
            // 
            // arrowDown
            // 
            this.arrowDown.Image = ((System.Drawing.Image)(resources.GetObject("arrowDown.Image")));
            this.arrowDown.Location = new System.Drawing.Point(25, 385);
            this.arrowDown.Name = "arrowDown";
            this.arrowDown.Size = new System.Drawing.Size(33, 42);
            this.arrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowDown.TabIndex = 54;
            this.arrowDown.TabStop = false;
            // 
            // lblTrash
            // 
            this.lblTrash.AllowDrop = true;
            this.lblTrash.Image = ((System.Drawing.Image)(resources.GetObject("lblTrash.Image")));
            this.lblTrash.Location = new System.Drawing.Point(12, 415);
            this.lblTrash.Name = "lblTrash";
            this.lblTrash.Size = new System.Drawing.Size(60, 74);
            this.lblTrash.TabIndex = 53;
            this.lblTrash.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragDrop);
            this.lblTrash.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragEnter);
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(5, 523);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(157, 13);
            this.lblGen.TabIndex = 44;
            this.lblGen.Text = "Genarating  Note. Please wait...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(5, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Products you add will be listed below.";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimateGlow = true;
            this.btnAdd.ContextMenuStrip = this.mnuCtx;
            this.btnAdd.Location = new System.Drawing.Point(601, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 23);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 491);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(696, 1);
            this.textBox2.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimateGlow = true;
            this.btnCancel.GlowColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(605, 511);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AnimateGlow = true;
            this.btnGenerate.Location = new System.Drawing.Point(589, 447);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(91, 38);
            this.btnGenerate.TabIndex = 31;
            this.btnGenerate.Text = "Genarate\r\nGON";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(12, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "You can Add products which you want to re-order here.";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(7, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(688, 61);
            this.label7.TabIndex = 42;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SellIt.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(691, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 

            this.pictureBox2.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmGON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdGON);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmGON";
            this.Text = "Goods Order Note";
            this.Load += new System.EventHandler(this.frmGON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGON)).EndInit();
            this.mnuCtx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOrdQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGON;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOrdQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip mnuCtx;
        private System.Windows.Forms.ToolStripMenuItem addProductsBelowReorderLevelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private EnhancedGlassButton.GlassButton btnGenerate;
        private EnhancedGlassButton.GlassButton btnCancel;
        private System.Windows.Forms.TextBox textBox2;
        private EnhancedGlassButton.GlassButton btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.Label lblTrash;
        private System.Windows.Forms.RadioButton rbSTN;
        private System.Windows.Forms.RadioButton rbGON;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn iName;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGONNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}