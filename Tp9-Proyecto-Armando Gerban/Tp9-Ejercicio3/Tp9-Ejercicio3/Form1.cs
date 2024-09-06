using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp9_Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            //double resultado1 = (a + b) * (a - b); no funciona

            double resultado1 = (a + b * a - b) * -1;
            double resultado2 = Math.Pow(a, 2) - Math.Pow(b, 2);

            label2.Text = $"(a+b)*(a-b): {resultado1}\na^2 - b^2: {resultado1} ";
        }
    }
}
