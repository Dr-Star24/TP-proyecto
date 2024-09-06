using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp10_Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(label1.Text.Length <= 10)
            {
                label1.Text += 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 4;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 5;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 6;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 7;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 8;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 9;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 10)
            {
                label1.Text += 0;
            }
        }
    }
}
