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
    public partial class Form1 : Form
    {
        string type;
        public Form1(string t)
        {
            InitializeComponent();
            type = t;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//            OleDbDataAdapter ad;
//            //if(type=="S")
//               ad = new OleDbDataAdapter("SELECT [Sales Details].*, Products.*, Sales.*, Users.*, Branches.*, [Sales Details].Price*[Quantity] AS GrandTotal, 'P' & Mid(Products.ID+100000,2) AS ProductID, 'S' & Mid(Sales.ID+100000,2) AS SaleID, [Total]*[Discount]/100 AS DiscountAmount, [discount] & ' %' AS DiscountPresentage, [Sales Details].Sale "+
//"FROM Users RIGHT JOIN ((Branches RIGHT JOIN Sales ON Branches.ID = Sales.Branch) INNER JOIN (Products RIGHT JOIN [Sales Details] ON Products.ID = [Sales Details].Product) ON Sales.ID = [Sales Details].Sale) ON Users.ID = Sales.User "+
//"WHERE ((([Sales Details].Sale)=1));",frmMain.con);

//            DataSet ds =new DataSet();
//            ad.Fill(ds, "[invoice sales]");

//            dataGridView1.DataSource=ds;
//            dataGridView1.DataMember="[invoice sales]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}