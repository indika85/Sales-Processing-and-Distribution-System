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
    public partial class frmReprint : Form
    {
        public frmReprint()
        {
            InitializeComponent();
            MdiParent = frmMain.Desk;
        }

        private bool isValidated()
        {
            ep.Clear();
            if (lstDoc.SelectedIndex < 0)
                ep.SetError(btnView, "Please select a document type");
            else if (lstPK.SelectedIndex < 0)
                ep.SetError(btnView, "Please select an Index number to view the document");
            else
                return true;
            return false;
        }

        private void lstDoc_Click(object sender, EventArgs e)
        {
            string tbl=null, fld=null,prfix=null;
            switch (lstDoc.SelectedIndex)
            {
                case 0:
                    tbl="GON Header";
                    fld="GONID";
                    prfix = "GON";
                    break;
                case 1:
                    tbl="SRN Header";
                    fld="SRNID";
                    prfix = "SRN";
                    break;
                case 2:
                    tbl="GRNHeader";
                    fld="GRNID";
                    prfix = "GRN";
                    break;
                case 3:
                    tbl="Sales";
                    fld="ID";
                    prfix = "SL";
                    break;
                case 4:
                    tbl="Orders";
                    fld="ID";
                    prfix = "OR";
                    break;
            }
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT [" + fld + "] FROM [" + tbl + "]", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                lstPK.Items.Clear();
                while (rd.Read())
                    lstPK.Items.Add(prfix + rd.GetValue(0).ToString().PadLeft(6, '0'));
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            viewTheShit();
                
        }
        private void viewTheShit()
        {
            if (!isValidated())
                return;
            string rpt = null;
            switch (lstDoc.SelectedIndex)
            {
                case 0:
                    rpt = "GON";
                    break;
                case 1:
                    rpt = "SRN";
                    break;
                case 2:
                    rpt = "GRN";
                    break;
                case 3:
                    rpt = "Sales Invoice";
                    break;
                case 4:
                    rpt = "Order Invoice";
                    break;
            }
            frmReportViewer r = new frmReportViewer(rpt, Convert.ToInt32(lstPK.SelectedItem.ToString().Remove(0, 3)));
            r.Show();
        }

        private void btlCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstPK_DoubleClick(object sender, EventArgs e)
        {
            if (lstPK.SelectedIndex >= 0)
                viewTheShit();
        }
    }
}