using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    public partial class frmRptStockTx : Form
    {
        public frmRptStockTx()
        {
            InitializeComponent();
            MdiParent = frmMain.Desk;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (rbDaily.Checked)
            {
                frmReportViewer r = new frmReportViewer("StockTxByID", (cmbTxId.SelectedIndex + 1));
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

                frmReportViewer r= new frmReportViewer("StockTxByDate",sdt ,edt);
                MessageBox.Show(sdt+"  "+edt);
                r.Show();
            }
        }

        private void frmRptStockTx_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT [Txid] FROM [stock transfers]", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                    cmbTxId.Items.Add("TX" + rd.GetValue(0).ToString().PadLeft(4, '0'));
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void rbMon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMon.Checked)
            {
                calMonth.Enabled = false;
                cmbTxId.Enabled = true;
            }
        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDaily.Checked)
            {
                calMonth.Enabled = true;
                cmbTxId.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}