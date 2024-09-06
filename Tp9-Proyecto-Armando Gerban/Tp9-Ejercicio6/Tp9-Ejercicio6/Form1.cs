using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp9_Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double capacidadGB = Convert.ToDouble(textBox1.Text);
            double capacidadMB = capacidadGB * 1024;
            int cdMB = 700;
            
            //math ceiling sirve para redondear los numeros, antes se debe colocar (int) para convertir el resultado,
            //ya que math ceiling por determinado devuelve double.
            int cds = (int)Math.Ceiling(capacidadMB / cdMB);

            label3.Text = $"Se necesitan {cds} CDs para guardar {capacidadGB} GB en CDs de 700MB.";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
