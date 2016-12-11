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
    public partial class frmPayments : Form
    {
        public frmPayments()
        {
            this.MdiParent = frmMain.Desk;
            InitializeComponent();
            for (int i = 1; i <= 9; i++)
                ch[i - 1] = Convert.ToChar(i.ToString());
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            lblDtTm.Text = DateTime.Now.ToShortDateString();
            cmbCustomer.Items.Clear();
            cmbPID.Items.Clear();
            try
            {
                OleDbCommand com = new OleDbCommand("SELECT [ID] FROM [Payments]WHERE Status=False", frmMain.con);
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                    cmbPID.Items.Add("OR" + rd.GetValue(0).ToString().PadLeft(6, '0'));
                rd.Close();

                cmbCustomer.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("select distinct customer from Payments WHERE Status=False", frmMain.con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                    cmbCustomer.Items.Add("C" + rd.GetValue(0).ToString().PadLeft(4, '0'));
                rd.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            
            foreach(Control c in groupBox1.Controls)
            {
                if(c.GetType()==typeof(TextBox))
                    c.Text="";
     
            }
            numAmount.Value = 0;
            lblTotalAmntToPay.Text = "";
            cmbPID.SelectedIndex = -1;
            frmPayments_Load(sender, e);
            ep.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (!isValidated())
                return;
            try
            {
                OleDbCommand cmd2 = new OleDbCommand("SELECT [ID] FROM USERS WHERE username='" + frmMain.username + "'", frmMain.con);
                string username = cmd2.ExecuteScalar().ToString();
                cmd2.Dispose();
                if (numAmount.Value < Convert.ToDecimal(lblTotalAmntToPay.Text))
                {
                    if (MessageBox.Show("The payment amount is less than the total amount.\n\nDo you want to proceed", "SellIt-Payments", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        decimal newAmount = Convert.ToDecimal(lblTotalAmntToPay.Text) - numAmount.Value;
                        OleDbCommand cmd = new OleDbCommand("Update Payments set [user]=" + username + ",[date]=" + DateTime.Now.ToShortDateString() + ",[amount]=" + newAmount + " WHERE [ID]=" + Convert.ToInt32(customerId), frmMain.con);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("All records were updated suseccfully.", "SellIt-payments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClr_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (numAmount.Value == Convert.ToDecimal(lblTotalAmntToPay.Text))
                {
                    if (MessageBox.Show("Do you want to make the payment ?", "SellIt-Payments", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        decimal newAmount = Convert.ToDecimal(lblTotalAmntToPay.Text) - numAmount.Value;
                        OleDbCommand cmd = new OleDbCommand("Update Payments set [user]=" + username + ",[date]=" + DateTime.Now.ToShortDateString() + ",[amount]=" + newAmount + " ,Status=True WHERE [ID]=" + Convert.ToInt32(customerId), frmMain.con);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("All records were updated suseccfully.", "SellIt-payments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClr_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (numAmount.Value > Convert.ToDecimal(lblTotalAmntToPay.Text))
                {
                    OleDbCommand cmd3 = new OleDbCommand("SELECT Creadit,Balance FROM Customers WHERE ID=" + Convert.ToInt32(customerId), frmMain.con);
                    OleDbDataReader reader = cmd3.ExecuteReader();
                    reader.Read();
                    decimal creditLimit = Convert.ToDecimal(reader.GetValue(0));
                    decimal balance = Convert.ToDecimal(reader.GetValue(1));
                    reader.Close();
                    decimal remaining = numAmount.Value - Convert.ToDecimal(lblTotalAmntToPay.Text);
                    //MessageBox.Show(creditLimit.ToString() + "  " + balance.ToString());
                    if (creditLimit >= balance + remaining)
                    {
                        if (MessageBox.Show("The payment is greater than the total amount.\nDo you want to add the remaining Rs." + remaining.ToString() + " to the credit balance ?", "SellIt-Payments", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            decimal newAmount = Convert.ToDecimal(lblTotalAmntToPay.Text);
                            decimal newBalance = balance + remaining;
                            OleDbCommand cmd = new OleDbCommand("Update Payments set [user]=" + username + ",[date]=" + DateTime.Now.ToShortDateString() + ",[amount]=" + newAmount + " ,Status=True WHERE [ID]=" + Convert.ToInt32(customerId), frmMain.con);
                            OleDbCommand cmd1 = new OleDbCommand("Update Customers set [Balance]=" + newBalance + " WHERE [ID]=" + Convert.ToInt32(customerId), frmMain.con);
                            if (cmd.ExecuteNonQuery() == 1 && cmd1.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("All records were updated suseccfully.", "SellIt-payments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnClr_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("The payment is greater than the total amount.\nDo you want to add the remaining Rs." + remaining.ToString() + " to the credit balance ?", "SellIt-Payments", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            decimal newAmount = Convert.ToDecimal(lblTotalAmntToPay.Text);
                            decimal newBalance = balance + remaining;//newBalance=new credit limit
                            if (MessageBox.Show("The Balance will exceed the current Credit limit !\nDo you want to extend the current credit limit of Rs." + creditLimit.ToString() + " to Rs. " + newBalance.ToString() + " ?", "SellIt-Payments", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                OleDbCommand cmd = new OleDbCommand("Update Payments set [user]=" + username + ",[date]=" + DateTime.Now.ToShortDateString() + ",[amount]=" + newAmount + " ,Status=True WHERE [ID]=" + Convert.ToInt32(customerId), frmMain.con);
                                OleDbCommand cmd1 = new OleDbCommand("Update Customers set [Creadit]=" + newBalance + " ,[Balance]=" + newBalance + " WHERE [ID]=" + Convert.ToInt32(customerId), frmMain.con);
                                if (cmd.ExecuteNonQuery() == 1 && cmd1.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("All records were updated suseccfully.", "SellIt-payments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnClr_Click(sender, e);
                                }
                                else
                                    MessageBox.Show("Failed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
            

        }

        private bool isValidated()
        {
            if (numAmount.Value <= 0)
            {
                ep.SetError(numAmount, "Payment amount cannot be 0"); return false;
            }
            try { cmbPID.SelectedItem.ToString(); }
            catch{
                ep.SetError(cmbPID, "Please select invoice no"); return false;
            }
            return true;
        }

        private void customerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cmbCustomer.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("select distinct customer from payments WHERE Status=False", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    cmbCustomer.Items.Add("C" + rd.GetValue(0).ToString().PadLeft(4, '0'));
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void customerManeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cmbCustomer.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT firstname,lastname FROM customers INNER JOIN payments ON payments.customer=customers.id WHERE payments.Status=False", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    cmbCustomer.Items.Add(rd.GetString(0) + " " + rd.GetString(1));
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        char[] ch = new char[9];//initialized in the constructor
        string customerId = "";
        private void cmbPID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbPID.SelectedIndex == -1)
                return;
            try
            {
                customerId = cmbPID.SelectedItem.ToString();
                customerId = customerId.Substring(customerId.IndexOfAny(ch), customerId.Length - (customerId.IndexOfAny(ch)));
                cmbCustomer.Enabled = false;
                OleDbCommand cmd = new OleDbCommand("select * from payments where [id]=" + Convert.ToInt32(customerId), frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();

                lblDtTm.Text = Convert.ToDateTime(rd.GetValue(1)).ToShortDateString();
                //cmbCustomer.SelectedIndex = rd.GetInt32(3) - 1;
                lblTotalAmntToPay.Text = rd.GetValue(4).ToString();
                //numAmount.Value = Convert.ToDecimal(rd.GetValue(4));
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}