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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM UserLogin_Log", frmMain.con);
            DataSet ds = new DataSet();
            ad.Fill(ds, "UserLogin_Log");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "UserLogin_Log";
        }
    }
}