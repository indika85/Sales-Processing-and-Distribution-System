namespace SellIt
{
    partial class frmRptStockTx
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
            this.calMonth = new System.Windows.Forms.MonthCalendar();
            this.rbMon = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.cmbTxId = new System.Windows.Forms.ComboBox();
            this.btnGen = new EnhancedGlassButton.GlassButton();
            this.btnCancel = new EnhancedGlassButton.GlassButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calMonth
            // 
            this.calMonth.Location = new System.Drawing.Point(11, 28);
            this.calMonth.Name = "calMonth";
            this.calMonth.TabIndex = 1;
            // 
            // rbMon
            // 
            this.rbMon.AutoSize = true;
            this.rbMon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbMon.Checked = true;
            this.rbMon.Location = new System.Drawing.Point(242, 76);
            this.rbMon.Name = "rbMon";
            this.rbMon.Size = new System.Drawing.Size(93, 17);
            this.rbMon.TabIndex = 2;
            this.rbMon.TabStop = true;
            this.rbMon.Text = "By Transfer ID";
            this.rbMon.UseVisualStyleBackColor = false;
            this.rbMon.CheckedChanged += new System.EventHandler(this.rbMon_CheckedChanged);
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbDaily.Location = new System.Drawing.Point(242, 99);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(63, 17);
            this.rbDaily.TabIndex = 3;
            this.rbDaily.Text = "By Date";
            this.rbDaily.UseVisualStyleBackColor = false;
            this.rbDaily.CheckedChanged += new System.EventHandler(this.rbDaily_CheckedChanged);
            // 
            // cmbTxId
            // 
            this.cmbTxId.FormattingEnabled = true;
            this.cmbTxId.Location = new System.Drawing.Point(201, 28);
            this.cmbTxId.Name = "cmbTxId";
            this.cmbTxId.Size = new System.Drawing.Size(121, 21);
            this.cmbTxId.TabIndex = 4;
            // 
            // btnGen
            // 
            this.btnGen.AnimateGlow = true;
            this.btnGen.GlowColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGen.Location = new System.Drawing.Point(275, 142);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 31;
            this.btnGen.Text = "Genarate";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimateGlow = true;
            this.btnCancel.GlowColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(269, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbTxId);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.calMonth);
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 258);
            this.panel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "You can select a range of dates by selecting the start date \r\nand draging the mou" +
                "se pointer to the end date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Select the Date or the Month that you want to create the report.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 224);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 1);
            this.textBox2.TabIndex = 40;
            // 
            // frmRptStockTx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 266);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.rbDaily);
            this.Controls.Add(this.rbMon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmRptStockTx";
            this.Text = "Stock Transfers Report";
            this.Load += new System.EventHandler(this.frmRptStockTx_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calMonth;
        private System.Windows.Forms.RadioButton rbMon;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.ComboBox cmbTxId;
        private EnhancedGlassButton.GlassButton btnGen;
        private EnhancedGlassButton.GlassButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}