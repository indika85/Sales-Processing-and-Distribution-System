namespace SellIt
{
    partial class frmPayments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.mnuCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDtTm = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new EnhancedGlassButton.GlassButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new EnhancedGlassButton.GlassButton();
            this.btnClr = new EnhancedGlassButton.GlassButton();
            this.lblTotalAmntToPay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuCtx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Payment amount";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.ContextMenuStrip = this.mnuCtx;
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Enabled = false;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(127, 118);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(193, 21);
            this.cmbCustomer.TabIndex = 16;
            // 
            // mnuCtx
            // 
            this.mnuCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripMenuItem,
            this.customerManeToolStripMenuItem});
            this.mnuCtx.Name = "mnuCtx";
            this.mnuCtx.Size = new System.Drawing.Size(162, 48);
            // 
            // customerIDToolStripMenuItem
            // 
            this.customerIDToolStripMenuItem.Checked = true;
            this.customerIDToolStripMenuItem.CheckOnClick = true;
            this.customerIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customerIDToolStripMenuItem.Name = "customerIDToolStripMenuItem";
            this.customerIDToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.customerIDToolStripMenuItem.Text = "Customer ID";
            this.customerIDToolStripMenuItem.Click += new System.EventHandler(this.customerIDToolStripMenuItem_Click);
            // 
            // customerManeToolStripMenuItem
            // 
            this.customerManeToolStripMenuItem.CheckOnClick = true;
            this.customerManeToolStripMenuItem.Name = "customerManeToolStripMenuItem";
            this.customerManeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.customerManeToolStripMenuItem.Text = "Customer Name";
            this.customerManeToolStripMenuItem.Click += new System.EventHandler(this.customerManeToolStripMenuItem_Click);
            // 
            // lblDtTm
            // 
            this.lblDtTm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDtTm.Location = new System.Drawing.Point(128, 85);
            this.lblDtTm.Name = "lblDtTm";
            this.lblDtTm.Size = new System.Drawing.Size(192, 20);
            this.lblDtTm.TabIndex = 20;
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(128, 202);
            this.numAmount.Maximum = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(193, 20);
            this.numAmount.TabIndex = 21;
            this.numAmount.ThousandsSeparator = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClr);
            this.groupBox1.Controls.Add(this.lblTotalAmntToPay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDtTm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(8, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 329);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment for Orders";
            // 
            // btnCancel
            // 
            this.btnCancel.AnimateGlow = true;
            this.btnCancel.GlowColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(268, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Please select the invoice number or the customer name to do the \r\npayment.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 284);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 1);
            this.textBox1.TabIndex = 42;
            // 
            // btnAdd
            // 
            this.btnAdd.AnimateGlow = true;
            this.btnAdd.Location = new System.Drawing.Point(268, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Pay";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClr
            // 
            this.btnClr.AnimateGlow = true;
            this.btnClr.Location = new System.Drawing.Point(127, 300);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 31;
            this.btnClr.Text = "Clear";
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // lblTotalAmntToPay
            // 
            this.lblTotalAmntToPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmntToPay.Location = new System.Drawing.Point(127, 148);
            this.lblTotalAmntToPay.Name = "lblTotalAmntToPay";
            this.lblTotalAmntToPay.Size = new System.Drawing.Size(192, 20);
            this.lblTotalAmntToPay.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total amount to pay";
            // 
            // cmbPID
            // 
            this.cmbPID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPID.ContextMenuStrip = this.mnuCtx;
            this.cmbPID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPID.FormattingEnabled = true;
            this.cmbPID.Location = new System.Drawing.Point(127, 53);
            this.cmbPID.Name = "cmbPID";
            this.cmbPID.Size = new System.Drawing.Size(194, 21);
            this.cmbPID.TabIndex = 28;
            this.cmbPID.SelectedIndexChanged += new System.EventHandler(this.cmbPID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(9, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 78);
            this.label8.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(199, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Mosfly International";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SellIt.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(349, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2

            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 373);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmPayments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            this.mnuCtx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblDtTm;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip mnuCtx;
        private System.Windows.Forms.ToolStripMenuItem customerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManeToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbPID;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label lblTotalAmntToPay;
        private System.Windows.Forms.Label label3;
        private EnhancedGlassButton.GlassButton btnAdd;
        private EnhancedGlassButton.GlassButton btnClr;
        private EnhancedGlassButton.GlassButton btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}