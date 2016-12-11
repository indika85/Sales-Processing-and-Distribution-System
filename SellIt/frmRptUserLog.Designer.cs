namespace SellIt
{
    partial class frmRptUserLog
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
            this.monDt = new System.Windows.Forms.MonthCalendar();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.mnuctx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGen = new EnhancedGlassButton.GlassButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuctx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monDt
            // 
            this.monDt.Location = new System.Drawing.Point(18, 42);
            this.monDt.Name = "monDt";
            this.monDt.TabIndex = 0;
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbDate.Checked = true;
            this.rbDate.Location = new System.Drawing.Point(18, 13);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(63, 17);
            this.rbDate.TabIndex = 1;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "By Date";
            this.rbDate.UseVisualStyleBackColor = false;
            this.rbDate.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged);
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbUser.Location = new System.Drawing.Point(18, 220);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(62, 17);
            this.rbUser.TabIndex = 2;
            this.rbUser.Text = "By User";
            this.rbUser.UseVisualStyleBackColor = false;
            // 
            // cmbUser
            // 
            this.cmbUser.ContextMenuStrip = this.mnuctx;
            this.cmbUser.Enabled = false;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(18, 243);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(178, 21);
            this.cmbUser.TabIndex = 3;
            // 
            // mnuctx
            // 
            this.mnuctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameToolStripMenuItem,
            this.userIDToolStripMenuItem});
            this.mnuctx.Name = "mnuctx";
            this.mnuctx.Size = new System.Drawing.Size(153, 70);
            // 
            // userNameToolStripMenuItem
            // 
            this.userNameToolStripMenuItem.Name = "userNameToolStripMenuItem";
            this.userNameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userNameToolStripMenuItem.Text = "User Name";
            this.userNameToolStripMenuItem.Click += new System.EventHandler(this.userNameToolStripMenuItem_Click);
            // 
            // userIDToolStripMenuItem
            // 
            this.userIDToolStripMenuItem.Checked = true;
            this.userIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.userIDToolStripMenuItem.Name = "userIDToolStripMenuItem";
            this.userIDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userIDToolStripMenuItem.Text = "User ID";
            this.userIDToolStripMenuItem.Click += new System.EventHandler(this.userIDToolStripMenuItem_Click);
            // 
            // btnGen
            // 
            this.btnGen.AnimateGlow = true;
            this.btnGen.Location = new System.Drawing.Point(125, 294);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(79, 23);
            this.btnGen.TabIndex = 42;
            this.btnGen.Text = "Generate";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 323);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 1);
            this.label1.TabIndex = 44;
            // 
            // frmRptUserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 331);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.rbDate);
            this.Controls.Add(this.monDt);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmRptUserLog";
            this.Text = "Users Report";
            this.Load += new System.EventHandler(this.frmRptUserLog_Load);
            this.mnuctx.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monDt;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ContextMenuStrip mnuctx;
        private System.Windows.Forms.ToolStripMenuItem userNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userIDToolStripMenuItem;
        private EnhancedGlassButton.GlassButton btnGen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}