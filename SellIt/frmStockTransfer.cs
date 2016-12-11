using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SellIt.Reports;

namespace SellIt
{
    public partial class frmStockTransfer : Form
    {
        private Rectangle dragRect;
        OleDbCommand cmd;
        OleDbDataReader rd;
        public frmStockTransfer()
        {
            InitializeComponent();
            arrowDown.Visible = false;
            MdiParent=frmMain.Desk;
            lblGen.Visible = false;
        }

        private void frmStockTransfer_Load(object sender, EventArgs e)
        {
            getNextTxId();
            try
            {
                cmd = new OleDbCommand("SELECT name FROM Branches WHERE [id]<>" + frmMain.branchcode, frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    cbBrabchCode.Items.Add(rd.GetString(0));
                rd.Close();

                cmd = new OleDbCommand("SELECT name FROM Products", frmMain.con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                    cbItemCode.Items.Add(rd.GetValue(0).ToString());
                rd.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            productNameToolStripMenuItem.Checked = true;
        }

        private void getNextTxId()
        {
            cmd = new OleDbCommand("SELECT MAX(txid)+1 FROM [Stock transfers]", frmMain.con);
            lblId.Text = "TX" + cmd.ExecuteScalar().ToString().PadLeft(4, '0');
        }
        //int rows = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isValidated())
                return;
            try
            {
                cmd = new OleDbCommand("SELECT [id],name,price FROM Products WHERE [id]=@id", frmMain.con);
                cmd.Parameters.AddWithValue("@id", cbItemCode.SelectedIndex + 1);
                rd = cmd.ExecuteReader();

                rd.Read();
                grdTx.Rows.Add();
                grdTx.Rows[grdTx.Rows.Count - 1].Cells[0].Value = "P" + rd.GetValue(0).ToString().PadLeft(4, '0');
                grdTx.Rows[grdTx.Rows.Count - 1].Cells[1].Value = rd.GetString(1);
                grdTx.Rows[grdTx.Rows.Count - 1].Cells[2].Value = nmQty.Value.ToString();
                grdTx.Rows[grdTx.Rows.Count - 1].Cells[3].Value = rd.GetDecimal(2) * nmQty.Value;
                //rows++;
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
   
        }

        private bool isValidated()
        {
            ep.Clear();
            foreach (DataGridViewRow r in grdTx.Rows)
                if (r.Cells[1].EditedFormattedValue.ToString() == cbItemCode.Text || r.Cells[0].EditedFormattedValue.ToString() == cbItemCode.Text)
                {
                    ep.SetError(btnAdd, "Product is Already in the list.");
                    return false;
                }
            try
            {
                cmd = new OleDbCommand("SELECT stock,rol,[max] FROM stocks WHERE product=" + (cbItemCode.SelectedIndex + 1), frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();

                if (!cbItemCode.Items.Contains(cbItemCode.Text))
                    ep.SetError(cbItemCode, "Invalid Product code");
                else if (nmQty.Value < 1)
                    ep.SetError(nmQty, "Invalid transfer quantity");
                else if (((decimal)rd.GetInt32(0) < nmQty.Value) && !rbTxIn.Checked)
                    ep.SetError(nmQty, "Tranfer quantity exceeds current available stocks\nAvailable stocks " + rd.GetInt32(0));
                else if ((((int)rd.GetValue(0) - (int)nmQty.Value) < rd.GetInt32(1)) && !rbTxIn.Checked)
                {
                    if (MessageBox.Show("Transferring this quantity will make available stock less than reorder level\nAvailable stock after transfer will be " + ((int)rd.GetValue(0) - (int)nmQty.Value) + "\nDo you want to continue?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        ep.SetError(nmQty, "Transferring this quantity will make available stock less than reorder level");
                }
                else if (((int)rd.GetValue(2) < (rd.GetInt32(0) + (int)nmQty.Value)) && rbTxIn.Checked)
                {
                    MessageBox.Show("Transferring this quantity will make available stock Greater than Max stocks level.\nMax QTY    : "+rd.GetValue(2).ToString()+"\nCurrent stock : "+rd.GetValue(0).ToString(), "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ep.SetError(nmQty, "Transferring this quantity will make available stock Greater than Max stock level");
                }
                else
                    return true;
            }
            catch (Exception ex) { dataManipulate.showError(ex); return false; }
            
            return false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove selected stock(s)?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in grdTx.SelectedRows)
                    grdTx.Rows.Remove(r);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd2=null,cmd3=null;
            ep.Clear();
            if (!cbBrabchCode.Items.Contains(cbBrabchCode.Text))
            {
                ep.SetError(cbBrabchCode, "Invalid branch name");
                return;
            }
            else if (grdTx.Rows.Count < 1)
            {
                ep.SetError(btnTransfer, "Nothing to transfer");
                return;
            }
            //else if(txtsrnid.Enabled=true && tx

            if (rbTxOut.Checked)
            {
                decimal tot = 0;
                int qty = 0;
                try
                {
                    foreach (DataGridViewRow r in grdTx.Rows)
                    {
                        cmd = new OleDbCommand("INSERT INTO [transfer details] VALUES(@p1,@p2,@p3,@p4)", frmMain.con);
                        cmd.Parameters.AddWithValue("@p1", int.Parse(lblId.Text.Remove(0, 2)));
                        cmd.Parameters.AddWithValue("@p2", int.Parse(r.Cells[0].EditedFormattedValue.ToString().Remove(0, 1)));
                        cmd.Parameters.AddWithValue("@p3", r.Cells[2].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@p4", r.Cells[3].EditedFormattedValue);
                        tot += Convert.ToDecimal(r.Cells[3].EditedFormattedValue);
                        qty += Convert.ToInt32(r.Cells[2].EditedFormattedValue);

                        cmd.ExecuteNonQuery();

                        cmd = new OleDbCommand("UPDATE stocks SET stock=stock-@p1 WHERE product=@pr", frmMain.con);
                        cmd.Parameters.AddWithValue("@p1", r.Cells[2].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@pr", int.Parse(r.Cells[0].EditedFormattedValue.ToString().Remove(0, 1)));
                        cmd.ExecuteNonQuery();
                    }

                    cmd = new OleDbCommand("INSERT INTO [stock transfers] VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", frmMain.con);
                    cmd2 = new OleDbCommand("SELECT [ID] FROM USERS WHERE username='" + frmMain.username + "'", frmMain.con);
                    cmd3 = new OleDbCommand("SELECT [ID] FROM branches WHERE name='" + cbBrabchCode.Text + "'", frmMain.con);
                    cmd.Parameters.AddWithValue("@p1", int.Parse(lblId.Text.Remove(0, 2)));
                    cmd.Parameters.AddWithValue("@p2", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@p3", cmd2.ExecuteScalar());
                    cmd.Parameters.AddWithValue("@p4", cmd3.ExecuteScalar());
                    cmd.Parameters.AddWithValue("@p5", qty);
                    cmd.Parameters.AddWithValue("@p6", tot);
                    if(txtsrnid.Text!="")
                         cmd.Parameters.AddWithValue("@p7", txtsrnid.Text);
                    else
                    cmd.Parameters.AddWithValue("@p7", 0);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
            else
            {
                decimal tot = 0;
                int qty = 0;
                try
                {
                    foreach (DataGridViewRow r in grdTx.Rows)
                    {
                        cmd = new OleDbCommand("INSERT INTO [transfer details] VALUES(@p1,@p2,@p3,@p4)", frmMain.con);
                        cmd.Parameters.AddWithValue("@p1", int.Parse(lblId.Text.Remove(0, 2)));
                        cmd.Parameters.AddWithValue("@p2", int.Parse(r.Cells[0].EditedFormattedValue.ToString().Remove(0, 1)));
                        cmd.Parameters.AddWithValue("@p3", "-" + r.Cells[2].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@p4", r.Cells[3].EditedFormattedValue);
                        tot += Convert.ToDecimal(r.Cells[3].EditedFormattedValue);
                        qty += Convert.ToInt32(r.Cells[2].EditedFormattedValue);

                        cmd.ExecuteNonQuery();

                        cmd = new OleDbCommand("UPDATE stocks SET stock=stock+@p1 WHERE product=@pr", frmMain.con);
                        cmd.Parameters.AddWithValue("@p1", r.Cells[2].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@pr", int.Parse(r.Cells[0].EditedFormattedValue.ToString().Remove(0, 1)));
                        cmd.ExecuteNonQuery();
                    }

                    cmd = new OleDbCommand("INSERT INTO [stock transfers] VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", frmMain.con);
                    cmd2 = new OleDbCommand("SELECT [ID] FROM USERS WHERE username='" + frmMain.username + "'", frmMain.con);
                    cmd3 = new OleDbCommand("SELECT [ID] FROM branches WHERE name='" + cbBrabchCode.Text + "'", frmMain.con);
                    cmd.Parameters.AddWithValue("@p1", int.Parse(lblId.Text.Remove(0, 2)));
                    cmd.Parameters.AddWithValue("@p2", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@p3", cmd2.ExecuteScalar());
                    cmd.Parameters.AddWithValue("@p4", cmd3.ExecuteScalar());
                    cmd.Parameters.AddWithValue("@p5", qty);
                    cmd.Parameters.AddWithValue("@p6", tot);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }

            generateTxReport(int.Parse(lblId.Text.Remove(0,2)));
            grdTx.Rows.Clear();
        }

        private void generateTxReport(int txid)
        {
            lblGen.Visible = true;
            OleDbCommand cmd = new OleDbCommand("SELECT name FROM branches WHERE [id]=(SELECT [branch code] FROM [volatile env])", frmMain.con);
            frmReportViewer rr = new frmReportViewer("Stock Transfer", txid,cmd.ExecuteScalar().ToString(),cbBrabchCode.Text);
            rr.Show();
            lblGen.Visible = false;

            
        }

        private void productIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbItemCode.Items.Clear();
            cbItemCode.Text = "";
            try
            {
                cmd = new OleDbCommand("SELECT [id] FROM Products", frmMain.con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                    cbItemCode.Items.Add("P" + rd.GetValue(0).ToString().PadLeft(4, '0'));
                rd.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
                productNameToolStripMenuItem.Checked = false;
                productIDToolStripMenuItem.Checked = true;
        }

        private void productNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbItemCode.Items.Clear();
            cbItemCode.Text = "";
            try
            {
                cmd = new OleDbCommand("SELECT name FROM Products", frmMain.con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                    cbItemCode.Items.Add(rd.GetValue(0).ToString());
                rd.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            productNameToolStripMenuItem.Checked=true;
            productIDToolStripMenuItem.Checked = false;
        }

        private void rbTxIn_Click(object sender, EventArgs e)
        {
            if (grdTx.Rows.Count > 0)
                if (MessageBox.Show("Changing the transfer mode will cause the pending transfers to loose\nAre you sure you want to continue", "sellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    label2.Text = "From";
                    grdTx.Rows.Clear();
                    cbBrabchCode.Text = "";
                    cbItemCode.Text = "";
                    nmQty.Value = 0;
                }
                else
                {
                    label2.Text = "From";
                    rbTxIn.Checked =false;
                    rbTxOut.Checked = true;
                }
        }

        private void rbTxOut_Click(object sender, EventArgs e)
        {
            if (grdTx.Rows.Count > 0)
                if (MessageBox.Show("Changing the transfer mode will cause the pending transfers to loose\nAre you sure you want to continue", "sellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    label2.Text = "To";
                    grdTx.Rows.Clear();
                    cbBrabchCode.Text = "";
                    cbItemCode.Text = "";
                    nmQty.Value = 0;
                }
                else
                {
                    label2.Text = "To";
                    rbTxOut.Checked =false;
                    rbTxIn.Checked = true; ;
                }
        }

        private void grdTx_MouseDown(object sender, MouseEventArgs e)
        {
            if (grdTx.SelectedRows.Count >= 1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragRect = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRect = Rectangle.Empty;
            }
        }

        private void grdTx_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragRect != Rectangle.Empty && !dragRect.Contains(e.X, e.Y))
                {
                    arrowDown.Enabled = true;
                    arrowDown.Visible = true;
                    DragDropEffects dropEffect = grdTx.DoDragDrop(grdTx.SelectedCells[0].EditedFormattedValue.ToString(), DragDropEffects.All);

                }

            }
        }

        private void grdTx_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
            dragRect = Rectangle.Empty;
        }

        private void lblTrash_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown.Visible = false;
            if (MessageBox.Show("Are you sure you want to remove selected stock(s)?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in grdTx.SelectedRows)
                    grdTx.Rows.Remove(r);
            }
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void rbTxIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTxIn.Checked)
            {
                label2.Text = "Transfer From";
                label10.Enabled = false;
                label11.Enabled = false;
                txtsrnid.Enabled = false;
            }
            else
            {
                label2.Text = "Transfer To";
                label10.Enabled = true;
                label11.Enabled = true;
                txtsrnid.Enabled = true;
            }
        }

        private void rbTxOut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}