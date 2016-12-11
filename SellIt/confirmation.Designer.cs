namespace SellIt
{
    partial class confirmation
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
            this.glassButton1 = new EnhancedGlassButton.GlassButton();
            this.glassButton2 = new EnhancedGlassButton.GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.glassButton3 = new EnhancedGlassButton.GlassButton();
            this.nm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.glassButton4 = new EnhancedGlassButton.GlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm)).BeginInit();
            this.SuspendLayout();
            // 
            // glassButton1
            // 
            this.glassButton1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.glassButton1.Location = new System.Drawing.Point(25, 107);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(75, 23);
            this.glassButton1.TabIndex = 56;
            this.glassButton1.Text = "Yes";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // glassButton2
            // 
            this.glassButton2.Location = new System.Drawing.Point(138, 107);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(75, 23);
            this.glassButton2.TabIndex = 57;
            this.glassButton2.Text = "No";
            this.glassButton2.Click += new System.EventHandler(this.glassButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 65);
            this.label1.TabIndex = 58;
            this.label1.Text = "The purchased quantity of the product is larger than 1.\r\nDo you want to replace t" +
                "hem all ?\r\n\r\n\r\nPress Yes to replase all or press No to specify a quantity.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SellIt.Properties.Resources.questionmark_48;
            this.pictureBox1.Location = new System.Drawing.Point(9, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // glassButton3
            // 
            this.glassButton3.DialogResult = System.Windows.Forms.DialogResult.No;
            this.glassButton3.Location = new System.Drawing.Point(246, 179);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.Size = new System.Drawing.Size(75, 23);
            this.glassButton3.TabIndex = 60;
            this.glassButton3.Text = "Ok";
            this.glassButton3.Click += new System.EventHandler(this.glassButton3_Click);
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(163, 182);
            this.nm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(60, 20);
            this.nm.TabIndex = 61;
            this.nm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Insert the quantity to replace.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 1);
            this.label3.TabIndex = 63;
            // 
            // glassButton4
            // 
            this.glassButton4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.glassButton4.Location = new System.Drawing.Point(246, 107);
            this.glassButton4.Name = "glassButton4";
            this.glassButton4.Size = new System.Drawing.Size(75, 23);
            this.glassButton4.TabIndex = 64;
            this.glassButton4.Text = "Cancel";
            this.glassButton4.Click += new System.EventHandler(this.glassButton4_Click);
            // 
            // confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 224);
            this.Controls.Add(this.glassButton4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.glassButton3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.glassButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "confirmation-SellIt";
            this.Load += new System.EventHandler(this.confirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EnhancedGlassButton.GlassButton glassButton1;
        private EnhancedGlassButton.GlassButton glassButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EnhancedGlassButton.GlassButton glassButton3;
        private System.Windows.Forms.NumericUpDown nm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private EnhancedGlassButton.GlassButton glassButton4;
    }
}