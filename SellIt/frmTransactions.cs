using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using SellIt.Reports;

namespace SellIt
{
    public partial class frmTransaction : Form
    {
        OleDbConnection con;
        OleDbCommand com;
        decimal SalesValue = 0;
        decimal OrderValue = 0;
        int grdSalesRows = 0;
        int grdOrderRows = 0;
        string mode;
        private Rectangle dragRect;
        private Rectangle dragRect1;
        public frmTransaction(string m)
        {
            InitializeComponent();
            arrowDown.Visible = false;
            arrowDown1.Visible = false;
            con = frmMain.con;
            mode = m;
            lblGen.Visible = false;
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = "Date : " + DateTime.Now.ToShortDateString() + "\n \nTime : " + DateTime.Now.ToLongTimeString();
            lblOrTime.Text = "Date : " + DateTime.Now.ToShortDateString() + "\n \nTime : " + DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (mode == "S")
                tb.SelectedIndex = 0;
            else
                tb.SelectedIndex = 1;
            cbProdID.Items.Clear();
            cbOrProdID.Items.Clear();
            lblDiscount.Text = "Discount   0%";
            try
            {
                com = new OleDbCommand("SELECT * FROM Customers", con);
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                    cbCustId.Items.Add("C" + rd.GetValue(0).ToString().PadLeft(4, '0'));
                com = new OleDbCommand("SELECT * FROM Products", con);
                rd = com.ExecuteReader();
                while (rd.Read())
                {
                    cbOrProdID.Items.Add("P" + rd.GetInt32(0).ToString().PadLeft(4, '0'));
                    cbProdID.Items.Add("P" + rd.GetInt32(0).ToString().PadLeft(4, '0'));
                }
                com = new OleDbCommand("SELECT MAX(ID)+1 FROM Sales", con);
                txtTransID.Text = "SL" + com.ExecuteScalar().ToString().PadLeft(6, '0');

                com = new OleDbCommand("SELECT MAX(ID)+1 FROM orders", con);
                txtOrTransID.Text = "OR" + com.ExecuteScalar().ToString().PadLeft(6, '0');
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isSaleAddValidated())
                return;

            com = new OleDbCommand("SELECT Name from Products WHERE [ID]=" + (cbProdID.SelectedIndex+1) , con);

            grdProducts.Rows.Add();
            grdProducts.Rows[grdSalesRows].Cells[0].Value = "P"+Convert.ToString(cbProdID.SelectedIndex+1).PadLeft(4,'0');
            grdProducts.Rows[grdSalesRows].Cells[1].Value = com.ExecuteScalar();
            grdProducts.Rows[grdSalesRows].Cells[2].Value = txtUnitPrice.Text;
            grdProducts.Rows[grdSalesRows].Cells[3].Value = mnQty.Value.ToString();
            grdProducts.Rows[grdSalesRows].Cells[4].Value =Convert.ToString(mnQty.Value*Convert.ToInt32(txtUnitPrice.Text));
            grdSalesRows++;
            SalesValue+=Convert.ToDecimal(mnQty.Value*Convert.ToInt32(txtUnitPrice.Text));
            txtPrice.Text = SalesValue.ToString();
            txtDiscount.Text=Convert.ToString(getDiscountAmount(SalesValue));
            lblDiscount.Text = "Discount   " +Convert.ToInt32(getDiscountRate(SalesValue)*100).ToString() + "%";
            txtTotAmount.Text = Convert.ToString(SalesValue - Convert.ToDecimal(txtDiscount.Text));
        }


        //Gets the discount
        private decimal getDiscountAmount(decimal val)
        {
            return (val * getDiscountRate(val));
        }

        private decimal getDiscountRate(decimal amnt)
        {
            decimal disRate = 0;
            try
            {
                com = new OleDbCommand("SELECT * FROM tblDiscount", con);
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    int lowBound = rd.GetInt32(0);
                    int highBound = rd.GetInt32(1);
                    if (amnt >= lowBound && amnt <= highBound)
                    {
                        disRate = rd.GetInt32(2);
                        break;
                    }

                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); return 0; }
            return disRate/100;
        }

        private void clear()
        {
            cbProdID.Text = "";
            mnQty.Value = 1;
            txtUnitPrice.Text = "";
        }

