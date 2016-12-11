namespace SellIt
{
    partial class frmReprint
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
            this.lstDoc = new System.Windows.Forms.ListBox();
            this.lstPK = new System.Windows.Forms.ListBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btlCancel = new EnhancedGlassButton.GlassButton();
            this.btnView = new EnhancedGlassButton.GlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDoc
            // 
            this.lstDoc.FormattingEnabled = true;
            this.lstDoc.Items.AddRange(new object[] {
            "Goods Order Note (GON)",
            "Stock Requisition Note (SRN)",
            "Goods Receive Note (GRN)",
            "Sales Invoice",
            "Order Invoice"});
            this.lstDoc.Location = new System.Drawing.Point(12, 28);
            this.lstDoc.Name = "lstDoc";
            this.lstDoc.Size = new System.Drawing.Size(179, 160);
            this.lstDoc.TabIndex = 0;
            this.lstDoc.Click += new System.EventHandler(this.lstDoc_Click);
            // 
            // lstPK
            // 
            this.lstPK.FormattingEnabled = true;
            this.lstPK.Location = new System.Drawing.Point(197, 28);
            this.lstPK.Name = "lstPK";
            this.lstPK.Size = new System.Drawing.Size(120, 160);
            this.lstPK.TabIndex = 1;
            this.lstPK.DoubleClick += new System.EventHandler(this.lstPK_DoubleClick);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Document Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(194, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Index";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btlCancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 245);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(2, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 1);
            this.label3.TabIndex = 5;
            // 
            // btlCancel
            // 
            this.btlCancel.AnimateGlow = true;
            this.btlCancel.GlowColor = System.Drawing.Color.Red;
            this.btlCancel.Location = new System.Drawing.Point(18, 210);
            this.btlCancel.Name = "btlCancel";
            this.btlCancel.Size = new System.Drawing.Size(75, 23);
            this.btlCancel.TabIndex = 40;
            this.btlCancel.Text = "Cancel";
            this.btlCancel.Click += new System.EventHandler(this.btlCancel_Click);
            // 
            // btnView
            // 
            this.btnView.AnimateGlow = true;
            this.btnView.Location = new System.Drawing.Point(235, 210);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 41;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmReprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPK);
            this.Controls.Add(this.lstDoc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmReprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents Reprint";
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDoc;
        private System.Windows.Forms.ListBox lstPK;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private EnhancedGlassButton.GlassButton btnView;
        private EnhancedGlassButton.GlassButton btlCancel;
    }
}