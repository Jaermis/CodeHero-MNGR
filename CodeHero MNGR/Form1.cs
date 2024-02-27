using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeHero_MNGR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(1, 6);

            string num = Convert.ToString(rInt);

            label1.Text = num;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
        }
    }
}
