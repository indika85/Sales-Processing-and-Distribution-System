namespace SellIt
{
    partial class frmRptReturns
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
            this.btnGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calMonth
            // 
            this.calMonth.Location = new System.Drawing.Point(0, 0);
            this.calMonth.Name = "calMonth";
            this.calMonth.TabIndex = 0;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(103, 167);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // frmReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 195);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.calMonth);
            this.Name = "frmReturns";
            this.Text = "Returns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calMonth;
        private System.Windows.Forms.Button btnGen;
    }
}