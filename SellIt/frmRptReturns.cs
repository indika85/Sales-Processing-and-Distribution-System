using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    public partial class frmRptReturns : Form
    {
        string type;
        public frmRptReturns(string ty)
        {
            InitializeComponent();
            type = ty;
            if (ty == "S")
                Text += " [Sales]";
            else
                Text += " [Orders]";
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            frmReportViewer rp;
            if (type == "S")
            {
                rp = new frmReportViewer("Sales Returns", calMonth.SelectionStart.ToShortDateString(), calMonth.SelectionEnd.ToShortDateString());
                rp.Show();
            }
            else
            {
                rp = new frmReportViewer("Order Returns", calMonth.SelectionStart.ToShortDateString(), calMonth.SelectionEnd.ToShortDateString());
                rp.Show();
            }
        }
    }
}