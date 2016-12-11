namespace SellIt
{
    partial class frmBkup
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
            this.rbBkup = new System.Windows.Forms.RadioButton();
            this.rbRestore = new System.Windows.Forms.RadioButton();
            this.grpBkup = new System.Windows.Forms.GroupBox();
            this.txtBkPath = new System.Windows.Forms.TextBox();
            this.fd = new System.Windows.Forms.FolderBrowserDialog();
            this.od = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new EnhancedGlassButton.GlassButton();
            this.btnBkup = new EnhancedGlassButton.GlassButton();
            this.txtrestore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbr = new EnhancedGlassButton.GlassButton();
            this.btnRestore = new EnhancedGlassButton.GlassButton();
            this.label6 = new System.Windows.Forms.Label();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new EnhancedGlassButton.GlassButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBkup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpRestore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBkup
            // 
            this.rbBkup.AutoSize = true;
            this.rbBkup.Checked = true;
            this.rbBkup.Location = new System.Drawing.Point(17, 26);
            this.rbBkup.Name = "rbBkup";
            this.rbBkup.Size = new System.Drawing.Size(62, 17);
            this.rbBkup.TabIndex = 0;
            this.rbBkup.TabStop = true;
            this.rbBkup.Text = "Backup";
            this.rbBkup.UseVisualStyleBackColor = true;
            this.rbBkup.CheckedChanged += new System.EventHandler(this.rbBkup_CheckedChanged);
            // 
            // rbRestore
            // 
            this.rbRestore.AutoSize = true;
            this.rbRestore.Location = new System.Drawing.Point(12, 158);
            this.rbRestore.Name = "rbRestore";
            this.rbRestore.Size = new System.Drawing.Size(62, 17);
            this.rbRestore.TabIndex = 2;
            this.rbRestore.Text = "Restore";
            this.rbRestore.UseVisualStyleBackColor = true;
            this.rbRestore.CheckedChanged += new System.EventHandler(this.rbRestore_CheckedChanged);
            // 
            // grpBkup
            // 
            this.grpBkup.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBkup.Controls.Add(this.btnBkup);
            this.grpBkup.Controls.Add(this.btnBrowse);
            this.grpBkup.Controls.Add(this.label2);
            this.grpBkup.Controls.Add(this.label4);
            this.grpBkup.Controls.Add(this.txtBkPath);
            this.grpBkup.Controls.Add(this.label7);
            this.grpBkup.Location = new System.Drawing.Point(12, 77);
            this.grpBkup.Name = "grpBkup";
            this.grpBkup.Size = new System.Drawing.Size(695, 114);
            this.grpBkup.TabIndex = 2;
            this.grpBkup.TabStop = false;
            // 
            // txtBkPath
            // 
            this.txtBkPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBkPath.Location = new System.Drawing.Point(89, 41);
            this.txtBkPath.Name = "txtBkPath";
            this.txtBkPath.ReadOnly = true;
            this.txtBkPath.Size = new System.Drawing.Size(499, 20);
            this.txtBkPath.TabIndex = 1;
            // 
            // od
            // 
            this.od.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(533, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Mosfly International";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SellIt.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(683, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Backup to :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Select the Directory that you want to backup the Database,";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimateGlow = true;
            this.btnBrowse.GlowColor = System.Drawing.Color.Red;
            this.btnBrowse.Location = new System.Drawing.Point(614, 41);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 42;
            this.btnBrowse.Text = "Brows";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnBkup
            // 
            this.btnBkup.AnimateGlow = true;
            this.btnBkup.GlowColor = System.Drawing.Color.Red;
            this.btnBkup.Location = new System.Drawing.Point(614, 80);
            this.btnBkup.Name = "btnBkup";
            this.btnBkup.Size = new System.Drawing.Size(75, 23);
            this.btnBkup.TabIndex = 43;
            this.btnBkup.Text = "Backup";
            this.btnBkup.Click += new System.EventHandler(this.btnBkup_Click);
            // 
            // txtrestore
            // 
            this.txtrestore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtrestore.Location = new System.Drawing.Point(89, 37);
            this.txtrestore.Name = "txtrestore";
            this.txtrestore.ReadOnly = true;
            this.txtrestore.Size = new System.Drawing.Size(499, 20);
            this.txtrestore.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Restore from :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Select the Database which you want to restore,";
            // 
            // btnbr
            // 
            this.btnbr.AnimateGlow = true;
            this.btnbr.GlowColor = System.Drawing.Color.Red;
            this.btnbr.Location = new System.Drawing.Point(607, 34);
            this.btnbr.Name = "btnbr";
            this.btnbr.Size = new System.Drawing.Size(75, 23);
            this.btnbr.TabIndex = 44;
            this.btnbr.Text = "Brows";
            this.btnbr.Click += new System.EventHandler(this.btnbr_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.AnimateGlow = true;
            this.btnRestore.GlowColor = System.Drawing.Color.Red;
            this.btnRestore.Location = new System.Drawing.Point(607, 77);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 45;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "You can Backup and Restore the Database hare.";
            // 
            // grpRestore
            // 
            this.grpRestore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpRestore.Controls.Add(this.btnbr);
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.txtrestore);
            this.grpRestore.Controls.Add(this.label1);
            this.grpRestore.Controls.Add(this.label3);
            this.grpRestore.Controls.Add(this.label8);
            this.grpRestore.Enabled = false;
            this.grpRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpRestore.Location = new System.Drawing.Point(12, 209);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(695, 120);
            this.grpRestore.TabIndex = 46;
            this.grpRestore.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.rbRestore);
            this.groupBox1.Controls.Add(this.rbBkup);
            this.groupBox1.Location = new System.Drawing.Point(6, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 346);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimateGlow = true;
            this.btnCancel.GlowColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(613, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 308);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(699, 1);
            this.textBox1.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(0, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(691, 102);
            this.label8.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(691, 102);
            this.label7.TabIndex = 47;
            // 
            // frmBkup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 390);
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpBkup);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmBkup";
            this.Text = "Backup / Restore Database";
            this.Deactivate += new System.EventHandler(this.frmBkup_Deactivate);
            this.Load += new System.EventHandler(this.frmBkup_Load);
            this.grpBkup.ResumeLayout(false);
            this.grpBkup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBkup;
        private System.Windows.Forms.RadioButton rbRestore;
        private System.Windows.Forms.GroupBox grpBkup;
        private System.Windows.Forms.TextBox txtBkPath;
        private System.Windows.Forms.FolderBrowserDialog fd;
        private System.Windows.Forms.OpenFileDialog od;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EnhancedGlassButton.GlassButton btnBkup;
        private EnhancedGlassButton.GlassButton btnBrowse;
        private System.Windows.Forms.TextBox txtrestore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private EnhancedGlassButton.GlassButton btnbr;
        private EnhancedGlassButton.GlassButton btnRestore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnhancedGlassButton.GlassButton btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}