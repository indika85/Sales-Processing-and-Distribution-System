using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SellIt
{
    public partial class popupEdit : Form
    {
        public static popupEdit pop;
        public string h = "", l = "", r = "";
        private int rowIndex = 0;
        public popupEdit()
        {
            pop = this;
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void popupEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }
        public void setValues(string low,string high, string rate,int index)
        {
            ep.Clear();
            txtLow.Text = low;
            txtHeigh.Text = high;
            txtRate.Text = rate;
            rowIndex = index;
        }

        private void txtLow_Leave(object sender, EventArgs e)
        {
            if (txtLow.Text != "" && txtHeigh.Text == "")
            {
                txtHeigh.Text = Convert.ToString(int.Parse(txtLow.Text) + 1);
                txtHeigh.SelectAll();
            }
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtLow.Text == "")
            { ep.SetError(txtLow, "Please insert a value for Low Bounds"); return; }
            else if(txtHeigh.Text=="")
            { ep.SetError(txtHeigh, "Please insert a value for High Bounds"); return; }
            else if (txtRate.Text == "")
            { ep.SetError(txtRate, "Please insert a value for the rate"); return; }

            if (int.Parse(txtLow.Text) > int.Parse(txtHeigh.Text))
            {
                txtHeigh.SelectAll();
                MessageBox.Show("Low bounds should be less than the high bounds", "SellIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                h = txtHeigh.Text;
                l = txtLow.Text;
                r = txtRate.Text;
                frmDiscount.dis.setGridValues(l, h, r);
                Visible = false;
            }
        }

        private void popupEdit_Activated(object sender, EventArgs e)
        {
            frmDiscount.dis.selectRow();
        }
    }
}