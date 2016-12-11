using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SellIt
{
    public partial class frmBkup : Form
    {
        public frmBkup()
        {
            MdiParent = frmMain.Desk;
            InitializeComponent();
        }

        private void rbBkup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBkup.Checked)
            {
                grpBkup.Enabled = true;
                grpRestore.Enabled = false;
            }
        }

        private void rbRestore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRestore.Checked)
            {
                grpRestore.Enabled = true;
                grpBkup.Enabled = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            txtBkPath.Text = fd.SelectedPath;
        }

        private void btnBkup_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(Application.StartupPath + "\\OPSDB.mdb", txtBkPath.Text + "\\OPSDB_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "--" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + ".dbak");
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            if (File.Exists(txtBkPath.Text + "\\OPSDB_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "--" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + ".dbak"))
                MessageBox.Show("Backup completed","SellIt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Backup failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            //frmMain.con.Close();
            string f=Application.StartupPath+"\\OPSDB.mdb";
            try
            {
                if (File.Exists(f))
                    File.Delete(f);

                File.Copy(txtrestore.Text, "C:\\Documents and Settings\\Nimesha.HOME-NWB99VBFI4\\Desktop\\SellIt\\SellIt\\OPSDB.mdb");
                //frmMain.con.Open();
            }
            catch(Exception ex){dataManipulate.showError(ex);}
        }

        private void btnbr_Click(object sender, EventArgs e)
        {
            od.ShowDialog();
            txtrestore.Text = od.FileName;
        }

        private void frmBkup_Load(object sender, EventArgs e)
        {
            frmMain.Desk.menuStrip.Enabled = false;
            frmMain.Desk.ToolBar.Enabled = false;
        }

        private void frmBkup_Deactivate(object sender, EventArgs e)
        {
            frmMain.Desk.menuStrip.Enabled = true;
            frmMain.Desk.ToolBar.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}