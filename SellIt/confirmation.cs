using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    public partial class confirmation : Form
    {
        public static confirmation cnf;
        public int quantity = 1;
        private int maxval = 1;
        Size original = new Size(350, 175);
        Size expanded = new Size(350, 250);
        public confirmation(int max)
        {
            maxval = max;
            cnf = this;
            InitializeComponent();
            this.Size = original;
            nm.Maximum = Convert.ToDecimal(max);
        }

        private void confirmation_Load(object sender, EventArgs e)
        {
            label1.Text = "The purchased quantity of the product is greater than 1.\nThere are " + maxval.ToString() + " units purchased. \nDo you want to replace them all ? \n \n\nPress Yes to replase all or press No to specify a quantity.";
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            Size = expanded;
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(nm.Value);
            Close();
        }

        private void glassButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            quantity = maxval;
            Close();
        }
    }
}