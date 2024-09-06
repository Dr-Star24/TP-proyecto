using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp10_Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string espacioBlanco = "";
            string idiomas = "";

            idiomas += (checkBox1.Checked ? checkBox1.Text + "\n" : espacioBlanco) ;
            idiomas += (checkBox2.Checked ? checkBox2.Text + "\n" : espacioBlanco);
            idiomas += (checkBox3.Checked ? checkBox3.Text + "\n" : espacioBlanco);

            label2.Text = idiomas;
        }
    }
}
