using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb ;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    public partial class frmRoleMgr : Form
    {
        public static frmRoleMgr rolmgr;
        public frmRoleMgr()
        {
            this.MdiParent = frmMain.Desk;
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isValidated())
                return;
            try
            {
                OleDbCommand cmd;
                if (txtNewUsername.Font.Italic == true && txtNewPassword.Font.Italic == false)
                {
                    cmd = new OleDbCommand("UPDATE Users SET [password]=@lpw,[type]=@rl, [Restricted]=@res WHERE [Username]=@unm", frmMain.con);
                    cmd.Parameters.AddWithValue("@lpw", txtNewPassword.Text);
                }
                else if (txtNewUsername.Font.Italic == false && txtNewPassword.Font.Italic == true)
                {
                    cmd = new OleDbCommand("UPDATE Users SET [Userid]=@lnm,[type]=@rl [Restricted]=@res WHERE [Username]=@unm", frmMain.con);
                    cmd.Parameters.AddWithValue("@lnm", txtNewUsername.Text);
                }
                else if (txtNewUsername.Font.Italic == false && txtNewPassword.Font.Italic == false)
                {
                    cmd = new OleDbCommand("UPDATE Users SET [Userid]=@lnm,[password]=@lpw,[type]=@rl, [Restricted]=@res WHERE Username=@unm", frmMain.con);
                    cmd.Parameters.AddWithValue("@lpw", txtNewPassword.Text);
                    cmd.Parameters.AddWithValue("@lnm", txtNewUsername.Text);
                }
                else
                    cmd = new OleDbCommand("UPDATE Users SET [type]=@rl,[Restricted]=@res WHERE [Username]=@unm", frmMain.con);


                cmd.Parameters.AddWithValue("@unm", cmbUserName.Text);
                cmd.Parameters.AddWithValue("@rl", cmbRole.SelectedItem);
                cmd.Parameters.AddWithValue("@res", chkRestrict.Checked);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Success", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private bool isValidated()
        {
            ep.Clear();
            
            if(!cmbUserName.Items.Contains(cmbUserName.Text))
                ep.SetError(cmbUserName, "Invalid User");
            else if (!cmbRole.Items.Contains(cmbRole.Text))
                ep.SetError(cmbRole, "Invalid User Role");
            else
                return true;

            return false;
        }

        private void frmRoleMgr_Load(object sender, EventArgs e)
        {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT UserName FROM Users", frmMain.con);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                        cmbUserName.Items.Add(rd.GetString(0));

                    rd.Close();
                }
                catch (Exception ex) { dataManipulate.showError(ex); }
  
        }

        private void cmbUserName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT Restrictrd,type FROM Users WHERE username=@p1", frmMain.con);
                cmd.Parameters.AddWithValue("@p1", cmbUserName.SelectedItem.ToString());
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                chkRestrict.Checked = rd.GetBoolean(0);
                cmbRole.SelectedItem = rd.GetString(1);
                ep.Clear();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void txtNewUsername_Enter(object sender, EventArgs e)
        {
            if (txtNewUsername.Font.Italic)
            {
                txtNewUsername.Text = "";
                txtNewUsername.Font=new Font(txtNewUsername.Font,FontStyle.Regular);
                txtNewUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtNewUsername_Leave(object sender, EventArgs e)
        {
            if (txtNewUsername.Text == "")
            {
                txtNewUsername.Text = "[Click to change the username]";
                txtNewUsername.Font=new Font(txtNewUsername.Font,FontStyle.Italic);
                txtNewUsername.ForeColor = Color.Navy;
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Font.Italic)
            {
                txtNewPassword.Text = "";
                txtNewPassword.Font = new Font(txtNewPassword.Font, FontStyle.Regular);
                txtNewPassword.UseSystemPasswordChar = true;
                txtNewPassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.Text = "[Click to change the password]";
                txtNewPassword.Font = new Font(txtNewPassword.Font, FontStyle.Italic);
                txtNewPassword.UseSystemPasswordChar = false;
                txtNewPassword.ForeColor = Color.Navy;
            }
        }

        private void txtPassConfirm_Enter(object sender, EventArgs e)
        {
            if (txtPassConfirm.Font.Italic)
            {
                txtPassConfirm.Text = "";
                txtPassConfirm.Font = new Font(txtPassConfirm.Font, FontStyle.Regular);
                txtPassConfirm.UseSystemPasswordChar = true;
                txtPassConfirm.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPassConfirm_Leave(object sender, EventArgs e)
        {
            if (txtPassConfirm.Text == "")
            {
                txtPassConfirm.Text = "[Click to change the password]";
                txtPassConfirm.Font = new Font(txtPassConfirm.Font, FontStyle.Italic);
                txtPassConfirm.UseSystemPasswordChar = false;
                txtPassConfirm.ForeColor = Color.Navy;
            }
        }
    }
}