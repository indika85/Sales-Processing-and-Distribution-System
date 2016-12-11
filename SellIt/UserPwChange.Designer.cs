namespace SellIt
{
    partial class frmUserPwChange
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
            this.lblCurrUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUn = new System.Windows.Forms.CheckBox();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPw = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConfNewPw = new System.Windows.Forms.MaskedTextBox();
            this.txtNewPw = new System.Windows.Forms.MaskedTextBox();
            this.betCancel = new EnhancedGlassButton.GlassButton();
            this.btnOk = new EnhancedGlassButton.GlassButton();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrUser
            // 
            this.lblCurrUser.AutoSize = true;
            this.lblCurrUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCurrUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrUser.Location = new System.Drawing.Point(14, 47);
            this.lblCurrUser.Name = "lblCurrUser";
            this.lblCurrUser.Size = new System.Drawing.Size(88, 16);
            this.lblCurrUser.TabIndex = 0;
            this.lblCurrUser.Text = "Current User: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm New Password";
            // 
            // chkUn
            // 
            this.chkUn.AutoSize = true;
            this.chkUn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chkUn.Location = new System.Drawing.Point(214, 0);
            this.chkUn.Name = "chkUn";
            this.chkUn.Size = new System.Drawing.Size(119, 17);
            this.chkUn.TabIndex = 0;
            this.chkUn.Text = "Change User Name";
            this.chkUn.UseVisualStyleBackColor = false;
            this.chkUn.CheckedChanged += new System.EventHandler(this.chkUn_CheckedChanged);
            // 
            // txtUn
            // 
            this.txtUn.Location = new System.Drawing.Point(126, 49);
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(161, 20);
            this.txtUn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "New User Name";
            // 
            // chkPw
            // 
            this.chkPw.AutoSize = true;
            this.chkPw.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chkPw.Location = new System.Drawing.Point(223, 0);
            this.chkPw.Name = "chkPw";
            this.chkPw.Size = new System.Drawing.Size(112, 17);
            this.chkPw.TabIndex = 2;
            this.chkPw.Text = "Change Password";
            this.chkPw.UseVisualStyleBackColor = false;
            this.chkPw.CheckedChanged += new System.EventHandler(this.chkPw_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkUn);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(14, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 90);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.txtConfNewPw);
            this.groupBox2.Controls.Add(this.txtNewPw);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkPw);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(15, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 113);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // txtConfNewPw
            // 
            this.txtConfNewPw.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtConfNewPw.Location = new System.Drawing.Point(125, 69);
            this.txtConfNewPw.Name = "txtConfNewPw";
            this.txtConfNewPw.Size = new System.Drawing.Size(161, 20);
            this.txtConfNewPw.TabIndex = 19;
            this.txtConfNewPw.UseSystemPasswordChar = true;
            // 
            // txtNewPw
            // 
            this.txtNewPw.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtNewPw.Location = new System.Drawing.Point(125, 35);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.Size = new System.Drawing.Size(161, 20);
            this.txtNewPw.TabIndex = 18;
            this.txtNewPw.UseSystemPasswordChar = true;
            // 
            // betCancel
            // 
            this.betCancel.AnimateGlow = true;
            this.betCancel.GlowColor = System.Drawing.Color.Red;
            this.betCancel.Location = new System.Drawing.Point(133, 292);
            this.betCancel.Name = "betCancel";
            this.betCancel.Size = new System.Drawing.Size(75, 23);
            this.betCancel.TabIndex = 16;
            this.betCancel.Text = "Cancel";
            this.betCancel.Click += new System.EventHandler(this.betCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AnimateGlow = true;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(264, 292);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(199, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mosfly International";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SellIt.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(348, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.betCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(7, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 321);
            this.panel1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter the new username below.";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(2, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 66);
            this.label7.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 76);
            this.label6.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 279);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(355, 1);
            this.textBox2.TabIndex = 40;
            // 
            // frmUserPwChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCurrUser);
            this.Controls.Add(this.panel1);
            this.Name = "frmUserPwChange";
            this.Text = "User Password Change";
            this.Load += new System.EventHandler(this.frmUserPwChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUn;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private EnhancedGlassButton.GlassButton betCancel;
        private EnhancedGlassButton.GlassButton btnOk;
        private System.Windows.Forms.MaskedTextBox txtNewPw;
        private System.Windows.Forms.MaskedTextBox txtConfNewPw;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
    }
}