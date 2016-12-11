namespace SellIt
{
    partial class frmReportViewer
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
            this.rptVw = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptVw
            // 
            this.rptVw.ActiveViewIndex = -1;
            this.rptVw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptVw.DisplayGroupTree = false;
            this.rptVw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptVw.Location = new System.Drawing.Point(0, 0);
            this.rptVw.Name = "rptVw";
            this.rptVw.SelectionFormula = "";
            this.rptVw.ShowRefreshButton = false;
            this.rptVw.Size = new System.Drawing.Size(924, 604);
            this.rptVw.TabIndex = 0;
            this.rptVw.ViewTimeSelectionFormula = "";
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 604);
            this.Controls.Add(this.rptVw);
            this.Name = "frmReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer - ";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptVw;
    }
}