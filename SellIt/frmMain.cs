using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SellIt
{
    public partial class frmMain : Form
    {
        public static OleDbConnection con;
        public static frmMain Desk;
        public static bool isAdmin=false;
        public static string username;
        public static string branchcode,branchname;
        public static Color color;
        public frmMain()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=OPSDB.mdb");
            Desk = this;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log off?", "sellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString ()=="Yes") Application.Restart();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSplash sp = new frmSplash();
            sp.Show();
            
            //DataSet ds = new DataSet();
            //ds.ReadXml("Settings.xml");
            //DataTableReader trd= ds.CreateDataReader();
            //trd.Read();

            //ToolBar.Visible=Convert.ToBoolean(trd.GetString(trd.GetOrdinal("ToolbarVisible")));
            mnuShowToolbar.Checked = ToolBar.Visible;
            //color =Convert.GetTypeCode(rd.GetString(rd.GetOrdinal("ColorScheme"));
            //MessageBox.Show(Convert.GetTypeCode(color));
            
            //trd.Close();
        }

        private void mnuShowToolbar_Click(object sender, EventArgs e)
        {
            if (mnuShowToolbar.Checked == true)
                ToolBar.Visible = true;
            else
                ToolBar.Visible = false;
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserPwChange pw = new frmUserPwChange();
            pw.BackColor = color;
            pw.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer c = new frmCustomer();
            c.BackColor = color;
            c.Show();
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranches fb = new frmBranches();
            fb.BackColor = color;
            fb.Show();
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransaction tr = new frmTransaction("S");
            tr.MdiParent = this;
            tr.BackColor = color;
            tr.Show();
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserPwChange xx = new frmUserPwChange();
            xx.MdiParent = this;
            xx.BackColor = color;
            xx.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts prod = new frmProducts();
            prod.BackColor = color;
            prod.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoleMgr r = new frmRoleMgr();
            //r.BackColor = color;
            r.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                XmlTextWriter x = new XmlTextWriter("Settings.xml", Encoding.UTF8);
                x.WriteStartDocument();
                x.WriteStartElement("SellIt_Settings");
                x.WriteAttributeString("User", frmMain.username);

                x.WriteStartElement("ToolbarVisible");
                x.WriteString(ToolBar.Visible.ToString());
                x.WriteEndElement();

                x.WriteStartElement("ExitReason");
                x.WriteString(e.CloseReason.ToString());
                x.WriteEndElement();

                x.WriteStartElement("ColorScheme");
                x.WriteString(color.ToString());
                x.WriteEndElement();

                x.WriteEndElement();
                x.WriteEndDocument();
                x.Flush();
                x.Close();
                if (frmMain.Desk.LoginStatusView.Text!=".")
                {
                    OleDbCommand com = new OleDbCommand("UPDATE UserLogin_Log set outDate='" + DateTime.Now.ToShortDateString() + "', outtime= '" + DateTime.Now.ToLongTimeString() + "' WHERE EntryNo =(SELECT MAX (EntryNo) FROM UserLogin_Log)", frmMain.con);
                    com.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers u = new frmUsers();
            u.BackColor = color;
            u.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayments p = new frmPayments();
            p.BackColor = color;
            p.Show();
        }

        private void cmbBranch_TextUpdate(object sender, EventArgs e)
        {
            string prev = cmbBranch.Text;

            if (!cmbBranch.Items.Contains(cmbBranch.Text))
            {
                MessageBox.Show("Please select correct branch name", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbBranch.Text = prev;
            }     
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer r = new frmReportViewer("Customers");
            r.Show();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            color = cd.Color;
        }

        private void stocksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStocks s = new frmStocks();
            s.Show();
        }

        private void backupRestoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                if (MessageBox.Show("In order to backup the database, All open windows should be closed\nClose all open windows?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Form childForm in MdiChildren)
                    {
                        childForm.Close();
                    }
                    frmBkup b = new frmBkup();
                    b.BackColor = color;
                    b.Show();
                }
            }
            else
            {
                frmBkup b = new frmBkup();
                b.BackColor = color;
                b.Show();
            }
        }

        private void gONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGON g = new frmGON();
            g.Show();
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptMonthlySales  fr = new frmRptMonthlySales();
            fr.Show();
        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer rp = new frmReportViewer("Today Sales", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());
            rp.Show();
        }

        private void reorderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer rpt = new frmReportViewer("Reorder");
            rpt.Show();
        }

        private void fullStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer  rpt = new frmReportViewer("Full Stock");
            rpt.Show();
        }

        private void stockTransfersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStockTransfer t = new frmStockTransfer();
            t.Show();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransaction tr = new frmTransaction("O");
            tr.MdiParent = this;
            tr.BackColor = color;
            tr.Show();
        }

        private void stockTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptStockTx t = new frmRptStockTx();
            t.Show();
        }

        private void salesReturnsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SalesReturn sr = new SalesReturn("S");
            sr.MdiParent = this;
            sr.Show();
        }

        private void cmbBranch_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT [id] FROM branches WHERE [name]='" + cmbBranch.SelectedItem.ToString() + "'", frmMain.con);
                string bc = cmd.ExecuteScalar().ToString();
                string prev = cmbBranch.Text;
                cmbBranch.Text= cmbBranch.SelectedItem.ToString();
                if (bc != branchcode && MessageBox.Show("To Branch name change take effect, the program shoud be restarted\nDo you want to continue", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new OleDbCommand("UPDATE [volatile env] SET [branch code]='" + bc + "' WHERE [branch code]=" + branchcode, frmMain.con);


                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Branch Updated\nPress OK to restart now", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //branchname = cmbBranch.SelectedItem.ToString();
                        Application.Restart();
                    }
                    else
                        MessageBox.Show("Branch Update Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    cmbBranch.Text = prev;
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void discountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiscount ds = new frmDiscount();
            ds.MdiParent = this;
            ds.Show();
        }

        private void debtorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer r = new frmReportViewer("Debtors");
            r.Show();

        }

        private void monthlyDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptMonthlyOrders or = new frmRptMonthlyOrders();
            or.Show();
        }

        private void customerViceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer r = new frmReportViewer("OrdersCust",1);
            r.Show();
        }

        private void usersLoginReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptUserLog l = new frmRptUserLog();
            l.Show();
        }

        private void DocumentsReprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReprint f = new frmReprint();
            f.Show();
        }

        private void orderReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReturn sr = new SalesReturn("O");
            sr.MdiParent = this;
            sr.Show();
        }

        private void todayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReportViewer r = new frmReportViewer("Payments", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());
            r.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptReturns ret = new frmRptReturns("S");
            ret.MdiParent = this;
            ret.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptReturns ret = new frmRptReturns("O");
            ret.MdiParent = this;
            ret.Show();
        }

        private void todayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportViewer r = new frmReportViewer("Today Orders", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());
            r.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer r = new frmReportViewer("Products");
            r.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
