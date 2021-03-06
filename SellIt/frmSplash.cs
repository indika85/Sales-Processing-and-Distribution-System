using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace SellIt
{
    public partial class frmSplash : Form
    {       
        int fileIndex = 0;
        public FileInfo[] files;
        public frmSplash()
        {
            InitializeComponent();
        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (lblProgress.Width >= Width - 100)
                {
                    timer1.Stop();
                    whenTimerIsStoped();
                }
                Random rd = new Random();
                int i = Convert.ToInt32(rd.Next(0, 10));
                lblProgress.Width += i;
                if (i <= 1)
                {
                    for (int j = 0; j <= Convert.ToInt32(rd.Next(0, 30)); j++)
                    {
                        if (lblProgress.Width >= Width - 100)
                        {
                            timer1.Stop();
                            whenTimerIsStoped();
                            break;
                        }
                        lblProgress.Width += 1;
                        Thread.Sleep(50);
                    }
                }
                if (fileIndex >= files.Length - 1)
                    fileIndex = 0;
                lblFiles.Text = files[fileIndex].FullName;
                fileIndex++;


                this.BringToFront();
                i++;
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }
        private void whenTimerIsStoped()
        {
            lblFiles.Text = "";
            Thread.Sleep(500);
            lblFiles.Text = "Finished loading files.";
            //MessageBox.Show("HJGJHG");
            Thread.Sleep(800);
            connectDB();
            lblFiles.Text = "Connecting to Data base.";
            Thread.Sleep(600);
            //MessageBox.Show("HJGJHG");
            lblFiles.Text = "Initializing user interface";
            Thread.Sleep(100);
            //MessageBox.Show("HJGJHG");
            timer1.Stop();
            this.Hide();
            frmLogIn login = new frmLogIn();
            login.Show();
            timer1.Stop();
            this.Close();
        }
        
        private void frmSplash_Load(object sender, EventArgs e)
        {
            lblProgress.Width = 0;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            files = dir.GetFiles();
        }
        public void connectDB()
        {
            lblFiles.Text = "Connecting to DataBase...";
            try
            {
                if (frmMain.con.State.ToString().Equals("Closed"))
                {
                    frmMain.con.Open();
                }
            }
            catch (Exception ex) { dataManipulate.showError(ex); }
        }

        private void frmSplash_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
            frmLogIn login = new frmLogIn();
            login.Show();
        }
    }
}
                   