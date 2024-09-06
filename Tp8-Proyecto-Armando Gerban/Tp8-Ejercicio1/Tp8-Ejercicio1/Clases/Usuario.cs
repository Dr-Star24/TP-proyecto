using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio1.Clases
{
    internal class Usuario
    {
        public string NombreUsuario { get; set; }
        private int IdUsuario { get; set; }

        public Usuario(string nombre, int id)
        {
            NombreUsuario = nombre;
            IdUsuario = id;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Usuario: {NombreUsuario}");
            Console.WriteLine($"Id: {IdUsuario}");
        }
    }
}

