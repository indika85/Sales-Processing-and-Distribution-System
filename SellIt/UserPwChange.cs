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
    public partial class frmUserPwChange : Form
    {
        public frmUserPwChange()
        {
            InitializeComponent();
            this.MdiParent = frmMain.Desk;
        }

        private void chkUn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUn.Checked == true)
            {
                groupBox1.Enabled = true;
                btnOk.Enabled = true;
            }
            else if(chkUn.Checked == false)
            {
                groupBox1.Enabled = false;
                txtUn.Clear();
            }
            
            if (chkUn.Checked == false && chkPw.Checked == false)
                btnOk.Enabled = false;
            
        }

        private void chkPw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPw.Checked == true)
            {
                groupBox2.Enabled = true;
                btnOk.Enabled = true;
            }
            else if (chkPw.Checked == false)
            {
                groupBox2.Enabled = false;
                txtNewPw.Clear();
                txtConfNewPw.Clear();
            }
            
            if(chkUn.Checked == false&&chkPw.Checked ==false)
                btnOk.Enabled=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUserPwChange_Load(object sender, EventArgs e)
        {
            lblCurrUser.Text += frmMain.username;
        }
        private void betCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int un = 0, pw = 0;
            if (chkUn.Checked == true)
            {
                if (txtUn.Text == "")
                {
                    ep.SetError(txtUn, "");
                    return;
                }
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE Users SET Userid=@uid WHERE UserName=@un", frmMain.con);
                    cmd.Parameters.AddWithValue("@uid", txtUn.Text);
                    cmd.Parameters.AddWithValue("@un", frmMain.username);

                    un = cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }

            if (chkPw.Checked == true)
            {
                
                if (txtConfNewPw.Text.Length < 4 || txtNewPw.Text.Length < 4)
                {
                    ep.SetError(txtConfNewPw, "Passwords should contain at least 4 characters");
                    ep.SetError(txtNewPw, "Passwords should contain at least 4 characters");
                    return;
                }
                if (txtNewPw.Text != txtConfNewPw.Text)
                {
                    ep.SetError(txtConfNewPw, "New password doesn't match with the confirmation password");
                    return;
                }
                else
                {
                    ep.SetError(txtConfNewPw, "");
                    ep.SetError(txtNewPw, "");
                }
                try
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE Users SET [Password]=@pw WHERE [UserName]=@un", frmMain.con);
                    cmd.Parameters.AddWithValue("@pw", txtNewPw.Text.GetHashCode());
                    cmd.Parameters.AddWithValue("@un", frmMain.username);

                    pw = cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
            }

            if (un == 1 && pw == 0)
            {
                MessageBox.Show("Username changed","SellIt",MessageBoxButtons.OK,MessageBoxIcon.Information);
                un = 0;
            }
            else if (un == 0&&pw == 1)
            {
                MessageBox.Show("Password changed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pw = 0;
            }
            else
                MessageBox.Show("Username and password changed", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }
    }
}