        private void cbProdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                com = new OleDbCommand("SELECT Price FROM Products WHERE [ID]=@id", con);
                com.Parameters.AddWithValue("@id", (cbProdID.SelectedIndex + 1));
                txtUnitPrice.Text = com.ExecuteScalar().ToString();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValidated(tb.SelectedIndex))
                    return;
                
                OleDbCommand getUsrCode = new OleDbCommand("SELECT [ID] FROM users WHERE username='" + frmMain.username + "'", frmMain.con);
                
                if (tb.SelectedIndex == 0)
                {

                    com = new OleDbCommand("INSERT INTO sales VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", frmMain.con);
                    com.Parameters.AddWithValue("@p1", int.Parse(txtTransID.Text.Remove(0,2)));
                    com.Parameters.AddWithValue("@p2", DateTime.Now.ToShortDateString());
                    com.Parameters.AddWithValue("@p3", getUsrCode.ExecuteScalar().ToString());
                    com.Parameters.AddWithValue("@p4", frmMain.branchcode);
                    com.Parameters.AddWithValue("@p5", txtPrice.Text);
                    com.Parameters.AddWithValue("@p6", txtDiscount.Text);
                    com.Parameters.AddWithValue("@p7", txtTotAmount.Text);

                    if (com.ExecuteNonQuery() == 1)
                    {
                        int i;
                        for (i = 0; i < grdProducts.Rows.Count; i++)
                        {
                            com = new OleDbCommand("INSERT INTO [sales details] VALUES (@p1,@p2,@p3,@p4)", frmMain.con);
                            com.Parameters.AddWithValue("@p1", int.Parse(txtTransID.Text.Remove(0,2)));
                            com.Parameters.AddWithValue("@p2", int.Parse(grdProducts.Rows[i].Cells[0].EditedFormattedValue.ToString().Remove(0,1)));
                            com.Parameters.AddWithValue("@p3", grdProducts.Rows[i].Cells[4].EditedFormattedValue.ToString());
                            com.Parameters.AddWithValue("@p4", grdProducts.Rows[i].Cells[3].EditedFormattedValue.ToString());

                            if (com.ExecuteNonQuery() != 1)
                            {
                                MessageBox.Show("Error!, Please contact administrator\nError Code: Adding item " + grdProducts.Rows[i].Cells[0].EditedFormattedValue.ToString() + " Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                com = new OleDbCommand("DELETE FROM sales WHERE [id]='" + int.Parse(txtTransID.Text.Remove(0,2)) + "'", frmMain.con);
                                com.ExecuteNonQuery();
                                com = new OleDbCommand("DELETE FROM [sales details] WHERE sale='" + int.Parse(txtTransID.Text.Remove(0,2)) + "'", frmMain.con);
                                com.ExecuteNonQuery();
                                return;
                            }
                            else
                            {
                                com = new OleDbCommand("UPDATE stocks SET stock=stock-@p1 WHERE product=@p2", frmMain.con);
                                com.Parameters.AddWithValue("@p1", grdProducts.Rows[i].Cells[3].EditedFormattedValue.ToString());
                                com.Parameters.AddWithValue("@p2", grdProducts.Rows[i].Cells[0].EditedFormattedValue.ToString());
                                com.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show(i.ToString() + " Items added");

                        grdProducts.Rows.Clear();
                        com = new OleDbCommand("SELECT MAX(ID)+1 FROM Sales", con);
                        txtTransID.Text ="SL"+com.ExecuteScalar().ToString().PadLeft(6,'0');

                        com = new OleDbCommand("SELECT MAX(ID)+1 FROM orders", con);
                        txtOrTransID.Text = "OR" + com.ExecuteScalar().ToString().PadLeft(6, '0'); ;

                        SalesValue = 0;
                        OrderValue = 0;
                        grdSalesRows = 0;
                       
                    }
                    generateSalesInv(int.Parse(txtTransID.Text.Remove(0,2))-1);
                    btnClear_Click(sender, e);
                    Form1_Load(sender, e);
                }
                else if (tb.SelectedIndex == 1)
                {
                    com = new OleDbCommand("select balance from customers where [id]=" + (cbCustId.SelectedIndex + 1), frmMain.con);
                    if (Convert.ToDecimal(txtOrTotPrice.Text) > Convert.ToDecimal(com.ExecuteScalar()))
                    {
                        MessageBox.Show("Not enough credit","SellIt",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }

                    com = new OleDbCommand("INSERT INTO orders VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p1)", frmMain.con);
                    com.Parameters.AddWithValue("@p1", int.Parse(txtOrTransID.Text.Remove(0, 2)));
                    com.Parameters.AddWithValue("@p2", DateTime.Now.ToShortDateString());
                    com.Parameters.AddWithValue("@p3", (cbCustId.SelectedIndex + 1));
                    com.Parameters.AddWithValue("@p4", getUsrCode.ExecuteScalar());
                    com.Parameters.AddWithValue("@p5", frmMain.branchcode);
                    com.Parameters.AddWithValue("@p6", dtpOrderDt.Value.ToShortDateString());
                    com.Parameters.AddWithValue("@p7", txtOrPrice.Text);
                    com.Parameters.AddWithValue("@p8", txtOrDiscount.Text);

                    OleDbCommand com2 = new OleDbCommand("insert into Payments values(@p1,@p2,@p3,@p4,@p5,@p6)", frmMain.con);
                    com2.Parameters.AddWithValue("@p1", int.Parse(txtOrTransID.Text.Remove(0, 2)));
                    com2.Parameters.AddWithValue("@p2", DateTime.Now.ToShortDateString());
                    com2.Parameters.AddWithValue("@p3", getUsrCode.ExecuteScalar());
                    com2.Parameters.AddWithValue("@p4", (cbCustId.SelectedIndex + 1));
                    com2.Parameters.AddWithValue("@p5", txtOrTotPrice.Text);
                    com2.Parameters.AddWithValue("@p6", true);

                    OleDbCommand com3 = new OleDbCommand("UPDATE customers SET balance=balance-" + txtOrTotPrice.Text, frmMain.con);

                    if (com.ExecuteNonQuery() == 1)
                    {
                        for (int i = 0; i < grdOrProd.Rows.Count; i++)
                        {
                            com = new OleDbCommand("INSERT INTO [order details] VALUES (@p1,@p2,@p3,@p4)", frmMain.con);
                            com.Parameters.AddWithValue("@p1", int.Parse(txtOrTransID.Text.Remove(0, 2)));
                            com.Parameters.AddWithValue("@p2", int.Parse(grdOrProd.Rows[i].Cells[0].EditedFormattedValue.ToString().Remove(0,2)));
                            com.Parameters.AddWithValue("@p3", grdOrProd.Rows[i].Cells[4].EditedFormattedValue.ToString());
                            com.Parameters.AddWithValue("@p4", grdOrProd.Rows[i].Cells[3].EditedFormattedValue.ToString());
                            com.ExecuteNonQuery();
                            
                            com = new OleDbCommand("UPDATE stocks SET stock=stock-"+grdOrProd.Rows[i].Cells[3].EditedFormattedValue.ToString()+" WHERE product="+int.Parse(grdOrProd.Rows[i].Cells[0].EditedFormattedValue.ToString().Remove(0,1)), frmMain.con);
                            com.ExecuteNonQuery();
                        }

                        com2.ExecuteNonQuery();
                        com3.ExecuteNonQuery();
                    }
                    
                    generateOrderInv(int.Parse(txtOrTransID.Text.Remove(0, 2)));
                    btnClear_Click(sender, e);
                    Form1_Load(sender, e);
                    tb.SelectedIndex = 1;
                    grdOrderRows = 0;
                }

                com = new OleDbCommand("SELECT [name],stock FROM products,stocks WHERE stock<ROL AND products.id=stocks.product", frmMain.con);
                OleDbDataReader rd = com.ExecuteReader();
                frmMain.Desk.toolStripDropDownButton1.DropDownItems.Clear();
                while (rd.Read())
                {
                    frmMain.Desk.toolStripDropDownButton1.DropDownItems.Add(rd.GetString(0) + " (" + rd.GetInt32(1) + ")");
                }
                
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void generateOrderInv(int key)
        {
            lblGen.Visible = true;
            frmReportViewer rep = new frmReportViewer("Order Invoice", key);
            rep.Show();
            lblGen.Visible = false;
        }

        private bool isValidated(int mode)
        {
            ep.Clear();
            if (mode == 1)
            {
                if (grdOrProd.Rows.Count < 1)
                    ep.SetError(btnDone, "No items, Please add at least one item");
                else if (!cbCustId.Items.Contains(cbCustId.Text))
                    ep.SetError(cbCustId, "Invalid Customer");
                else
                    return true;
                return false;
            }
            else
            {
                if (grdProducts.Rows.Count < 1)
                    ep.SetError(btnDone, "No items, Please add at least one item");
                else
                    return true;
                return false;
            }

        }

        private void cbOrProdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                com = new OleDbCommand("SELECT Price FROM Products WHERE [ID]=@id", con);
                com.Parameters.AddWithValue("@id", cbOrProdID.SelectedIndex + 1);
                txtOrUnitPrice.Text = com.ExecuteScalar().ToString();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnAddOrd_Click(object sender, EventArgs e)
        {
            if (!isOrdAddValidated())
                return;

            
            com = new OleDbCommand("SELECT Name from Products WHERE [ID] = " + (cbOrProdID.SelectedIndex+1), con);
            grdOrProd.Rows.Add();
            try
            {
                grdOrProd.Rows[grdOrderRows].Cells[0].Value = "P" + Convert.ToString(cbOrProdID.SelectedIndex + 1).PadLeft(4, '0');
                grdOrProd.Rows[grdOrderRows].Cells[1].Value = com.ExecuteScalar();
                grdOrProd.Rows[grdOrderRows].Cells[2].Value = txtOrUnitPrice.Text;
                grdOrProd.Rows[grdOrderRows].Cells[3].Value = nmOrQty.Value.ToString();
                grdOrProd.Rows[grdOrderRows].Cells[4].Value = Convert.ToString(nmOrQty.Value * Convert.ToInt32(txtOrUnitPrice.Text));
                grdOrderRows++;
            }
            catch (Exception ex) { dataManipulate.showError(ex); }

            OrderValue += Convert.ToDecimal(nmOrQty.Value * Convert.ToInt32(txtOrUnitPrice.Text));
            txtOrPrice.Text = OrderValue.ToString();
            txtOrDiscount.Text = Convert.ToString(getDiscountAmount(OrderValue));
            lblOrDiscount.Text = "Discount   " + Convert.ToInt32(getDiscountRate(OrderValue) * 100).ToString() + "%";
            txtOrTotPrice.Text = Convert.ToString(OrderValue - Convert.ToDecimal(txtOrDiscount.Text));
            nmOrQty.Value = 1;

        }

        private bool isOrdAddValidated()
        {
            ep.Clear();
            foreach (DataGridViewRow r in grdOrProd.Rows)
                if (r.Cells[0].EditedFormattedValue.ToString() == "P" + Convert.ToString(cbOrProdID.SelectedIndex + 1).PadLeft(4, '0'))
                {
                    ep.SetError(btnAddOrd, "Item Already in the list.\nIf you need to change the value, remove it and add again with desired changes");
                    return false;
                }
            try
            {
                com = new OleDbCommand("SELECT stock,rol FROM stocks WHERE product=" + (cbOrProdID.SelectedIndex + 1), frmMain.con);
                OleDbDataReader rd = com.ExecuteReader();
                rd.Read();

                if (!cbOrProdID.Items.Contains(cbOrProdID.Text))
                    ep.SetError(cbOrProdID, "Invalid product");
                else if ((Convert.ToDecimal(rd.GetValue(0)) - nmOrQty.Value) < Convert.ToDecimal(rd.GetValue(1)))
                {
                    if (MessageBox.Show("Adding this quantity makes the available stocks less than re-order level\nDo you want to continue?\n\nNew stock will be " + (Convert.ToDecimal(rd.GetValue(0)) - nmOrQty.Value), "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        return true;
                    else
                        ep.SetError(nmOrQty, "Adding this quantity makes the available stocks less than re-order level\nPlease add lesser quantity");
                }

                else if (Convert.ToDecimal(rd.GetValue(0)) < nmOrQty.Value)
                    ep.SetError(nmOrQty, "Not enough stocks,\nAvailable stocks " + com.ExecuteScalar().ToString());
                else if (nmOrQty.Value < 1)
                    ep.SetError(nmOrQty, "Invalid Quantity");
                else
                    return true;
                rd.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); return false; }
            return false;
        }

        private bool isSaleAddValidated()
        {
            ep.Clear();
            foreach (DataGridViewRow r in grdProducts.Rows)
                if (r.Cells[0].EditedFormattedValue.ToString() == "P"+Convert.ToString(cbProdID.SelectedIndex+1).PadLeft(4,'0'))
                {
                    ep.SetError(btnAdd, "Item Already in the list.\nIf you need to change the value, remove it and add again with desired changes");
                    return false;
                }
            try
            {
                com = new OleDbCommand("SELECT stock,rol FROM stocks WHERE product=" + (cbProdID.SelectedIndex + 1), frmMain.con);
                OleDbDataReader rd = com.ExecuteReader();
                rd.Read();
                if (!cbProdID.Items.Contains(cbProdID.Text))
                    ep.SetError(cbProdID, "Invalid product ID");
                else if ((Convert.ToDecimal(rd.GetValue(0)) - mnQty.Value) < Convert.ToDecimal(rd.GetValue(1)))
                {
                    if (MessageBox.Show("Adding this quantity makes the available stocks less than re-order level\nDo you want to continue?\n\nNew stock will be " + (Convert.ToDecimal(rd.GetValue(0)) - mnQty.Value), "SellIt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        return true;
                    else
                        ep.SetError(mnQty, "Adding this quantity makes the available stocks less than re-order level\nPlease add lesser quantity");
                }
                else if (Convert.ToDecimal(rd.GetValue(0)) < mnQty.Value)
                    ep.SetError(mnQty, "Not enough stocks,\nAvailable stocks " + rd.GetValue(0).ToString());
                else if (mnQty.Value < 1)
                    ep.SetError(mnQty, "Invalid Quantity");
                else
                    return true;
            }
            catch (Exception ex) { dataManipulate.showError(ex); return false; }
            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (tb.SelectedIndex == 0)
            {
                grdProducts.Rows.Clear();
                foreach (Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        if (c.Name != "txtTransID" && c.Name != "txtUnitPrice")
                        {
                            c.Text = "";
                        }
                    }
                }
                grdSalesRows = 0;
            }
            else
            {
                grdOrProd.Rows.Clear();
                foreach (Control c in groupBox2.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        if (c.Name != "txtOrTransID" && c.Name != "txtOrUnitPrice")
                        {
                            c.Text = "";
                        }
                    }
                }
                grdOrderRows = 0;
            }
            
        }

        private void generateSalesInv(int key)
        {
            lblGen.Visible = true;
            frmReportViewer rep = new frmReportViewer("Sales Invoice", key);
            rep.Show();
            lblGen.Visible = false;

        }

        private void customerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbCustId.Items.Clear();
            cbCustId.Text = "";
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT firstname,lastname FROM customers", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    cbCustId.Items.Add(rd.GetValue(0) + " " + rd.GetValue(1));
                rd.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            customerNameToolStripMenuItem.Checked = true;
            customerIDToolStripMenuItem.Checked = false;
        }

        private void customerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbCustId.Items.Clear();
            cbCustId.Text = "";
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT [id] FROM customers", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    cbCustId.Items.Add("C" + rd.GetValue(0).ToString().PadLeft(4, '0'));
                rd.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            customerNameToolStripMenuItem.Checked = false;
            customerIDToolStripMenuItem.Checked = true;
        }

        private void productCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT [id] FROM products", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                if (tb.SelectedIndex == 1)
                {
                    cbOrProdID.Items.Clear();
                    cbOrProdID.Text = "";

                    while (rd.Read())
                        cbOrProdID.Items.Add("P" + rd.GetValue(0).ToString().PadLeft(4, '0'));
                    rd.Close();
                    productNameToolStripMenuItem.Checked = false;
                    productCodeToolStripMenuItem.Checked = true;
                }
                else //if (tb.SelectedIndex == 0)
                {
                    cbProdID.Items.Clear();
                    cbProdID.Text = "";

                    while (rd.Read())
                        cbProdID.Items.Add("P" + rd.GetValue(0).ToString().PadLeft(4, '0'));
                    rd.Close();
                    productNameToolStripMenuItem.Checked = false;
                    productCodeToolStripMenuItem.Checked = true;
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void productNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT name FROM products", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                if (tb.SelectedIndex == 1)
                {
                    cbOrProdID.Items.Clear();
                    cbOrProdID.Text = "";
                    while (rd.Read())
                        cbOrProdID.Items.Add(rd.GetValue(0));
                    rd.Close();
                    productNameToolStripMenuItem.Checked = true;
                    productCodeToolStripMenuItem.Checked = false;
                }
                else
                {
                    cbProdID.Items.Clear();
                    cbProdID.Text = "";
                    while (rd.Read())
                        cbProdID.Items.Add(rd.GetValue(0));
                    rd.Close();
                    productNameToolStripMenuItem.Checked = true;
                    productCodeToolStripMenuItem.Checked = false;
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void grdProducts_MouseDown(object sender, MouseEventArgs e)
        {
            if (grdProducts.SelectedRows.Count >= 1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragRect = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRect = Rectangle.Empty;
            }
        }

        private void grdOrProd_MouseDown(object sender, MouseEventArgs e)
        {
            if (grdOrProd.SelectedRows.Count >= 1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragRect = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRect1 = Rectangle.Empty;
            }
        }

        private void grdProducts_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragRect != Rectangle.Empty && !dragRect.Contains(e.X, e.Y))
                {
                    arrowDown.Enabled = true;
                    arrowDown.Visible = true;
                    DragDropEffects dropEffect = grdProducts.DoDragDrop(grdProducts.SelectedCells[0].EditedFormattedValue.ToString(), DragDropEffects.All);

                }

            }
        }

        private void grdOrProd_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragRect != Rectangle.Empty && !dragRect.Contains(e.X, e.Y))
                {
                    arrowDown1.Enabled = true;
                    arrowDown1.Visible = true;
                    DragDropEffects dropEffect = grdOrProd.DoDragDrop(grdOrProd.SelectedCells[0].EditedFormattedValue.ToString(), DragDropEffects.All);

                }

            }
        }

        private void grdProducts_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown.Visible = false;
            dragRect = Rectangle.Empty;
        }

        private void grdOrProd_MouseUp(object sender, MouseEventArgs e)
        {
            arrowDown1.Visible = false;
            dragRect1 = Rectangle.Empty;
        }

        private void lblTrash_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown.Visible = false;
            if (grdProducts.SelectedRows.Count > 0)
            {
                SalesValue -= Convert.ToDecimal(grdProducts.SelectedCells[4].EditedFormattedValue);
                txtPrice.Text = SalesValue.ToString();
                txtDiscount.Text = Convert.ToString(getDiscountAmount(SalesValue));
                lblDiscount.Text = "Discount   " + Convert.ToInt32(getDiscountRate(SalesValue) * 100).ToString() + "%";
                txtTotAmount.Text = Convert.ToString(SalesValue - Convert.ToDecimal(txtDiscount.Text));
                grdProducts.Rows.RemoveAt(grdProducts.SelectedCells[0].OwningRow.Index);
                if (grdSalesRows > 0)
                    grdSalesRows--;
            }
        }

        private void lblTrash1_DragDrop(object sender, DragEventArgs e)
        {
            arrowDown1.Visible = false;
            if (grdOrProd.SelectedRows.Count > 0)
            {
                OrderValue -= Convert.ToDecimal(grdOrProd.SelectedCells[4].EditedFormattedValue);
                txtOrPrice.Text = OrderValue.ToString();
                txtOrDiscount.Text = Convert.ToString(getDiscountAmount(OrderValue));
                lblOrDiscount.Text = "Discount   " + Convert.ToInt32(getDiscountRate(OrderValue) * 100).ToString() + "%";
                txtOrTotPrice.Text = Convert.ToString(OrderValue - Convert.ToDecimal(txtOrDiscount.Text));
                grdOrProd.Rows.RemoveAt(grdOrProd.SelectedCells[0].OwningRow.Index);

                if (grdSalesRows > 0)
                    grdOrderRows--;
            }
        }

        private void lblTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void lblTrash1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }
    }
}