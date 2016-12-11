using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    public partial class frmRptMonthlyOrders : Form
    {
        public frmRptMonthlyOrders()
        {
            InitializeComponent();
            MdiParent = frmMain.Desk;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (rbDaily.Checked)
            {
                frmReportViewer r = new frmReportViewer("Daily Orders", calMonth.SelectionStart.ToShortDateString(), calMonth.SelectionEnd.ToShortDateString());
                r.Show();
            }
            else
            {
                string sdt,edt;
                sdt = calMonth.SelectionStart.Month.ToString() + "/" + "1/" + calMonth.SelectionStart.Year.ToString();

                if (calMonth.SelectionStart.Month != 2 && calMonth.SelectionStart.Month % 2 == 0)
                    edt=calMonth.SelectionStart.Month.ToString() + "/" + "31/" + calMonth.SelectionStart.Year.ToString();
                else if (calMonth.SelectionStart.Month != 2 && calMonth.SelectionStart.Month % 2 == 1)
                    edt = calMonth.SelectionStart.Month.ToString() + "/" + "30/" + calMonth.SelectionStart.Year.ToString();
                else if(calMonth.SelectionStart.Month == 2 && calMonth.SelectionStart.Year%4==0)
                    edt = calMonth.SelectionStart.Month.ToString() + "/" + "29/" + calMonth.SelectionStart.Year.ToString();
                else //if (calMonth.SelectionStart.Month == 2 && calMonth.SelectionStart.Year / 4 != 0)
                    edt = calMonth.SelectionStart.Month.ToString() + "/" + "28/" + calMonth.SelectionStart.Year.ToString();

                frmReportViewer r= new frmReportViewer("Monthly Orders",sdt ,edt);
                r.Show();
            }
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}