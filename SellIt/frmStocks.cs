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
    public partial class frmStocks : Form
    {
        private Rectangle dragRect;
        int currStock,max,rol;
        public frmStocks()
        {
            InitializeComponent();
            arrowDown.Visible = false;
            MdiParent = frmMain.Desk;
            pCode.Checked = true;
            pName.Checked = false;
            lblGen.Visible = false;
        }

        private void frmStocks_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ID FROM products", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                    cmbProd.Items.Add("P" + rd.GetValue(0).ToString().PadLeft(4, '0'));
                cmbProd.SelectedIndex = 0;
                cmd = new OleDbCommand("SELECT MAX(GRNID)+1 FROM grndetails", frmMain.con);
                lblID.Text = "GRN" + cmd.ExecuteScalar().ToString().PadLeft(6, '0');
                rd.Close();
                cmd = new OleDbCommand("SELECT gonid FROM [gon header] WHERE isgrnmade=false", frmMain.con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                    cmbGONID.Items.Add("GON" + rd.GetValue(0).ToString().PadLeft(6, '0'));
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void numStock_Enter(object sender, EventArgs e)
        {
            numStock.Select(0,numStock.Value.ToString().Length);
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT stock,ROL,max FROM stocks WHERE product=@p", frmMain.con);
                cmd.Parameters.AddWithValue("@p", cmbProd.SelectedIndex + 1);
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                rol = rd.GetInt32(1);
                max = rd.GetInt32(2);
                pb.Maximum = rd.GetInt32(2);
                pb.Value = rd.GetInt32(0);

                lblStock.Text = rd.GetInt32(0).ToString() + " / " + rd.GetInt32(2).ToString();
                currStock = rd.GetInt32(0);
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }
        private bool isValidated()
        {
            ep.Clear();
            if (cmbProd.Text == "")
            {
                ep.SetError(cmbProd, "Please select a product");
                return false;
            }
            foreach (DataGridViewRow r in grdGRN.Rows)
                if (r.Cells[0].EditedFormattedValue.ToString() == cmbProd.SelectedItem.ToString() || r.Cells[0].EditedFormattedValue.ToString() == Convert.ToString(cmbProd.SelectedIndex+1))
                {
                    ep.SetError(btnAdd, "Product is Already in the list.");
                    return false;
                }
            try
            {
                cmbProd.SelectedItem.ToString();
            }
             catch (Exception ex) { dataManipulate.showError(ex);return false; }

            if ((numStock.Value + currStock) > max)
                ep.SetError(numStock, "Stocks cannot be added more than maximum allowed");
            else if (numStock.Value == 0)
                ep.SetError(numStock, "Cannot add 0 stock");
            else if ((numStock.Value + currStock) < rol)
            {
                if (MessageBox.Show("New stock is less than re-order level!, Do you want to continue?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
                else
                    ep.SetError(numStock, "New stock should be more than re-order level");
            }
            else
                return true;
            return false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!isValidated())
                return;
            string name = "";
            try
            {
                if (pCode.Checked)
                {
                    char[] ch = new char[9];
                    for (int i = 1; i <= 9; i++)
                        ch[i - 1] = Convert.ToChar(i.ToString());
                    string pId = cmbProd.SelectedItem.ToString();
                    pId = pId.Substring(pId.IndexOfAny(ch), pId.Length - (pId.IndexOfAny(ch)));
                    OleDbCommand cm = new OleDbCommand("SELECT Name FROM Products WHERE ID=" + Convert.ToInt32(pId), frmMain.con);
                    OleDbDataReader r = cm.ExecuteReader();
                    r.Read();
                    name = r.GetString(0);
                    r.Close();
                }
                else
                    name = cmbProd.Text;
                OleDbCommand cmd = new OleDbCommand("SELECT product,name,description,stock FROM products,stocks WHERE products.[id]=stocks.product AND name=@nm", frmMain.con);
                cmd.Parameters.AddWithValue("@nm", name);

                OleDbDataReader rd = cmd.ExecuteReader();

                rd.Read();
                currStock = rd.GetInt32(3);
                grdGRN.Rows.Add();
                grdGRN.Rows[grdGRN.Rows.Count - 1].Cells[0].Value = "P" + rd.GetInt32(0).ToString().PadLeft(4, '0');
                grdGRN.Rows[grdGRN.Rows.Count - 1].Cells[1].Value = rd.GetString(1);
                grdGRN.Rows[grdGRN.Rows.Count - 1].Cells[2].Value = rd.GetString(2);
                grdGRN.Rows[grdGRN.Rows.Count - 1].Cells[3].Value = numStock.Value;
                grdGRN.Rows[grdGRN.Rows.Count - 1].Cells[4].Value = rd.GetInt32(3) + (int)numStock.Value;
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            cmbProd.Text = "";
            numStock.Value = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove selected stock(s)?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in grdGRN.SelectedRows)
                    grdGRN.Rows.Remove(r);
            }
        }

        private void btnGenGrn_Click(object sender, EventArgs e)
        {
            if (!cmbGONID.Items.Contains(cmbGONID.Text))
            {
                ep.SetError(cmbGONID, "Invalid GON Number");
                return;
            }

            try
            {
                    OleDbCommand cmd;
                    //cmd = new OleDbCommand("DELETE FROM grn", frmMain.con);
                    //cmd.ExecuteNonQuery();
                    OleDbCommand cmduser = new OleDbCommand("select id from users where username='" + frmMain.username+"'",frmMain.con);
                    cmd = new OleDbCommand("INSERT INTO grnheader VALUES(@1,@2,@3,@4,@5)", frmMain.con);
                cmd.Parameters.AddWithValue("@1",int.Parse(lblID.Text.Remove(0,3)));
                cmd.Parameters.AddWithValue("@2",int.Parse(cmbGONID.Text.ToString().Remove(0,3)));
                cmd.Parameters.AddWithValue("@3", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@4", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("@5", cmduser.ExecuteScalar());
                cmd.ExecuteNonQuery();

                    int i = 0;
                    foreach (DataGridViewRow r in grdGRN.Rows)
                    {

                        cmd = new OleDbCommand("UPDATE stocks SET [stock]=@px3,[rol]=@px4,[max]=@px5, [branch]=" + frmMain.branchcode + " WHERE [product]=" + int.Parse(grdGRN.Rows[i].Cells[0].EditedFormattedValue.ToString().Remove(0, 1)), frmMain.con);
                        
                        cmd.Parameters.AddWithValue("@px3", grdGRN.Rows[i].Cells[4].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@px4", grdGRN.Rows[i].Cells[5].EditedFormattedValue);
                        cmd.Parameters.AddWithValue("@px5", grdGRN.Rows[i].Cells[6].EditedFormattedValue);
                        cmd.ExecuteNonQuery();
                        
                        cmd = new OleDbCommand("INSERT INTO [grndetails] VALUES(@p1,@p2,@p3)", frmMain.con);
                        cmd.Parameters.AddWithValue("@p1", int.Parse(lblID.Text.Remove(0, 3)));
                        cmd.Parameters.AddWithValue("@p2", grdGRN.Rows[i].Cells[0].EditedFormattedValue.ToString().Remove(0,1));
                        cmd.Parameters.AddWithValue("@p3", grdGRN.Rows[i].Cells[3].EditedFormattedValue);
                        
                        cmd.ExecuteNonQuery();
                        i++;
                    }
                    lblGen.Visible = true;
                    frmReportViewer rp = new frmReportViewer("GRN", int.Parse(lblID.Text.Remove(0, 3)),cmbGONID.SelectedItem.ToString());
                    rp.Show();
                    lblGen.Visible = false;
                    Close();
            }
            catch (Exception ex)
            {
                dataManipulate.showError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdGRN_MouseDown(object sender, MouseEventArgs e)
        {
            if (grdGRN.SelectedRows.Count >= 1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragRect = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRect = Rectangle.Empty;
            }
        }

        private void grdGRN_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragRect != Rectangle.Empty && !dragRect.Contains(e.X, e.Y))
                {
                    arrowDown.Enabled = true;
                    arrowDown.Visible = true;
                    DragDropEffects dropEffect = grdGRN.DoDragDrop(grdGRN.SelectedCells[0].EditedFormattedValue.ToString(), DragDropEffects.All);

                }

            }
        }

        private void grdGRN_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
            dragRect = Rectangle.Empty;
        }

        private void lblTrash_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown.Visible = false;
            if (MessageBox.Show("Are you sure you want to remove selected stock(s)?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in grdGRN.SelectedRows)
                    grdGRN.Rows.Remove(r);
            }
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void pCode_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ID FROM products", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                cmbProd.Items.Clear();
                while (rd.Read())
                    cmbProd.Items.Add("P" + rd.GetValue(0).ToString().PadLeft(4, '0'));
                cmbProd.SelectedIndex = 0;
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            pCode.Checked = true;
            pName.Checked = false;
        }

        private void pName_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT name FROM products", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                cmbProd.Items.Clear();
                while (rd.Read())
                    cmbProd.Items.Add(rd.GetString(0));
                cmbProd.SelectedIndex = 0;
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            pCode.Checked = false;
            pName.Checked = true;
        }

        private void cmbGONID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            ep.Clear();
            grdGRN.Rows.Clear();
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT products.id,products.name,products.description,[gon details].qty,stock+[gon details].qty as [received stock],rol,max from products,[gon details],stocks where stocks.product=products.id and [gon details].productid=products.id and [gon details].gonid=@id", frmMain.con);
                cmd.Parameters.AddWithValue("@id", int.Parse(cmbGONID.Text.Remove(0, 3)));
                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        if (!isItemPresent(rd.GetValue(0).ToString()))
                        {
                            grdGRN.Rows.Add();
                            grdGRN.Rows[grdGRN.Rows.Count - 1].Cells[0].Value = "P" + rd.GetValue(0).ToString().PadLeft(4, '0');
                            for (int i = 1; i < 7; i++)
                                grdGRN.Rows[grdGRN.Rows.Count - 1].Cells[i].Value = rd.GetValue(i);
                        }
                    }
                }
                else
                    ep.SetError(cmbGONID, "No products to display");
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }
        private bool isItemPresent(string k)
        {
            foreach (DataGridViewRow r in grdGRN.Rows)
            {
                if (r.Cells[0].EditedFormattedValue.ToString() == "P" + k.PadLeft(4, '0'))
                    return true;
            }
            return false;
        }

        private void cmbGONID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loadData();
        }

        private void grdGRN_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grdGRN.Enabled = false;
            groupBox1.Enabled = true;
            txtResStocks.Text = grdGRN.SelectedRows[0].Cells[3].EditedFormattedValue.ToString();     
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            grdGRN.Enabled = true;
            txtResStocks.Clear();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            grdGRN.SelectedRows[0].Cells[3].Value = txtResStocks.Text;
            groupBox1.Enabled = false;
            grdGRN.Enabled = true;
            txtResStocks.Clear();
        }
    }
}