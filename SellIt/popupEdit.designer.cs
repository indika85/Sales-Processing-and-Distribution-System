namespace SellIt
{
    partial class popupEdit
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
            this.txtLow = new System.Windows.Forms.MaskedTextBox();
            this.txtHeigh = new System.Windows.Forms.MaskedTextBox();
            this.txtRate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.glassButton2 = new EnhancedGlassButton.GlassButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(12, 28);
            this.txtLow.Mask = "00000";
            this.txtLow.Name = "txtLow";
            this.txtLow.PromptChar = ' ';
            this.txtLow.Size = new System.Drawing.Size(69, 20);
            this.txtLow.TabIndex = 0;
            this.txtLow.Text = "0";
            this.txtLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLow.ValidatingType = typeof(int);
            this.txtLow.Leave += new System.EventHandler(this.txtLow_Leave);
            // 
            // txtHeigh
            // 
            this.txtHeigh.Location = new System.Drawing.Point(87, 28);
            this.txtHeigh.Mask = "00000";
            this.txtHeigh.Name = "txtHeigh";
            this.txtHeigh.PromptChar = ' ';
            this.txtHeigh.ResetOnSpace = false;
            this.txtHeigh.Size = new System.Drawing.Size(69, 20);
            this.txtHeigh.TabIndex = 1;
            this.txtHeigh.Text = "0";
            this.txtHeigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHeigh.ValidatingType = typeof(int);
            this.txtHeigh.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(200, 28);
            this.txtRate.Mask = "00";
            this.txtRate.Name = "txtRate";
            this.txtRate.PromptChar = ' ';
            this.txtRate.Size = new System.Drawing.Size(69, 20);
            this.txtRate.TabIndex = 2;
            this.txtRate.Text = "0";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Low Bound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "High Bound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discount Rate";
            // 
            // glassButton2
            // 
            this.glassButton2.Location = new System.Drawing.Point(200, 72);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(69, 23);
            this.glassButton2.TabIndex = 3;
            this.glassButton2.Text = "Ok";
            this.glassButton2.Click += new System.EventHandler(this.glassButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "%";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 1);
            this.textBox1.TabIndex = 57;
            // 
            // popupEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(289, 107);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtHeigh);
            this.Controls.Add(this.txtLow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "popupEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "popupEdit";
            this.Activated += new System.EventHandler(this.popupEdit_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.popupEdit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtLow;
        private System.Windows.Forms.MaskedTextBox txtHeigh;
        private System.Windows.Forms.MaskedTextBox txtRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private EnhancedGlassButton.GlassButton glassButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.TextBox textBox1;
    }
}