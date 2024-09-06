using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp10_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Height = 600;
                this.Width = 800;
            }
            else if (radioButton2.Checked)
            {
                this.Height = 800;
                this.Width = 900;
            }
            else if (radioButton3.Checked)
            {
                this.Height = 900;
                this.Width = 1000;
            }
        }
    }
}
