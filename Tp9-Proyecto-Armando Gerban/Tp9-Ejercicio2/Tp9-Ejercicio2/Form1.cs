using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp9_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);

            double suma = n1 + n1;
            double resta = n1 + n2;
            double multiplicacion = n1 + n2;
            double division = n1 / n2;

            label2.Text = $"Suma: {suma}\nResta: {resta}\nMultiplicacion: {multiplicacion}\nDivision: {division}";
        }
    }
}
