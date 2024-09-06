using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio1.Clases
{
    internal class Libro
    {
        public string NombreLibro { get; set; }
        private string AutorLibro { get; set; }
        private bool EsDigital { get; set; }
        public bool Disponibilidad { get; set; }

        public Libro(string nombre, string autor, bool esDigital, bool disponibilidad)
        {
            NombreLibro = nombre;
            AutorLibro = autor;
            EsDigital = esDigital;
            Disponibilidad = disponibilidad;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Titulo: {NombreLibro}");
            Console.WriteLine($"Autor: {AutorLibro}");
            Console.WriteLine($"Formato: {(EsDigital ? "Digital" : "Fisico")}");
            Console.WriteLine($"Disponible: {(Disponibilidad ? "Si" : "No")}");
        }
    }
}
