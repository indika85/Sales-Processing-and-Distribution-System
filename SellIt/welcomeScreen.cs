using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SellIt
{
    
    public partial class welcomeScreen : Form
    {
        int i = -10;
        public welcomeScreen()
        {
            
            InitializeComponent();
        }

        private void welcomeScreen_Load(object sender, EventArgs e)
        {
                
            
        }

        private void welcomeScreen_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            //this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //BringToFront();
            i++;
            if (i > 0 && i < 100)
            {
                if (Opacity <= 1) Opacity += 0.03;
            }
            else if (i > 150)
            {
                if (Opacity >= 0) Opacity -= 0.03;
                if (Opacity == 0) Close();
            }
        }

        private void welcomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcomeScreen_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}