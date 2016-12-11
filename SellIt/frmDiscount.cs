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
    public partial class frmDiscount : Form
    {
        public static frmDiscount dis = null;
        private Rectangle dragRect;
        Point p = new Point();
        popupEdit pop;
        public frmDiscount()
        {
            dis = this;
            InitializeComponent();
            pop = new popupEdit();
            pop.MdiParent = frmMain.Desk;
            arrowDown.Visible = false;
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            grdSearch.SelectAll();
            foreach (DataGridViewRow r in grdSearch.SelectedRows)
                grdSearch.Rows.Remove(r);
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblDiscount", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    grdSearch.Rows.Add();
                    for (int i = 0; i < 3; i++)
                        grdSearch.Rows[grdSearch.Rows.Count - 1].Cells[i].Value = rd.GetValue(i).ToString();
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            try
            {
                OleDbCommand com = new OleDbCommand("DELETE * FROM tblDiscount", frmMain.con);
                com.ExecuteNonQuery();
                foreach (DataGridViewRow r in grdSearch.Rows)
                {
                    OleDbCommand cm = new OleDbCommand("INSERT INTO tblDiscount VALUES(@l,@h,@r)", frmMain.con);
                    cm.Parameters.AddWithValue("@l", r.Cells[0].EditedFormattedValue);
                    cm.Parameters.AddWithValue("@h", r.Cells[1].EditedFormattedValue);
                    cm.Parameters.AddWithValue("@r", r.Cells[2].EditedFormattedValue);
                    cm.ExecuteNonQuery();
                    cm.Dispose();
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            frmDiscount_Load(sender, e);
        }

        private bool validate()
        {
            grdSearch.ClearSelection();
            foreach (DataGridViewRow r in grdSearch.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.EditedFormattedValue.ToString() == "")
                    {
                        grdSearch.Rows[r.Index].Selected = true;
                        MessageBox.Show("There were Invalid values", "SellIt", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
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

        private void grdSearch_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
            dragRect = Rectangle.Empty;
        }

        private void lblTrash_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown.Visible = false;
            foreach (DataGridViewRow r in grdSearch.SelectedRows)
                grdSearch.Rows.Remove(r);
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdSearch_MouseClick(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            string val = "";
            if(grdSearch.Rows.Count>0)
                 val = grdSearch.Rows[grdSearch.Rows.Count - 1].Cells[1].EditedFormattedValue.ToString();
            if (val != "")
            {
                grdSearch.Rows.Add();
                if (grdSearch.Rows.Count > 1)
                {
                    grdSearch.Rows[grdSearch.Rows.Count - 1].Cells[0].Value = int.Parse(val) + 1;
                    popupEdit.pop.Visible = true;
                    popupEdit.pop.setValues(grdSearch.Rows[grdSearch.Rows.Count-1].Cells[0].EditedFormattedValue.ToString(), "", "",grdSearch.Rows.Count-1);
                }
            }
        }

        private void grdSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            popupEdit.pop.Visible = true;
            showPopup();
            currentRowIndex = grdSearch.CurrentRow.Index;
            popupEdit.pop.setValues(grdSearch.CurrentRow.Cells[0].EditedFormattedValue.ToString(), grdSearch.CurrentRow.Cells[1].EditedFormattedValue.ToString(), grdSearch.CurrentRow.Cells[2].EditedFormattedValue.ToString(), currentRowIndex);
            selectRow();
        }

        private void frmDiscount_Move(object sender, EventArgs e)
        {
            showPopup();
        }

        private int currentRowIndex = 0;
        private void showPopup()
        {
            if (popupEdit.pop.Visible == false)
                return;
            p.X = Location.X + Width;
            p.Y = Location.Y + 80;
            popupEdit.pop.Location = p;    
        }

        string temp_L="";
        string temp_R="";
        string temp_H="";
        public void setGridValues(string l, string h, string r)
        {
            temp_L = grdSearch.Rows[currentRowIndex].Cells[0].EditedFormattedValue.ToString();
            temp_H = grdSearch.Rows[currentRowIndex].Cells[1].EditedFormattedValue.ToString();
            temp_R = grdSearch.Rows[currentRowIndex].Cells[2].EditedFormattedValue.ToString();

            grdSearch.Rows[currentRowIndex].Cells[0].Value = l;
            grdSearch.Rows[currentRowIndex].Cells[1].Value = h;
            grdSearch.Rows[currentRowIndex].Cells[2].Value = r;
            grdSearch.Rows[currentRowIndex].Selected = true;
            checkGridInterity();
        }
        private void checkGridInterity()
        {
            
            if (currentRowIndex <grdSearch.Rows.Count-1)
            {
                int hbF = int.Parse(grdSearch.Rows[currentRowIndex].Cells[1].EditedFormattedValue.ToString());
                int lbF = int.Parse(grdSearch.Rows[currentRowIndex+1].Cells[0].EditedFormattedValue.ToString());
               if (lbF - hbF <= 0)
                {
                    if (MessageBox.Show("There are some overlapping numbers.\n System will try to automatacally change the bounds Of the regions.\n \nPress cancel to Ignore any change.", "SellIt", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        goUpwords();
                    else
                    {
                        grdSearch.Rows[currentRowIndex].Cells[0].Value = temp_L;
                        grdSearch.Rows[currentRowIndex].Cells[1].Value = temp_H;
                        grdSearch.Rows[currentRowIndex].Cells[2].Value = temp_R;
                    }
                }
                else if (lbF - hbF > 1)
                {
                    if (MessageBox.Show("There are some gaps between discount regions.\n Would you like to automatacally change the bounds Of the discount regions ?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        goUpwords();
                }

            }
            if (currentRowIndex > 0)
            {
                int hbB = int.Parse(grdSearch.Rows[currentRowIndex-1].Cells[1].EditedFormattedValue.ToString());
                int lbB = int.Parse(grdSearch.Rows[currentRowIndex].Cells[0].EditedFormattedValue.ToString());
                if (lbB - hbB <= 0)
                {
                    if (MessageBox.Show("There are some overlapping numbers.\n System will try to automatacally change the bounds Of the regions.\n \nPress cancel to Ignore any change.", "SellIt", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        goDownwards();
                    else
                    {
                        grdSearch.Rows[currentRowIndex].Cells[0].Value = temp_L;
                        grdSearch.Rows[currentRowIndex].Cells[1].Value = temp_H;
                        grdSearch.Rows[currentRowIndex].Cells[2].Value = temp_R;
                    }
                }
                if (lbB - hbB > 1)
                {
                    if (MessageBox.Show("There are some gaps between discount regions.\n Would you like to automatacally change the bounds Of the discount regions ?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        goDownwards();
                }
            }
        }

        private void goUpwords()
        {
            for (int i = currentRowIndex; i < grdSearch.Rows.Count - 1; i++)
            {
                int gap = int.Parse(grdSearch.Rows[i + 1].Cells[1].EditedFormattedValue.ToString()) - int.Parse(grdSearch.Rows[i + 1].Cells[0].EditedFormattedValue.ToString());

                grdSearch.Rows[i + 1].Cells[0].Value = int.Parse(grdSearch.Rows[i].Cells[1].Value.ToString()) + 1;
                grdSearch.Rows[i + 1].Cells[1].Value = int.Parse(grdSearch.Rows[i+1].Cells[0].Value.ToString()) + gap;

            }
        }

        private void goDownwards()
        {
            for (int i = currentRowIndex; i > 0; i--)
            {
                int gap = int.Parse(grdSearch.Rows[i - 1].Cells[1].EditedFormattedValue.ToString()) - int.Parse(grdSearch.Rows[i - 1].Cells[0].EditedFormattedValue.ToString());

                grdSearch.Rows[i - 1].Cells[1].Value = int.Parse(grdSearch.Rows[i].Cells[0].Value.ToString()) - 1;
                grdSearch.Rows[i - 1].Cells[0].Value = int.Parse(grdSearch.Rows[i - 1].Cells[1].Value.ToString()) - gap;
                if (int.Parse(grdSearch.Rows[i - 1].Cells[0].EditedFormattedValue.ToString()) < 0)
                    grdSearch.Rows[i - 1].Cells[0].Value = 0;

            }
        }

        public void selectRow()
        {
            grdSearch.ClearSelection();
            grdSearch.Rows[currentRowIndex].Selected = true;
        }

        private void setPoints(Point px)
        {
            popupEdit.pop.Location = px;
        }

        private void frmDiscount_FormClosing(object sender, FormClosingEventArgs e)
        {
            popupEdit.pop.Close();
        }
    }
}