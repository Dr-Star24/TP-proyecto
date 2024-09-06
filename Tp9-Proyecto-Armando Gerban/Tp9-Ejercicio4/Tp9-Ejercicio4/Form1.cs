using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp9_Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letraIngresada = Convert.ToChar(textBox1.Text.ToLower());

            if ("aeiou".Contains(letraIngresada)){
                label2.BackColor = Color.White;
                label2.Text = $"'{letraIngresada}' es una vocal.";
            }
            else
            {
                label2.BackColor = Color.White;
                label2.Text = $"'{letraIngresada}' no es una vocal.";
            }
        }
    }
}
