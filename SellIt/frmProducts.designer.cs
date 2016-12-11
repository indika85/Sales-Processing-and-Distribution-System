namespace SellIt
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numROL = new System.Windows.Forms.NumericUpDown();
            this.numInitStock = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new EnhancedGlassButton.GlassButton();
            this.bntClr = new EnhancedGlassButton.GlassButton();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdSearch = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.arrowDown = new System.Windows.Forms.PictureBox();
            this.lblTrash = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new EnhancedGlassButton.GlassButton();
            this.btnCancel = new EnhancedGlassButton.GlassButton();
            this.lblNoOfRc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.txtSKey = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cxtMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.bntClr);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Please fill the following details to add a new Product to the system.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numMax);
            this.groupBox3.Controls.Add(this.numROL);
            this.groupBox3.Controls.Add(this.numInitStock);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(18, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 89);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stock Details";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(98, 69);
            this.numMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(202, 20);
            this.numMax.TabIndex = 5;
            this.numMax.ThousandsSeparator = true;
            // 
            // numROL
            // 
            this.numROL.Location = new System.Drawing.Point(98, 43);
            this.numROL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numROL.Name = "numROL";
            this.numROL.Size = new System.Drawing.Size(202, 20);
            this.numROL.TabIndex = 4;
            this.numROL.ThousandsSeparator = true;
            // 
            // numInitStock
            // 
            this.numInitStock.Location = new System.Drawing.Point(98, 17);
            this.numInitStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numInitStock.Name = "numInitStock";
            this.numInitStock.Size = new System.Drawing.Size(202, 20);
            this.numInitStock.TabIndex = 3;
            this.numInitStock.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Max Stock (ROQ)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ROL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Initial Stock";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bntClr
            // 
            this.bntClr.Location = new System.Drawing.Point(195, 402);
            this.bntClr.Name = "bntClr";
            this.bntClr.Size = new System.Drawing.Size(75, 23);
            this.bntClr.TabIndex = 7;
            this.bntClr.Text = "Clear";
            this.bntClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(116, 173);
            this.numPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(100, 20);
            this.numPrice.TabIndex = 2;
            this.numPrice.ThousandsSeparator = true;
            this.numPrice.Enter += new System.EventHandler(this.numPrice_Enter);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(116, 97);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(202, 70);
            this.txtDesc.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(16, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(355, 112);
            this.label13.TabIndex = 43;
            // 
            // txtNm
            // 
            this.txtNm.Location = new System.Drawing.Point(116, 72);
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(202, 20);
            this.txtNm.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(116, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product No";
            // 
            // grdSearch
            // 
            this.grdSearch.AllowUserToAddRows = false;
            this.grdSearch.AllowUserToDeleteRows = false;
            this.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdSearch.Location = new System.Drawing.Point(6, 43);
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.ReadOnly = true;
            this.grdSearch.RowHeadersVisible = false;
            this.grdSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdSearch.Size = new System.Drawing.Size(524, 227);
            this.grdSearch.TabIndex = 8;
            this.grdSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdSearch_MouseDown);
            this.grdSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grdSearch_MouseMove);
            this.grdSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdSearch_MouseUp);
            this.grdSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSearch_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.arrowDown);
            this.groupBox2.Controls.Add(this.lblTrash);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.lblNoOfRc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rbName);
            this.groupBox2.Controls.Add(this.txtSKey);
            this.groupBox2.Controls.Add(this.lblMsg);
            this.groupBox2.Controls.Add(this.grdSearch);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(407, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 438);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Search";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 387);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(393, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "You can delete a record by Draging it from the Gata grid and dropping it to the b" +
                "in.";
            // 
            // arrowDown
            // 
            this.arrowDown.Image = ((System.Drawing.Image)(resources.GetObject("arrowDown.Image")));
            this.arrowDown.Location = new System.Drawing.Point(474, 292);
            this.arrowDown.Name = "arrowDown";
            this.arrowDown.Size = new System.Drawing.Size(36, 42);
            this.arrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowDown.TabIndex = 45;
            this.arrowDown.TabStop = false;
            // 
            // lblTrash
            // 
            this.lblTrash.AllowDrop = true;
            this.lblTrash.Image = ((System.Drawing.Image)(resources.GetObject("lblTrash.Image")));
            this.lblTrash.Location = new System.Drawing.Point(457, 321);
            this.lblTrash.Name = "lblTrash";
            this.lblTrash.Size = new System.Drawing.Size(70, 78);
            this.lblTrash.TabIndex = 44;
            this.lblTrash.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragDrop);
            this.lblTrash.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblTrash_DragEnter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 405);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(530, 1);
            this.textBox2.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Insert the Product code ro Product name to search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 317);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(455, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNoOfRc
            // 
            this.lblNoOfRc.AutoSize = true;
            this.lblNoOfRc.Location = new System.Drawing.Point(6, 273);
            this.lblNoOfRc.Name = "lblNoOfRc";
            this.lblNoOfRc.Size = new System.Drawing.Size(109, 13);
            this.lblNoOfRc.TabIndex = 39;
            this.lblNoOfRc.Text = "No of Records Found";
            this.lblNoOfRc.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "You can search and edit branch details here.";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(131, 344);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Product Name";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbName.Location = new System.Drawing.Point(25, 344);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(90, 17);
            this.rbName.TabIndex = 12;
            this.rbName.TabStop = true;
            this.rbName.Text = "Product Code";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // txtSKey
            // 
            this.txtSKey.Location = new System.Drawing.Point(25, 319);
            this.txtSKey.Name = "txtSKey";
            this.txtSKey.Size = new System.Drawing.Size(199, 20);
            this.txtSKey.TabIndex = 11;
            this.txtSKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSKey_KeyDown);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(26, 498);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(6, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(397, 77);
            this.label12.TabIndex = 42;
            // 
            // cxtMnu
            // 
            this.cxtMnu.Name = "cxtMnu";
            this.cxtMnu.Size = new System.Drawing.Size(61, 4);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(755, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mosfly International";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SellIt.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(912, -5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 

            this.pictureBox2.Location = new System.Drawing.Point(-5, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.DataGridView grdSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ContextMenuStrip cxtMnu;
        private System.Windows.Forms.ErrorProvider ep;
        private EnhancedGlassButton.GlassButton bntClr;
        private EnhancedGlassButton.GlassButton btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numROL;
        private System.Windows.Forms.NumericUpDown numInitStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSKey;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbName;
        private EnhancedGlassButton.GlassButton btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNoOfRc;
        private EnhancedGlassButton.GlassButton btnCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox arrowDown;
        private System.Windows.Forms.Label lblTrash;
    }
}