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
    public partial class frmUsers : Form
    {
        private Rectangle dragRect;
        public frmUsers()
        {
            MdiParent = frmMain.Desk;
            InitializeComponent();
            arrowDown.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isValidated())
                return;
            try
            {
                if (btnAdd.Text == "Add")
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Users VALUES(@p1,@p2,@p3,@p4,@p5,@p6,0)", frmMain.con);
                    cmd.Parameters.AddWithValue("@p1", lblId.Text);
                    cmd.Parameters.AddWithValue("@p2", txtId.Text);
                    cmd.Parameters.AddWithValue("@p3", txtPass.Text.GetHashCode());
                    cmd.Parameters.AddWithValue("@p4", cmbRole.SelectedItem);
                    cmd.Parameters.AddWithValue("@p5", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@p6", txtName.Text + " " + txtLName.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User Added", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClr_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Add Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE Users SET UserName='" + (txtName.Text + " " + txtLName.Text) + "',Description='" + txtDesc.Text + "' WHERE [id]=" + lblId.Text, frmMain.con);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User Updated", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSearch_Click(sender, e);
                        btnAdd.Text = "Add";
                        btnClr_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Update Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }

        }

        private bool isValidated()
        {
            ep.Clear();
            char[] num ={ '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (txtName.Text.Length < 3)
                ep.SetError(txtName, "First Name should contain at least 3 characters");
            else if (txtLName.Text.Length > 1 && txtLName.Text.Length < 3)
                ep.SetError(txtLName, "Last Name can be null,\nBut if you're typing the lastname, it should have more than 3 characters");
            else if (txtName.Text.IndexOfAny(num) > -1)
                ep.SetError(txtName, "Name cannot contain numbers");
            else if (txtLName.Text.IndexOfAny(num) > -1)
                ep.SetError(txtName, "Name cannot contain numbers");
            else if (txtDesc.Text.Length > 0 && txtDesc.Text.Length < 10)
                ep.SetError(txtDesc, "Description can be null,\nBut if you're typing a description, it should have more than 10 characters");
            else if (txtId.Text.Length < 3 && grpAcc.Enabled ==true)
                ep.SetError(txtId, "User ID should have more than 3 characters");
            else if (txtPass.Text.Length < 5 && grpAcc.Enabled == true)
                ep.SetError(txtPass, "Password length must be more than 5 characters");
            else if (txtPass.Text != txtConfPass.Text && grpAcc.Enabled == true)
                ep.SetError(txtConfPass, "Password does not match with the confirmation password");
            else if (grpAcc.Enabled == true && cmbRole.SelectedIndex<0 )
                ep.SetError(cmbRole, "Please select a user role");
            else
                return true;
            return false;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT MAX([id])+1 FROM users", frmMain.con);
                lblId.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!isSearchValidated())
                return;
            try
            {
                OleDbDataAdapter ad = new OleDbDataAdapter("SELECT [id],username,description FROM users WHERE username LIKE @nm", frmMain.con);
                DataSet ds = new DataSet();
                ad.SelectCommand.Parameters.AddWithValue("@nm", txtSearchKey.Text);
                ad.Fill(ds, "users");

                grdSearch.DataSource = ds;
                grdSearch.DataMember = "users";
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private bool isSearchValidated()
        {
            ep.Clear();
            if (txtSearchKey.Text == string.Empty)
                ep.SetError(txtSearchKey, "Search key cannot be null");
            else
                return true;
            return false;
        }

        private void grdSerarch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                btnAdd.Text = "Update";

                if (grdSearch.SelectedCells[1].EditedFormattedValue.ToString().IndexOf(' ') < 0)
                {
                    txtName.Text = grdSearch.SelectedCells[1].EditedFormattedValue.ToString();
                    txtLName.Text = "";
                }
                else
                {
                    txtName.Text = grdSearch.SelectedCells[1].EditedFormattedValue.ToString().Substring(0, grdSearch.SelectedCells[1].EditedFormattedValue.ToString().IndexOf(' '));
                    txtLName.Text = grdSearch.SelectedCells[1].EditedFormattedValue.ToString().Substring(grdSearch.SelectedCells[1].EditedFormattedValue.ToString().IndexOf(' ') + 1);
                }
                
            
            lblId.Text = grdSearch.SelectedCells[0].EditedFormattedValue.ToString();
            txtDesc.Text = grdSearch.SelectedCells[2].EditedFormattedValue.ToString();
            grpAcc.Enabled = false;
            label10.Visible = true;
            
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
               if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            foreach (Control c in grpAcc.Controls)
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }

            ep.Clear();
            btnAdd.Text = "Add";
            grpAcc.Enabled = true;
            frmUsers_Load(sender, e);
            label10.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you eant to exit?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }

        }

        private void grdSerarch_MouseDown(object sender, MouseEventArgs e)
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

        private void grdSerarch_MouseMove(object sender, MouseEventArgs e)
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

        private void grdSerarch_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
            dragRect = Rectangle.Empty;
        }

        private void lblTrash_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown.Visible = false;
            dataManipulate.delete("Users", "ID", grdSearch);
            btnSearch_Click(sender, e);
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, new EventArgs());
        }

    }
}