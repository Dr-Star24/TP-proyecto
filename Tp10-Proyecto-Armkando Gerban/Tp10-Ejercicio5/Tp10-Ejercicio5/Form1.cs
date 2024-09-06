using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp10_Ejercicio5
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
            string navegadores = "";

            navegadores += (checkBox1.Checked ? checkBox1.Text + "\n" : espacioBlanco);
            navegadores += (checkBox2.Checked ? checkBox2.Text + "\n" : espacioBlanco);
            navegadores += (checkBox3.Checked ? checkBox3.Text + "\n" : espacioBlanco);

            label2.Text = navegadores;
        }
    }
}
