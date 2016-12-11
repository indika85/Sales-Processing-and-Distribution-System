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
    public partial class frmLogIn : Form
    {
        public static welcomeScreen wc;
        int count = 4;
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            try
            {
                if (frmMain.con.State.ToString().Equals("Closed")) frmMain.con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT name FROM branches WHERE [id]=(SELECT [branch code] FROM [volatile env])", frmMain.con);
                frmMain.Desk.Text += " - " + cmd.ExecuteScalar().ToString() + " Branch";
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void log(string id)
        {
            try
            {
                OleDbCommand cmdLog = new OleDbCommand("INSERT INTO UserLogin_Log ([UserId],[InDate],[InTime]) VALUES(@uid,@dt,@tm)", frmMain.con);
                cmdLog.Parameters.AddWithValue("@uid", id);
                cmdLog.Parameters.AddWithValue("@dt", DateTime.Now.ToShortDateString());
                cmdLog.Parameters.AddWithValue("@tm", DateTime.Now.ToShortTimeString());
                cmdLog.ExecuteNonQuery();  
            }
            catch (Exception ex) { dataManipulate.showError(ex); }

        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(sender, e);
            }

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPwd.Focus();
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {


                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Users WHERE Userid=@nm", frmMain.con);
                cmd.Parameters.AddWithValue("@nm", txtName.Text);
                OleDbDataReader rd = cmd.ExecuteReader();

                rd.Read();
                if (rd.HasRows && rd.GetString(2).Trim() == txtPwd.Text.GetHashCode().ToString())
                {
                    if (rd.GetBoolean(6).ToString() == "True")
                    {
                        MessageBox.Show("Your account has been restricted\nPlease contact the administrator", "InsureIt Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtName.Text = "";
                        txtPwd.Text = "";
                        txtName.Focus();
                        return;
                    }

                    frmMain.Desk.LoginStatusView.Text = "Logged in " + rd.GetString(5) + " As " + rd.GetString(3);
                    if (rd.GetString(3).Trim() == "Admin") frmMain.isAdmin = true;
                    log(rd.GetInt32(0).ToString());
                    frmMain.Desk.Enabled = true;
                    wc = new welcomeScreen();
                    wc.Show();
                    frmMain.username = rd.GetString(5);
                    wc.lblWelcome.Text = "Welcome " + rd.GetString(5);

                    if (frmMain.isAdmin)
                        frmMain.Desk.mnuAdmin.Visible = true;
                    else
                    {
                        frmMain.Desk.mnuUsr.Visible = true;
                        frmMain.Desk.gONToolStripMenuItem.Visible = false;
                    }


                    this.Close();
                }
                else
                {
                    count--;
                    if (count > 0)
                    {
                        MessageBox.Show("Failed to login, Please check your Username or Password\n\nTimes to retry " + count, "InsureIt Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Login retry count has expired\nPlease contact your administrator", "InsureIt Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                rd.Close();
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogIn_Shown(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT [name] FROM branches", frmMain.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    frmMain.Desk.cmbBranch.Items.Add(rd.GetString(0));

                cmd = new OleDbCommand("SELECT [branch code] FROM [volatile env]", frmMain.con);
                frmMain.branchcode = cmd.ExecuteScalar().ToString();

                cmd = new OleDbCommand("SELECT [name] FROM branches WHERE [id]= " + frmMain.branchcode, frmMain.con);
                frmMain.Desk.cmbBranch.SelectedIndex = frmMain.Desk.cmbBranch.Items.IndexOf(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }
    }
}