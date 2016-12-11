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
    public partial class frmBranches : Form
    {
        private Rectangle dragRect;
        public frmBranches()
        {
            this.MdiParent = frmMain.Desk;
            InitializeComponent();
            arrowDown.Visible = false;
        }

        private void frmBranches_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT MAX([ID])+1 FROM Branches", frmMain.con);
                lblId.Text = cmd.ExecuteScalar().ToString();
                lblNoOfRc.Text = "";
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add" && isValidated())
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Branches VALUES(@p1,@p2,@p3,@p4,@p5)", frmMain.con);
                    cmd.Parameters.AddWithValue("@p1", lblId.Text);
                    cmd.Parameters.AddWithValue("@p2", txtBrNm.Text);
                    cmd.Parameters.AddWithValue("@p3", txtAddr.Text);
                    cmd.Parameters.AddWithValue("@p4", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@p5", txtMgr.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Branch Added", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    cmd = new OleDbCommand("SELECT MAX([ID])+1 FROM Branches", frmMain.con);
                    lblId.Text = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex) { dataManipulate.showError(ex); }

            }
            else if (btnAdd.Text == "Update" && isValidated())
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE Branches SET Name='"+txtBrNm.Text+"',Address='"+txtAddr.Text+"',phone='"+txtPhone.Text+"',head='"+txtMgr.Text+"' WHERE [ID]="+lblId.Text, frmMain.con);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Update Success", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSearch_Click(sender, e);
                        btnClear_Click(sender, e);
                    }

                    else
                        MessageBox.Show("Update Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }
        }

        private bool isValidated()
        {
            ep.Clear();
            char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if (txtBrNm.Text.Length < 3)
                ep.SetError(txtBrNm, "Branch Name cannot be less than 3 charactors");
            else if (txtBrNm.Text.IndexOfAny(num) != -1)
                ep.SetError(txtBrNm, "Branch name cannot contain any numbers");
            else if (txtAddr.Text.Length < 10)
                ep.SetError(txtAddr, "Address should have at least 10 characters");
            else if (txtPhone.Text.Length < 10)
                ep.SetError(txtPhone, "Invalid phone number");
            else if (txtMgr.Text.Length < 3)
                ep.SetError(txtMgr, "Manager name should be at least 3 characters");
            else if (txtMgr.Text.IndexOfAny(num)!=-1)
                ep.SetError(txtMgr, "Manager name cannot contain any numbers");
            else
                return true;
            return false;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control b in grpBr.Controls)
            {
                if (b.GetType() == typeof(TextBox)||b.GetType()==typeof(MaskedTextBox))
                    b.Text = "";
            }
            btnAdd.Text = "Add";
            frmBranches_Load(sender, e);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter ad;
            ep.Clear();
            if (txtSearchString.Text == "")
            {
                ep.SetError(txtSearchString, "Search string cannot be empty");
                return;
            }

            if(rbBranchCode.Checked)
                ad=new OleDbDataAdapter("SELECT * FROM Branches WHERE [id] LIKE '"+txtSearchString.Text+"'", frmMain.con);
            else
                ad = new OleDbDataAdapter("SELECT * FROM Branches WHERE [name] LIKE '" + txtSearchString.Text+"'", frmMain.con);

            DataSet ds = new DataSet();
            ad.Fill(ds, "Branches");
            grdSearch.DataSource = ds;
            grdSearch.DataMember = "Branches";

            if (grdSearch.Rows.Count <= 0)
            {
                lblNoOfRc.Text = "No Branches were found";
                lblNoOfRc.Visible = true;
            }
            else if (grdSearch.Rows.Count > 0)
            {
                lblNoOfRc.Text = grdSearch.Rows.Count.ToString() + " Branches(s) found";
                lblNoOfRc.Visible = true;
            }
        }

        private void grdSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Text = "Update";
            lblId.Text = grdSearch.SelectedCells[0].EditedFormattedValue.ToString();
            txtBrNm.Text = grdSearch.SelectedCells[1].EditedFormattedValue.ToString();
            txtAddr.Text = grdSearch.SelectedCells[2].EditedFormattedValue.ToString();
            txtPhone.Text = grdSearch.SelectedCells[3].EditedFormattedValue.ToString();
            txtMgr.Text = grdSearch.SelectedCells[4].EditedFormattedValue.ToString();
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
            dataManipulate.delete("branches", "ID", grdSearch);
            btnSearch_Click(sender, e);
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtSearchString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, new EventArgs());
            }
        }
    }
}