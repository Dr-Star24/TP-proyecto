using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio2.Clases
{
    internal class Pasajero
    {
        public string Nombre { get; set; }
        public int NumeroPasaporte { get; set; }
        public string Nacionalidad { get; set; }

        public Pasajero(string nombre, int numero_pasaporte, string nacionalidad)
        {
            Nombre = nombre;
            NumeroPasaporte = numero_pasaporte;
            Nacionalidad = nacionalidad;
        }

        public void MostrarDatosPasajero()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Numero de pasaporte: {NumeroPasaporte}");
            Console.WriteLine($"Nacionalidad: {Nacionalidad}");
        }
    }
}
