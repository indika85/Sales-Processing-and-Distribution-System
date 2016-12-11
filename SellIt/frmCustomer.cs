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
    public partial class frmCustomer : Form
    {
        private Rectangle dragRect;
        public frmCustomer()
        {
            InitializeComponent();
            this.MdiParent = frmMain.Desk;
            arrowDown.Visible = false;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            lblNoOfRc.Text = "";
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT MAX([id])+1 FROM Customers", frmMain.con);
                lblId.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void grdSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblId.Text = grdSearch.CurrentRow.Cells[0].EditedFormattedValue.ToString();
            txtFName.Text = grdSearch.CurrentRow.Cells[1].EditedFormattedValue.ToString();
            txtLName.Text = grdSearch.CurrentRow.Cells[2].EditedFormattedValue.ToString();
            txtCompany.Text = grdSearch.CurrentRow.Cells[4].EditedFormattedValue.ToString();
            txtNIC.Text = grdSearch.CurrentRow.Cells[3].EditedFormattedValue.ToString();
            txtPhone.Text = grdSearch.CurrentRow.Cells[5].EditedFormattedValue.ToString();
            txtMobile.Text = grdSearch.CurrentRow.Cells[6].EditedFormattedValue.ToString();
            txtAddr.Text = grdSearch.CurrentRow.Cells[7].EditedFormattedValue.ToString();
            numCLimit.Value = Convert.ToDecimal(grdSearch.CurrentRow.Cells[8].EditedFormattedValue.ToString());
            numBalance.Value = Convert.ToDecimal(grdSearch.CurrentRow.Cells[9].EditedFormattedValue.ToString());

            btnAdd.Text = "Update";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSearchKey.Text == "")
            {
                ep.SetError(txtSearchKey, "Search key is empty.");
                return;
            }
            try
            {
                OleDbDataAdapter ad = null;
                if (rbCusCode.Checked == true)
                    ad = new OleDbDataAdapter("SELECT * FROM Customers WHERE [ID] LIKE @p0", frmMain.con);
                else if (rbCusName.Checked == true)
                    ad = new OleDbDataAdapter("SELECT * FROM Customers WHERE [FirstName] LIKE @p0", frmMain.con);
                else if (rbCompany.Checked == true)
                    ad = new OleDbDataAdapter("SELECT * FROM Customers WHERE [Company] LIKE @p0", frmMain.con);

                ad.SelectCommand.Parameters.AddWithValue("@p0", txtSearchKey.Text);
                DataSet ds = new DataSet();
                ad.Fill(ds, "Customers");
                grdSearch.DataSource = ds;
                grdSearch.DataMember = "Customers";

                if (grdSearch.Rows.Count <= 0)
                {
                    lblNoOfRc.Text = "No customers found";

                }
                else if (grdSearch.Rows.Count > 0)
                {
                    lblNoOfRc.Text = grdSearch.Rows.Count.ToString() + " Customer(s) found";

                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            foreach (Control b in NewCust.Controls)
            {
                if (b.GetType() == typeof(TextBox) || b.GetType() == typeof(NumericUpDown)||b.GetType() == typeof(MaskedTextBox))
                    b.Text = "";
            }
            btnAdd.Text = "Add";
            txtPhone.Text = "";
            txtMobile.Text = "";
            frmCustomer_Load(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdSearch.Rows.Count>0 && MessageBox.Show("Are you sure you want to delete selected customer(s) ?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    OleDbCommand cmd;
                    int x = 0;
                    for (int i = 0; i < grdSearch.SelectedRows.Count; i++)
                    {
                        cmd = new OleDbCommand("DELETE FROM Customers WHERE [ID]=@id", frmMain.con);
                        cmd.Parameters.AddWithValue("@id", grdSearch.SelectedRows[i].Cells[0].EditedFormattedValue.ToString());
                        x += cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show(x.ToString() + " Customer(s) Deleted", "sellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSearch_Click(sender, e);
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text == "Add" && isValidated() && MessageBox.Show("Add this customer?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Customers(FirstName,LastName,Company,Phone,Mobile,Address,Creadit,Balance,NIC)VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", frmMain.con);
                    cmd.Parameters.AddWithValue("@p1", txtFName.Text);
                    cmd.Parameters.AddWithValue("@p2", txtLName.Text);
                    cmd.Parameters.AddWithValue("@p3", txtCompany.Text);
                    cmd.Parameters.AddWithValue("@p4", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@p5", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@p6", txtAddr.Text);
                    cmd.Parameters.AddWithValue("@p7", numCLimit.Text);
                    cmd.Parameters.AddWithValue("@p8", numBalance.Text);
                    cmd.Parameters.AddWithValue("@p9", txtNIC.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Customer Added", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClr_Click(sender, e);
                        lblId.Text = Convert.ToString(int.Parse(lblId.Text) + 1);
                    }
                }
                else if (btnAdd.Text == "Update" && isValidated() && MessageBox.Show("Are you sure you want to upadte this customer?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE Customers SET FirstName=@p1,LastName=@p2,Company=@p3,Phone=@p4,mobile=@p5,Address=@p6,Creadit=@p7,Balance=@p8,NIC=@p9 WHERE [ID]=@id", frmMain.con);
                    cmd.Parameters.AddWithValue("@p1", txtFName.Text);
                    cmd.Parameters.AddWithValue("@p2", txtLName.Text);
                    cmd.Parameters.AddWithValue("@p3", txtCompany.Text);
                    cmd.Parameters.AddWithValue("@p4", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@p5", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@p6", txtAddr.Text);
                    cmd.Parameters.AddWithValue("@p7", numCLimit.Value);
                    cmd.Parameters.AddWithValue("@p8", numBalance.Value);
                    cmd.Parameters.AddWithValue("@p9", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@id", Convert.ToDecimal(grdSearch.CurrentRow.Cells[0].Value));

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Update Success", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAdd.Text = "Add";
                        btnClr_Click(sender, e);
                        grdSearch.Refresh();
                    }
                    else
                        MessageBox.Show("Update Failed, Try Again", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private bool isValidated()
        {
            ep.Clear();
            char[] numarr={'0','1','2','3','4','5','6','7','8','9'};
            if (txtFName.Text.Length < 3)
                ep.SetError(txtFName, "First Name should contain at least 3 characters");
            else if (txtFName.Text.IndexOfAny(numarr) != -1)
                ep.SetError(txtFName, "First Name should not contain any numeric characters");
            else if (txtLName.Text.Length < 3)
                ep.SetError(txtLName, "Last Name should contain at least 3 characters");
            else if (txtLName.Text.IndexOfAny(numarr) != -1)
                ep.SetError(txtLName, "Last Name should not contain any numeric characters");
            else if (txtPhone.Text.Length < 10)
                ep.SetError(txtPhone, "Phone number should have 10 digits");
            else if (txtMobile.Text.Length < 10)
                ep.SetError(txtMobile, "Mobile number should have 10 digits");
            else if (txtCompany.Text.Length < 3)
                ep.SetError(txtCompany, "Company Name should contain at least 3 characters");
            else if (txtAddr.Text.Length < 10)
                ep.SetError(txtAddr, "Address should contain at least 10 characters");
            else if (!validation.checkNIC(txtNIC.Text))
                ep.SetError(txtNIC, "Invalid NIC No");
            else
                return true;

            return false;
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }

        private void numCLimit_Enter(object sender, EventArgs e)
        {
            numCLimit.Select(0, numCLimit.Value.ToString().Length);
        }

        private void numBalance_Enter(object sender, EventArgs e)
        {
            numBalance.Select(0, numBalance.Value.ToString().Length);
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblTrash_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown.Visible = false;
            dataManipulate.delete("Customers", "ID", grdSearch);
            btnSearch_Click(sender, e);
        }

        private void grdSearch_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
            dragRect = Rectangle.Empty;
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

        private void txtSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, new EventArgs());
        }
    }
}