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
    public partial class frmGON : Form
    {
        int rol,max,currentstock;
        private Rectangle dragRect;
        int shift = 0;
        public frmGON()
        {
            MdiParent = frmMain.Desk;
            InitializeComponent();
            arrowDown.Visible = false;
            lblGen.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (!cmbProd.Items.Contains(cmbProd.Text))
            {
                ep.SetError(cmbProd, "Invalid Item");
                return;
            }

            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT Products.ID, Products.Name, Products.Description, Stocks.Stock, Stocks.ROL, Stocks.[Max],products.price FROM (Products INNER JOIN Stocks ON Products.ID = Stocks.Product) WHERE (Products.Name = @nm)", frmMain.con);
                cmd.Parameters.AddWithValue("@nm", cmbProd.Text);
                OleDbDataReader rd = cmd.ExecuteReader();

                rd.Read();
                rol = rd.GetInt32(4);
                max = rd.GetInt32(5);
                currentstock = rd.GetInt32(3);

                if (!isValidated())
                    return;

                grdGON.Rows.Add();
                grdGON.Rows[grdGON.Rows.Count - 1].Cells[0].Value = "P" + rd.GetInt32(0).ToString().PadLeft(4, '0');
                grdGON.Rows[grdGON.Rows.Count - 1].Cells[1].Value = rd.GetString(1);
                grdGON.Rows[grdGON.Rows.Count - 1].Cells[2].Value = rd.GetString(2);
                grdGON.Rows[grdGON.Rows.Count - 1].Cells[3].Value = rd.GetInt32(3).ToString();
                grdGON.Rows[grdGON.Rows.Count - 1].Cells[4].Value = rd.GetInt32(4).ToString();
                grdGON.Rows[grdGON.Rows.Count - 1].Cells[5].Value = rd.GetInt32(5).ToString();
                grdGON.Rows[grdGON.Rows.Count - 1].Cells[6].Value = numOrdQty.Value;
                grdGON.Rows[grdGON.Rows.Count - 1].Cells[7].Value = rd.GetValue(6).ToString();

                label10.Text = Convert.ToString(int.Parse(label10.Text) + (int.Parse(rd.GetValue(6).ToString()) * Convert.ToInt32(numOrdQty.Value)));

            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            
        }

        private bool isValidated()
        {
            ep.Clear();
            foreach (DataGridViewRow r in grdGON.Rows)
                if (r.Cells[1].EditedFormattedValue.ToString() == cmbProd.Text)
                {
                    ep.SetError(btnAdd ,"Product is Already in the list.");
                    return false;
                }
            if (numOrdQty.Value == 0)
                ep.SetError(numOrdQty, "Cannot order 0 products");
            else if (numOrdQty.Value+currentstock < rol)
            {
                if (MessageBox.Show("You are going to order the item less than ROL\nDo you really want to place the order?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
                else
                    ep.SetError(numOrdQty, "Please order product more than ROL");
            }
            else if (numOrdQty.Value+currentstock > max)
                ep.SetError(numOrdQty, "Cannot order more than maximum stock\nthe maximum stock is "+max.ToString());
            else
                return true;
            return false;
        }

        private void frmGON_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT name FROM products", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                    cmbProd.Items.Add(rd.GetString(0));

                cmd = new OleDbCommand("SELECT name from branches where [id]<>" + frmMain.branchcode, frmMain.con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                    cmbBr.Items.Add(rd.GetString(0));
                cmd = new OleDbCommand("SELECT MAX(GONID)+1 FROM [GON Header]", frmMain.con);
                lblGONNo.Text = "GON" + cmd.ExecuteScalar().ToString().PadLeft(6, '0');
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT [max]-stock FROM stocks WHERE product=(SELECT [id] FROM products WHERE name=@p1)", frmMain.con);
            cmd.Parameters.AddWithValue("@p1", cmbProd.Text);
            numOrdQty.Value = Convert.ToDecimal(cmd.ExecuteScalar());
            ep.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (!cmbBr.Items.Contains(cmbBr.Text)&&rbSTN.Checked)
                {
                    ep.SetError(cmbBr, "Invalid branch");
                    return;
                }
                else if (grdGON.Rows.Count < 1)
                {
                    ep.SetError(btnGenerate, "No products to order");
                    return;
                }

                OleDbCommand cmd, cmdbr=null;
                
                OleDbCommand cmduser = new OleDbCommand("SELECT [id] FROM users where username='" + frmMain.username+"'", frmMain.con);
                if (rbGON.Checked)
                { 
                    cmd = new OleDbCommand("INSERT INTO [GON Header] VALUES (@1,@2,@3,@4,@5,false)", frmMain.con);
                    lblGen.Text = "Genarating GON, Please wait...";
                }
                else
                {
                    cmdbr = new OleDbCommand("select [id] from branches where [name]='" + cmbBr.SelectedItem.ToString() + "'", frmMain.con);
                    cmd = new OleDbCommand("INSERT INTO [SRN Header] VALUES (@1,@2,@3,@4,@5,@6)", frmMain.con);

                    lblGen.Text = "Genarating SRN, Please wait...";
                }
                
                cmd.Parameters.AddWithValue("@1", int.Parse(lblGONNo.Text.Remove(0,3)));
                cmd.Parameters.AddWithValue("@2", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@3", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("@4", label10.Text);
                cmd.Parameters.AddWithValue("@5", cmduser.ExecuteScalar());
                if(cmdbr!=null)
                    cmd.Parameters.AddWithValue("@6", cmdbr.ExecuteScalar());
                cmd.ExecuteNonQuery();
                int i = 0;
                foreach (DataGridViewRow r in grdGON.Rows)
                {
                    if (rbGON.Checked)
                    {
                        cmd = new OleDbCommand("INSERT INTO [gon Details] VALUES(@p1,@p2,@p3,@p4,@p5)", frmMain.con);
                    }
                    else
                        cmd = new OleDbCommand("INSERT INTO [srn Details] VALUES(@p1,@p2,@p3,@p4,@p5)", frmMain.con);
                    
                    cmd.Parameters.AddWithValue("@p1", int.Parse(lblGONNo.Text.Remove(0, 3)));
                    cmd.Parameters.AddWithValue("@p2", int.Parse(grdGON.Rows[i].Cells[0].EditedFormattedValue.ToString().Remove(0,1)));
                    cmd.Parameters.AddWithValue("@p3", grdGON.Rows[i].Cells[6].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@p4", grdGON.Rows[i].Cells[7].EditedFormattedValue);
                    cmd.Parameters.AddWithValue("@p5", int.Parse(grdGON.Rows[i].Cells[6].EditedFormattedValue.ToString()) * int.Parse(grdGON.Rows[i].Cells[7].EditedFormattedValue.ToString()));
                    

                    cmd.ExecuteNonQuery();
                    i++;
                }
                lblGen.Visible = true;
                frmReportViewer rp;
                if (rbGON.Checked)
                {
                    rp = new frmReportViewer("GON", int.Parse(lblGONNo.Text.Remove(0, 3)));
                    rp.Show();
                }
                else
                {
                    rp = new frmReportViewer("SRN", int.Parse(lblGONNo.Text.Remove(0, 3)),cmbBr.SelectedItem.ToString());
                    rp.Show();
                }
                lblGen.Visible = false;
                Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            
        }

        private void addProductsBelowReorderLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbCommand cmd = new OleDbCommand("SELECT [id],[name],description,stock,rol,[Max],[max]-stock AS ord, price FROM products, Stocks WHERE stock<ROL AND products.[id]=stocks.product", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (!isItemPresent(rd.GetValue(0).ToString()))
                    {
                        grdGON.Rows.Add();
                        grdGON.Rows[grdGON.Rows.Count - 1].Cells[0].Value = "P" + rd.GetValue(0).ToString().PadLeft(4, '0');
                        for (int i = 1; i < 8; i++)
                            grdGON.Rows[grdGON.Rows.Count - 1].Cells[i].Value = rd.GetValue(i);
                        label10.Text = Convert.ToString(int.Parse(label10.Text) + (int.Parse(rd.GetValue(7).ToString()) * int.Parse(rd.GetValue(6).ToString())));
                    }
                }
                addProductsBelowReorderLevelToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private bool isItemPresent(string k)
        {
            foreach (DataGridViewRow r in grdGON.Rows)
            {
                if (r.Cells[0].EditedFormattedValue.ToString() == "P" + k.PadLeft(4, '0'))
                    return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdGON_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragRect != Rectangle.Empty && !dragRect.Contains(e.X, e.Y))
                {
                    arrowDown.Enabled = true;
                    arrowDown.Visible = true;
                    DragDropEffects dropEffect = grdGON.DoDragDrop(grdGON.SelectedCells[0].EditedFormattedValue.ToString(), DragDropEffects.All);

                }

            }
        }

        private void grdGON_MouseDown(object sender, MouseEventArgs e)
        {
            if (grdGON.SelectedRows.Count >= 1 && shift==0)
            {
                Size dragSize = SystemInformation.DragSize;
                dragRect = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRect = Rectangle.Empty;
            }
        }

        private void grdGON_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
            dragRect = Rectangle.Empty;
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblTrash_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown.Visible = false;
            if (MessageBox.Show("Are you sure you want to remove selected products?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in grdGON.SelectedRows)
                    grdGON.Rows.Remove(r);
            }
        }

        private void rbGON_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = null;
                if (rbGON.Checked)
                {
                    cmd = new OleDbCommand("SELECT MAX(GONID)+1 FROM [GON Header]", frmMain.con);
                    lblGONNo.Text = "GON" + cmd.ExecuteScalar().ToString().PadLeft(6, '0');
                    label8.Enabled = false;
                    label9.Enabled = false;
                    cmbBr.Enabled = false;
                    btnGenerate.Text = "Generate\nGON";
                    Text = "Goods Order Note";
                    label11.Text = "GON No :";
                }
                else
                {
                    cmd = new OleDbCommand("SELECT MAX(SRNID)+1 FROM [SRN Header]", frmMain.con);
                    lblGONNo.Text = "SRN" + cmd.ExecuteScalar().ToString().PadLeft(6, '0');
                    label8.Enabled = true;
                    label9.Enabled = true;
                    cmbBr.Enabled = true;
                    btnGenerate.Text = "Generate\nSRN";
                    Text = "Stock Requesting Note";
                    label11.Text = "SRN No :";
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void grdGON_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                shift = 1;
            
        }

        private void grdGON_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control==false)
                shift = 0;
        }

        private void grdGON_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(grdGON.Rows.Count==0)
                addProductsBelowReorderLevelToolStripMenuItem.Enabled = true;
        }
    }
}