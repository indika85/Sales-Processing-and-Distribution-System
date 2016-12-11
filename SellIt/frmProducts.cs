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
    public partial class frmProducts : Form
    {
        private Rectangle dragRect;
        string previd;
        public frmProducts()
        {
            this.MdiParent = frmMain.Desk;
            InitializeComponent();
            arrowDown.Visible = false;
            lblNoOfRc.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isSearchValidated())
            {
                try
                {
                    OleDbDataAdapter ad;

                    if (rbName.Checked)
                        ad = new OleDbDataAdapter("SELECT * FROM products WHERE name LIKE '" + txtSKey.Text + "'", frmMain.con);
                    else
                        ad = new OleDbDataAdapter("SELECT * FROM products WHERE [id] LIKE '" + txtSKey.Text + "'", frmMain.con);

                    DataSet ds = new DataSet();

                    lblNoOfRc.Text = ad.Fill(ds, "products").ToString() + " Product(s) found. \nDouble-Click on a product to edit it";

                    grdSearch.DataSource = ds;
                    grdSearch.DataMember = "products";

                    grdSearch.Columns[2].Width = 200;
                    grdSearch.Columns[1].Width = 150;
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
        }

        private bool isSearchValidated()
        {
            ep.Clear();
            if (txtSKey.Text == "")
                ep.SetError(txtSKey, "Search key cannot be empty\nUse % as the search key if you want to see all products");
            else
                return true;
            return false;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            OleDbCommand cmd= new OleDbCommand("SELECT MAX([ID])+1 FROM products",frmMain.con);
            lblId.Text= cmd.ExecuteScalar().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add" && isValidated())
            {

                groupBox3.Enabled = true;
                OleDbCommand cmd = new OleDbCommand("INSERT INTO products VALUES(@p1,@p2,@p3,@p4)", frmMain.con);
                cmd.Parameters.AddWithValue("@p1", lblId.Text);
                cmd.Parameters.AddWithValue("@p2", txtNm.Text);
                cmd.Parameters.AddWithValue("@p3", txtDesc.Text);
                cmd.Parameters.AddWithValue("@p4", numPrice.Value);

                OleDbCommand cmd2 = new OleDbCommand("INSERT INTO stocks VALUES(@px1,@px2,@px3,@px4,@px5)", frmMain.con);
                cmd2.Parameters.AddWithValue("@px1", frmMain.branchcode);
                cmd2.Parameters.AddWithValue("@px2", lblId.Text);
                cmd2.Parameters.AddWithValue("@px3", numInitStock.Value);
                cmd2.Parameters.AddWithValue("@px4", numROL.Value);
                cmd2.Parameters.AddWithValue("@px5", numMax.Value);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1 && cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Success", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblId.Text = Convert.ToString(int.Parse(lblId.Text) + 1);
                        btnClr_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }

            else if (btnAdd.Text == "Update" && isValidated())
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE products SET name='" + txtNm.Text + "', description='" + txtDesc.Text + "', price=" + numPrice.Value + " WHERE [id]=" + lblId.Text, frmMain.con);
                OleDbCommand cmd2 = new OleDbCommand("update stocks set rol=" + numROL.Value + ", [max]=" + numMax.Value + " where product=" + lblId.Text, frmMain.con);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1&& cmd2.ExecuteNonQuery()==1)
                    {
                        MessageBox.Show("Success", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClr_Click(sender, e);
                        btnSearch_Click(sender, e);
                        btnAdd.Text = "Add";
                    }
                    else
                        MessageBox.Show("Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
        }

        private bool isValidated()
        {
            ep.Clear();
            if (txtNm.Text.Length < 5)
                ep.SetError(txtNm, "Product name cannot less than 5 cahracters");
            else if (txtDesc.Text.Length >= 1 && txtDesc.Text.Length < 5)
                ep.SetError(txtDesc, "Description can be null, \nbut if you typed the description it should be more than 6 characters");
            else if (numPrice.Value == 0)
                ep.SetError(numPrice, "Price cannot be zero");
            else if (numInitStock.Value < 1 && groupBox3.Enabled && btnAdd.Text=="Add")
                ep.SetError(numInitStock, "Invalid initial Stock");
            else if (numROL.Value < 1 && groupBox3.Enabled)
                ep.SetError(numROL, "Invalid ROL");
            else if ((numMax.Value < numInitStock.Value || numMax.Value < 1) && groupBox3.Enabled)
                ep.SetError(numMax, "Invalid Maximum (ROQ) stock");
            else
                return true;

            return false;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c.GetType() == typeof(NumericUpDown))
                    c.Text = "0.00";
                else if (c.GetType() == typeof(TextBox))
                    c.Text = "";
            }
            foreach (Control c in groupBox3.Controls)
            {
                if (c.GetType() == typeof(NumericUpDown))
                    c.Text = "0";
            }

            numInitStock.Enabled = true;

            if (btnAdd.Text == "Update")
            {
                lblId.Text = previd;
                btnAdd.Text = "Add";
            }
        }

        private void grdSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //........................>>>>>>>>>>>>>

            string dick = grdSearch.CurrentCell.EditedFormattedValue.ToString();
            MessageBox.Show(dick);
            //................>>>>>>>>>>>>>>>>>>>>>>>>

            return;
            try
            {
                previd = lblId.Text;
                lblId.Text = grdSearch.CurrentRow.Cells[0].EditedFormattedValue.ToString();
                txtNm.Text = grdSearch.CurrentRow.Cells[1].EditedFormattedValue.ToString();
                txtDesc.Text = grdSearch.CurrentRow.Cells[2].EditedFormattedValue.ToString();
                numPrice.Value = Convert.ToDecimal(grdSearch.CurrentRow.Cells[3].EditedFormattedValue);
                OleDbCommand cmd = new OleDbCommand("SELECT rol,max from stocks where product="+grdSearch.CurrentRow.Cells[0].EditedFormattedValue.ToString(), frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                numROL.Value=(decimal) rd.GetInt32(0);
                numMax.Value = (decimal)rd.GetInt32(1);
                //numInitStock.Value = "";
                btnAdd.Text = "Update";
                //groupBox3.Enabled = false;
                numInitStock.Enabled = false;
                txtNm.Focus();
            }
            catch
            {
                MessageBox.Show("There are no products to edit", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
        private void numPrice_Enter(object sender, EventArgs e)
        {
            numPrice.Select(0, numPrice.Value.ToString().Length);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdSearch_MouseDown(object sender, MouseEventArgs e)
        {
            if (grdSearch.SelectedRows.Count >= 1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragRect = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRect = Rectangle.Empty;
            }
        }

        private void grdSearch_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragRect != Rectangle.Empty && !dragRect.Contains(e.X, e.Y))
                {
                    arrowDown.Enabled = true;
                    arrowDown.Visible = true;
                    DragDropEffects dropEffect = grdSearch.DoDragDrop(grdSearch.SelectedCells[0].EditedFormattedValue.ToString(), DragDropEffects.All);

                }

            }
        }

        private void grdSearch_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
            dragRect = Rectangle.Empty;
        }

        private void lblTrash_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown.Visible = false;
            dataManipulate.deleteFromTwoTables("products","stocks", "ID","product", grdSearch);
            btnSearch_Click(sender, e);
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtSKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, new EventArgs());
        }
       
    }
}