using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp10_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            //con el tryparse se intenta guardar los numeros, verificando que sean valores adecuados, con el out se indica
            //en que variable se guardara el numero si es correcto. TryParse devuelve true o false.
            resultado = 0;
            if((double.TryParse(textBox1.Text, out num1) && double.TryParse(textBox2.Text, out num2)))
            {
                if (radioButton1.Checked)
                {
                    resultado = num1 + num2;
                }
                else if (radioButton2.Checked)
                {
                    resultado = num1 - num2;
                }

                label2.Text = resultado.ToString();
            }
            else
            {
                label2.Text = "Ingrese valores validos.";
            }
        }
    }
}
