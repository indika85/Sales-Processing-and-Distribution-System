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
    public partial class frmRptUserLog : Form
    {
        public frmRptUserLog()
        {
            InitializeComponent();
            MdiParent = frmMain.Desk;
        }

        private void frmRptUserLog_Load(object sender, EventArgs e)
        {
            FillUser(0);

        }
        private void FillUser(int mode)
        {
            try
            {
                OleDbCommand cmd;
                OleDbDataReader rd;
                cmbUser.Items.Clear();
                cmbUser.Text = "";
                if (mode == 0)
                {
                    cmd = new OleDbCommand("SELECT id from users", frmMain.con);
                    rd = cmd.ExecuteReader();

                    while (rd.Read())
                        cmbUser.Items.Add("U" + rd.GetValue(0).ToString().PadLeft(3, '0'));
                }
                else
                {
                    cmd = new OleDbCommand("SELECT username from users", frmMain.con);
                    rd = cmd.ExecuteReader();

                    while (rd.Read())
                        cmbUser.Items.Add(rd.GetValue(0).ToString().PadLeft(3, '0'));
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }

        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDate.Checked)
            {
                monDt.Enabled = true;
                cmbUser.Enabled = false;

            }
            else
            {
                monDt.Enabled =false;
                cmbUser.Enabled = true;
            }
        }

        private void userNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userIDToolStripMenuItem.Checked =false;
            userNameToolStripMenuItem.Checked = true;
            FillUser(1);
        }

        private void userIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userIDToolStripMenuItem.Checked = true; ;
            userNameToolStripMenuItem.Checked =false;
            FillUser(0);
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            frmReportViewer rp;
            if (rbDate.Checked)
            {
                rp = new frmReportViewer("User By Date", monDt.SelectionStart.ToShortDateString(), monDt.SelectionEnd.ToShortDateString());
                rp.Show();
            }
            else if(rbUser.Checked && userNameToolStripMenuItem.Checked)
            {
                OleDbCommand cmd=new OleDbCommand("select [id] from users where username='"+cmbUser.SelectedItem.ToString()+"'",frmMain.con);
                rp = new frmReportViewer("User By Name",int.Parse(cmd.ExecuteScalar().ToString()));
                rp.Show();
            }
            else if (rbUser.Checked && userIDToolStripMenuItem.Checked)
            { 
                rp = new frmReportViewer("User By ID", int.Parse(cmbUser.SelectedItem.ToString().Remove(0,1)));
                rp.Show();
            }
        }
    }
}