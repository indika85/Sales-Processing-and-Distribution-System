namespace SellIt
{
    partial class frmRptMonthlySales
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
            this.btnGen = new EnhancedGlassButton.GlassButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.glassButton1 = new EnhancedGlassButton.GlassButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calMonth
            // 
            this.calMonth.Location = new System.Drawing.Point(11, 24);
            this.calMonth.Name = "calMonth";
            this.calMonth.TabIndex = 1;
            // 
            // rbMon
            // 
            this.rbMon.AutoSize = true;
            this.rbMon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbMon.Checked = true;
            this.rbMon.Location = new System.Drawing.Point(242, 66);
            this.rbMon.Name = "rbMon";
            this.rbMon.Size = new System.Drawing.Size(97, 17);
            this.rbMon.TabIndex = 2;
            this.rbMon.TabStop = true;
            this.rbMon.Text = "Monthly Report";
            this.rbMon.UseVisualStyleBackColor = false;
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbDaily.Location = new System.Drawing.Point(242, 89);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(83, 17);
            this.rbDaily.TabIndex = 3;
            this.rbDaily.Text = "Daily Report";
            this.rbDaily.UseVisualStyleBackColor = false;
            // 
            // btnGen
            // 
            this.btnGen.AnimateGlow = true;
            this.btnGen.GlowColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGen.Location = new System.Drawing.Point(268, 156);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 30;
            this.btnGen.Text = "Genarate";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnGen);
            this.panel1.Controls.Add(this.glassButton1);
            this.panel1.Controls.Add(this.calMonth);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 258);
            this.panel1.TabIndex = 31;
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
            this.textBox2.Location = new System.Drawing.Point(4, 221);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 1);
            this.textBox2.TabIndex = 40;
            // 
            // glassButton1
            // 
            this.glassButton1.AnimateGlow = true;
            this.glassButton1.GlowColor = System.Drawing.Color.Red;
            this.glassButton1.Location = new System.Drawing.Point(268, 227);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(75, 23);
            this.glassButton1.TabIndex = 31;
            this.glassButton1.Text = "Cancel";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // frmRptMonthlySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 270);
            this.Controls.Add(this.rbDaily);
            this.Controls.Add(this.rbMon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmRptMonthlySales";
            this.Text = "Sales Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calMonth;
        private System.Windows.Forms.RadioButton rbMon;
        private System.Windows.Forms.RadioButton rbDaily;
        private EnhancedGlassButton.GlassButton btnGen;
        private System.Windows.Forms.Panel panel1;
        private EnhancedGlassButton.GlassButton glassButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}