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
    public partial class SalesReturn : Form
    {
        private Rectangle dragRect;
        char[] ch = new char[9];
        public SalesReturn(string type)
        {
            InitializeComponent();
            if (type == "O")
            {
                tabControl1.SelectedIndex = 1;
                Text += "[Orders]";
            }
            arrowDown.Visible = false;
            arrowDownOr.Visible = false;
            for (int i = 1; i <= 9; i++)
                ch[i - 1] = Convert.ToChar(i.ToString());
        }

        private void SalesReturn_Load(object sender, EventArgs e)
        {
            
            OleDbCommand com=new OleDbCommand("SELECT ID FROM Sales",frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                cbInvNo.Items.Add("SL" + rd.GetValue(0).ToString().PadLeft(6, '0'));
            }
            rd.Close();
            onLoadOr();
        }
        int index = 0;
        bool sho = true;

        #region salesReturn
        private void cbInvNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!sho) return;
            if (grdSearch.Rows.Count > 0)
            {
                if (sho)
                {
                    if (MessageBox.Show("Changing the Invoice no will clear all the Data from the Data grid.\nDo you want to continue ?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        sho = false;
                        cbInvNo.SelectedIndex = index;
                        sho = true;
                        return;
                    }

                    else
                    {
                        clearGrid();
                    }
                }
            }

            index = cbInvNo.SelectedIndex;
            listBox1.Items.Clear();
            lblProdID.Text = "";
            lblProdName.Text = "";
            lblPrice.Text = "";
            lblQty.Text = "";
            string invNo = cbInvNo.SelectedItem.ToString();
            OleDbCommand com = new OleDbCommand("SELECT Product FROM [Sales Details] WHERE Sale=@sale", frmMain.con);
            com.Parameters.AddWithValue("@sale", invNo.Substring(invNo.IndexOfAny(ch), invNo.Length - (invNo.IndexOfAny(ch))));
            OleDbDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                OleDbCommand com1 = new OleDbCommand("SELECT Name FROM Products WHERE ID=" + rd.GetInt32(0), frmMain.con);
                OleDbDataReader rd1 = com1.ExecuteReader();
                rd1.Read();
                listBox1.Items.Add("P" + rd.GetValue(0).ToString().PadLeft(4, '0')+"-  "+rd1.GetValue(0).ToString());
                rd1.Close();
            }
            rd.Close();

            OleDbCommand com2 = new OleDbCommand("SELECT * FROM [Sales] WHERE ID= " + invNo.Substring(invNo.IndexOfAny(ch), invNo.Length - (invNo.IndexOfAny(ch))), frmMain.con);
            OleDbDataReader rd2 = com2.ExecuteReader();
            rd2.Read();
            lblPDate.Text = rd2.GetValue(1).ToString();
            lblDiscount.Text = rd2.GetValue(5).ToString();
            
            lblTotAmt.Text = rd2.GetValue(4).ToString();
            int salePerID = rd2.GetInt32(2);
            OleDbCommand salePer = new OleDbCommand("SELECT UserName FROM Users WHERE [ID] = " + salePerID, frmMain.con);
            OleDbDataReader saRD = salePer.ExecuteReader();
            saRD.Read();
            lblSalesPerson.Text = saRD.GetValue(0).ToString();
            saRD.Close();
            lblInvNo.Text = cbInvNo.SelectedItem.ToString();
            rd2.Close();
        }
        private void clearGrid()
        {
            grdSearch.ClearSelection();
            for (int i = grdSearch.Rows.Count - 1; i >= 0; i--)
                grdSearch.Rows.RemoveAt(i);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            addToDataGrid();

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0)
                return;
            int id =Convert.ToInt32(listBox1.SelectedItem.ToString().Substring(1,4));
            int invId = Convert.ToInt32(lblInvNo.Text.Substring(2, 6));
            OleDbCommand com = new OleDbCommand("SELECT Name, price FROM Products WHERE ID=" + id, frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            rd.Read();
            lblProdID.Text = "P"+id.ToString().PadLeft(4, '0');
            lblProdName.Text = rd.GetValue(0).ToString();
            lblPrice.Text = rd.GetValue(1).ToString();
            rd.Close();
            OleDbCommand com1 = new OleDbCommand("SELECT Quantity FROM [Sales Details] WHERE Sale=" + invId+" AND Product="+id, frmMain.con);
            OleDbDataReader rd1 = com1.ExecuteReader();
            rd1.Read();
            lblQty.Text = rd1.GetValue(0).ToString();
            rd1.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToDataGrid();
        }

        private void addToDataGrid()
        {
            ep.Clear();
            int quantity = 1;
            if (listBox1.SelectedItems.Count <= 0)
                return;
            for (int i = 0; i < grdSearch.Rows.Count; i++)
            {
                if (lblProdID.Text == grdSearch.Rows[i].Cells[0].EditedFormattedValue.ToString())
                {
                    ep.SetError(listBox1, "The product is already added to the list");
                    return;
                }
            }
            if (Convert.ToInt32(lblQty.Text) > 1)
            {
                confirmation cf = new confirmation(Convert.ToInt32(lblQty.Text));
                if (cf.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                else
                    quantity = cf.quantity;
            }
            int id = Convert.ToInt32(listBox1.SelectedItem.ToString().Substring(1, 4));
            OleDbCommand com = new OleDbCommand("SELECT Stock FROM Stocks WHERE Product=" + id, frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            rd.Read();
            int stock = Convert.ToInt32(rd.GetValue(0));
            rd.Close();
            if (quantity > stock)
            {
                MessageBox.Show("There is not enough stock to do a replacement.", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            grdSearch.Rows.Add();
            grdSearch.Rows[grdSearch.Rows.Count - 1].Cells[0].Value = lblProdID.Text;
            grdSearch.Rows[grdSearch.Rows.Count - 1].Cells[1].Value = lblProdName.Text;
            grdSearch.Rows[grdSearch.Rows.Count - 1].Cells[2].Value = lblPrice.Text;
            grdSearch.Rows[grdSearch.Rows.Count - 1].Cells[3].Value = quantity.ToString();
            int tot = Convert.ToInt32(lblPrice.Text) * quantity;
            grdSearch.Rows[grdSearch.Rows.Count - 1].Cells[4].Value = tot.ToString();
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void grdSearch_MouseDown(object sender, MouseEventArgs e)
        {
            //if (grdSearch.SelectedRows.Count >= 1)
            //{
            //    Size dragSize = SystemInformation.DragSize;
            //    dragRect = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            //}
            //else
            //{
            //    dragRect = Rectangle.Empty;
            //}
        }
        private void ClrInfo()
        {
            foreach(Control c in groupBox4.Controls)
                if(c.GetType()==typeof(Label)&&c.Width>100)
                    c.Text="";
            foreach (Control c in groupBox3.Controls)
                if (c.GetType() == typeof(Label) && c.Width > 100)
                    c.Text = "";
            cbCusOr.Text = "";
            cbInvNo.Text = "";
            cbCusOr.Items.Clear();
            listBox2.Items.Clear();
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
            if (MessageBox.Show("Are you sure you want to remove selected products?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in grdSearch.SelectedRows)
                    grdSearch.Rows.Remove(r);
            }
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                foreach (DataGridViewRow r in grdSearch.Rows)
                {
                    OleDbCommand com = new OleDbCommand("INSERT INTO [Sales Returns] VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", frmMain.con);
                    OleDbCommand getUsrCode = new OleDbCommand("SELECT [ID] FROM users WHERE username='" + frmMain.username + "'", frmMain.con);

                    OleDbCommand prod = new OleDbCommand("UPDATE Stocks SET Stock=Stock-" + Convert.ToInt32(r.Cells[3].EditedFormattedValue.ToString()) + " WHERE Product=" + Convert.ToInt32(r.Cells[0].EditedFormattedValue.ToString().Substring(1, 4)), frmMain.con);

                    com.Parameters.AddWithValue("@p1", Convert.ToInt32(lblInvNo.Text.Substring(2, 6)));
                    com.Parameters.AddWithValue("@p2", DateTime.Now.ToShortDateString());
                    com.Parameters.AddWithValue("@p3", Convert.ToInt32(r.Cells[0].EditedFormattedValue.ToString().Substring(1, 4)));
                    com.Parameters.AddWithValue("@p5", frmMain.branchcode);
                    com.Parameters.AddWithValue("@p4", getUsrCode.ExecuteScalar().ToString());
                    com.Parameters.AddWithValue("@p6", Convert.ToInt32(r.Cells[3].EditedFormattedValue.ToString()));
                    i = com.ExecuteNonQuery();

                    i += prod.ExecuteNonQuery();


                }
                clearGrid();
                if (i == 2)
                    MessageBox.Show("Sales Return sucessfull.", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        Point p = new Point();
        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            p.X = Cursor.Position.X;
            p.Y = Cursor.Position.Y;
            //Text = p.X.ToString() + "  " + p.Y.ToString();
            p = PointToClient(p);
            p.Offset(0,-190);
            //Text += "  -- "+p.X.ToString() + "  " + p.Y.ToString();
            int index = listBox1.IndexFromPoint(p);
            //Text += "  -- "+index.ToString();
            if (index >= 0)
            {
                string prod = listBox1.Items[index].ToString();
                if (prod.Length > 35)
                {
                    toolTip1.SetToolTip(listBox1, prod);
                }
                else
                {
                    toolTip1.SetToolTip(listBox1, "");
                }
            }
            
        }
        #endregion

        #region orderReturn

        private const int INV_NO = 0;
        private const int CUS_ID = 1;
        private const int CUS_NAME = 2;
        private int current = 0;
        
        private void onLoadOr()
        {
            lblXX.Text = "Invoice NO:";
            panelToHide.Enabled = false;
            customerIDToolStripMenuItem.Checked = false;
            customerNameToolStripMenuItem.Checked = false;
            cbInvOr.Items.Clear();
            cbInvOr.Text = "";
            OleDbCommand com = new OleDbCommand("SELECT ID FROM Orders", frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                cbInvOr.Items.Add("OR" + rd.GetValue(0).ToString().PadLeft(6, '0'));
            }
            rd.Close();
            current = INV_NO;
        }

        private void invoiceNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClrInfo();
            onLoadOr();
        }

        private void customerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClrInfo();
            lblXX.Text = "Customer ID:";
            panelToHide.Enabled = true;
            invoiceNOToolStripMenuItem.Checked = false;
            customerNameToolStripMenuItem.Checked = false;
            cbInvOr.Items.Clear();
            cbInvOr.Text = "";
            OleDbCommand com = new OleDbCommand("SELECT ID FROM Customers", frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                cbInvOr.Items.Add("C" + rd.GetValue(0).ToString().PadLeft(4, '0'));
            }
            rd.Close();
            current = CUS_ID;
        }

        private void customerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClrInfo();
            panelToHide.Enabled = true;
            lblXX.Text = "Customer name:";
            invoiceNOToolStripMenuItem.Checked = false;
            customerIDToolStripMenuItem.Checked = false;
            cbInvOr.Items.Clear();
            cbInvOr.Text = "";
            OleDbCommand com = new OleDbCommand("SELECT FirstName,LastName FROM Customers", frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                cbInvOr.Items.Add(rd.GetValue(0).ToString()+" "+rd.GetValue(1).ToString());
            }
            rd.Close();
            current = CUS_NAME;
        }
    

        private void cbInvOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!shoOr) return;
            if (grdSearchOr.Rows.Count > 0)
            {
                if (shoOr)
                {
                    if (MessageBox.Show("Changing the Invoice no will clear all the Data from the Data grid.\nDo you want to continue ?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        shoOr = false;
                        cbCusOr.SelectedIndex = indexOr;
                        shoOr = true;
                        return;
                    }

                    else
                    {
                        clearGridOr();
                    }
                }
            }
            indexOr = cbInvOr.SelectedIndex;
            
            /*check the cuurently selected option from the tool menu */
            cbCusOr.Items.Clear();
            listBox2.Items.Clear();
            if (current == CUS_ID)
            {
                int cusId = Convert.ToInt32(cbInvOr.SelectedItem.ToString().Remove(0, 1));
                OleDbCommand com = new OleDbCommand("SELECT ID FROM Orders WHERE Customer="+cusId, frmMain.con);
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    cbCusOr.Items.Add("OR" + rd.GetValue(0).ToString().PadLeft(6, '0'));
                }
                rd.Close();
            }
            if (current == CUS_NAME)
            {
                try
                {
                    string fname = cbInvOr.SelectedItem.ToString().Substring(0, cbInvOr.SelectedItem.ToString().IndexOf(' '));
                    string lname = cbInvOr.SelectedItem.ToString().Substring(cbInvOr.SelectedItem.ToString().IndexOf(' ')+1, cbInvOr.SelectedItem.ToString().Length - cbInvOr.SelectedItem.ToString().IndexOf(' ')-1);
                    OleDbCommand com1 = new OleDbCommand("SELECT [ID] FROM [Customers] WHERE [FirstName] LIKE '" + fname + "' AND [lastname] LIKE '"+lname+"'" , frmMain.con);
                    OleDbDataReader rd1 = com1.ExecuteReader();
                    rd1.Read();
                    //MessageB ox.Show(rd1.GetValue(0).ToString());
                    
                    int cusId = Convert.ToInt32(rd1.GetValue(0).ToString());
                    rd1.Close();
                    OleDbCommand com = new OleDbCommand("SELECT ID FROM Orders WHERE Customer=" + cusId, frmMain.con);
                    OleDbDataReader rd = com.ExecuteReader();
                    while (rd.Read())
                    {
                        cbCusOr.Items.Add("OR" + rd.GetValue(0).ToString().PadLeft(6, '0'));
                    }
                    rd.Close();
                    }
                    
                     catch (Exception ex) { dataManipulate.showError(ex); }
                    
            }
            if (current == INV_NO)
            {
                setInvoiceLabels(false);
                SetListBoxOr(cbInvOr.SelectedItem.ToString());
                
            }

        }
        int indexOr = 0;
        bool shoOr = true;

        private void SetListBoxOr(string selectedItem)
        {
            listBox2.Items.Clear();
            string invNo = selectedItem;
            
            try
            {
                int id = Convert.ToInt32(invNo.Remove(0, 2));
                OleDbCommand com = new OleDbCommand("SELECT Product FROM [Order Details] WHERE [Order] = " + id, frmMain.con);
                //com.Parameters.AddWithValue("@order", id);
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    OleDbCommand com1 = new OleDbCommand("SELECT Name FROM Products WHERE [ID]= " + Convert.ToInt32(rd.GetValue(0)), frmMain.con);
                    OleDbDataReader rd1 = com1.ExecuteReader();
                    rd1.Read();
                    listBox2.Items.Add("P" + rd.GetValue(0).ToString().PadLeft(4, '0') + "-  " + rd1.GetValue(0).ToString());
                    rd1.Close();
                }
                rd.Close();

                OleDbCommand com2 = new OleDbCommand("SELECT * FROM [Orders] WHERE [ID]= " + invNo.Substring(invNo.IndexOfAny(ch), invNo.Length - (invNo.IndexOfAny(ch))), frmMain.con);
                OleDbDataReader rd2 = com2.ExecuteReader();
                rd2.Read();
                lblPurDateOr.Text = rd2.GetValue(1).ToString();
                lblDisOr.Text = rd2.GetValue(7).ToString();
                lblTotOr.Text = rd2.GetValue(4).ToString();
                lblSalesPerOr.Text = rd2.GetValue(2).ToString();
                lblInvNoOr.Text = "OR"+rd2.GetValue(0).ToString().PadLeft(6,'0');
                rd2.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void cbCusOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!shoOr) return;
            if (grdSearchOr.Rows.Count > 0)
            {
                if (shoOr)
                {
                    if (MessageBox.Show("Changing the Invoice no will clear all the Data from the Data grid.\nDo you want to continue ?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        shoOr = false;
                        cbCusOr.SelectedIndex = indexOr;
                        shoOr = true;
                        return;
                    }

                    else
                    {
                        clearGridOr();
                    }
                }
            }
            indexOr = cbInvOr.SelectedIndex;
            //if (current == INV_NO)
            //{
            setInvoiceLabels(true);
            //    SetListBoxOr(cbCusOr.SelectedItem.ToString());
            //}

            listBox2.Items.Clear();

            lblProdNoOr.Text = "";
            lblProNameOr.Text = "";
            lblPriceOr.Text = "";

            SetListBoxOr(cbCusOr.SelectedItem.ToString());
        }
        private void setInvoiceLabels(bool isSelectedFrom_cbCusOr)
        {
            /*Set the lables of the Invoice details groupbox */
            int InID;
            if(isSelectedFrom_cbCusOr)
            {
                InID = Convert.ToInt32(cbCusOr.SelectedItem.ToString().Remove(0, 2));
                //panelToHide.Enabled = false;
            }
            else
                InID = Convert.ToInt32(cbInvOr.SelectedItem.ToString().Remove(0, 2));
            
            OleDbCommand com = new OleDbCommand("SELECT * FROM [Orders] WHERE [ID]=" + InID, frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            rd.Read();
            lblInvNoOr.Text = "OR" + rd.GetValue(0).ToString().PadLeft(6, '0');
            lblPurDateOr.Text = rd.GetValue(1).ToString();
            lblDisOr.Text = rd.GetValue(7).ToString();
            lblTotOr.Text = rd.GetValue(6).ToString();
            int salesPerID = rd.GetInt32(3);
            OleDbCommand salePer = new OleDbCommand("SELECT UserName FROM Users WHERE [ID] = " + salesPerID, frmMain.con);
            OleDbDataReader saRD = salePer.ExecuteReader();
            saRD.Read();
            lblSalesPerOr.Text = saRD.GetValue(0).ToString();
            saRD.Close();
            rd.Close();
        }
        private void clearGridOr()
        {
            grdSearchOr.ClearSelection();
            for (int i = grdSearchOr.Rows.Count - 1; i >= 0; i--)
                grdSearchOr.Rows.RemoveAt(i);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = "Returns - ";
            if (tabControl1.SelectedIndex == 0)
                Text += "[Sales]";
            else
                Text += "[Orders]";
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count <= 0)
                return;
            int id = Convert.ToInt32(listBox2.SelectedItem.ToString().Substring(1, 4));
            int invId = Convert.ToInt32(lblInvNoOr.Text.Remove(0,2));
            OleDbCommand com = new OleDbCommand("SELECT Name, price FROM Products WHERE ID=" + id, frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            rd.Read();
            lblProdNoOr.Text = "P" + id.ToString().PadLeft(4, '0');
            lblProNameOr.Text = rd.GetValue(0).ToString();
            lblPriceOr.Text = rd.GetValue(1).ToString();
            rd.Close();
            OleDbCommand com1 = new OleDbCommand("SELECT Quantity FROM [Sales Details] WHERE Sale=" + invId + " AND Product=" + id, frmMain.con);
            OleDbDataReader rd1 = com1.ExecuteReader();
            rd1.Read();
            if(rd1.HasRows)
                lblQtyOr.Text = rd1.GetValue(0).ToString();
            rd1.Close();

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            addToGridOr();
        }
        private void addToGridOr()
        {
            ep.Clear();
            int quantity = 1;
            if (listBox2.SelectedItems.Count <= 0)
                return;
            for (int i = 0; i < grdSearchOr.Rows.Count; i++)
            {
                if (lblProdNoOr.Text == grdSearchOr.Rows[i].Cells[0].EditedFormattedValue.ToString())
                {
                    ep.SetError(listBox2, "The product is already added to the list");
                    return;
                }
            }
            if (Convert.ToInt32(lblQtyOr.Text) > 1)
            {
                confirmation cf = new confirmation(Convert.ToInt32(lblQtyOr.Text));
                if (cf.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                else
                    quantity = cf.quantity;
            }
            int id = Convert.ToInt32(listBox2.SelectedItem.ToString().Substring(1, 4));
            OleDbCommand com = new OleDbCommand("SELECT Stock FROM Stocks WHERE Product=" + id, frmMain.con);
            OleDbDataReader rd = com.ExecuteReader();
            rd.Read();
            int stock = Convert.ToInt32(rd.GetValue(0));
            rd.Close();
            if (quantity > stock)
            {
                MessageBox.Show("There is not enough stock to do a replacement.", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            grdSearchOr.Rows.Add();
            grdSearchOr.Rows[grdSearchOr.Rows.Count - 1].Cells[0].Value = lblProdNoOr.Text;
            grdSearchOr.Rows[grdSearchOr.Rows.Count - 1].Cells[1].Value = lblProNameOr.Text;
            grdSearchOr.Rows[grdSearchOr.Rows.Count - 1].Cells[2].Value = lblPriceOr.Text;
            grdSearchOr.Rows[grdSearchOr.Rows.Count - 1].Cells[3].Value = quantity.ToString();
            int tot = Convert.ToInt32(lblPriceOr.Text) * quantity;
            grdSearchOr.Rows[grdSearchOr.Rows.Count - 1].Cells[4].Value = tot.ToString();
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void glassButton4_Click(object sender, EventArgs e)
        {
            addToGridOr();
        }

        private void grdSearchOr_MouseDown(object sender, MouseEventArgs e)
        {
            if (grdSearchOr.SelectedRows.Count >= 1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragRect = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRect = Rectangle.Empty;
            }
        }

        private void grdSearchOr_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragRect != Rectangle.Empty && !dragRect.Contains(e.X, e.Y))
                {
                    arrowDownOr.Enabled = true;
                    arrowDownOr.Visible = true;
                    DragDropEffects dropEffect = grdSearchOr.DoDragDrop(grdSearchOr.SelectedCells[0].EditedFormattedValue.ToString(), DragDropEffects.All);

                }

            }
        }

        private void grdSearchOr_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDownOr.Visible = false;
            dragRect = Rectangle.Empty;
        }

        private void lblTrashOr_DragDrop(object sender, DragEventArgs e)
        {
            arrowDownOr.Visible = false;
            if (MessageBox.Show("Are you sure you want to remove selected products?", "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in grdSearchOr.SelectedRows)
                    grdSearchOr.Rows.Remove(r);
            }
        }

        private void lblTrashOr_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }
        #endregion

        private void btnOrAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                foreach (DataGridViewRow r in grdSearchOr.Rows)
                {
                    OleDbCommand com = new OleDbCommand("INSERT INTO [Order Return] VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", frmMain.con);
                    OleDbCommand getUsrCode = new OleDbCommand("SELECT [ID] FROM users WHERE username='" + frmMain.username + "'", frmMain.con);

                    OleDbCommand prod = new OleDbCommand("UPDATE Stocks SET Stock=Stock-" + Convert.ToInt32(r.Cells[3].EditedFormattedValue.ToString()) + " WHERE Product=" + Convert.ToInt32(r.Cells[0].EditedFormattedValue.ToString().Substring(1, 4)), frmMain.con);

                    com.Parameters.AddWithValue("@p1", Convert.ToInt32(lblInvNoOr.Text.Substring(2, 6)));
                    com.Parameters.AddWithValue("@p2", DateTime.Now.ToShortDateString());
                    com.Parameters.AddWithValue("@p3", Convert.ToInt32(r.Cells[0].EditedFormattedValue.ToString().Substring(1, 4)));
                    com.Parameters.AddWithValue("@p5", frmMain.branchcode);
                    com.Parameters.AddWithValue("@p4", getUsrCode.ExecuteScalar().ToString());
                    com.Parameters.AddWithValue("@p6", Convert.ToInt32(r.Cells[3].EditedFormattedValue.ToString()));
                    
                    i = com.ExecuteNonQuery();
                    i+= prod.ExecuteNonQuery();


                }
                clearGrid();
                if (i == 2)
                    MessageBox.Show("Order Return sucessfull.", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void grdSearch_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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
    }
}