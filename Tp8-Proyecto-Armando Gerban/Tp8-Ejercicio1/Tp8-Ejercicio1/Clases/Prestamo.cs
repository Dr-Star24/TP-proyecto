using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio1.Clases
{
    internal class Prestamo
    {
        private Usuario Usuario { get; set; }
        public Libro LibroDatos { get; set; }
        private DateTime FechaPrestamo { get; set; }
        private DateTime FechaDevolucion { get; set; }

        public Prestamo(Usuario usuario, Libro libro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            Usuario = usuario;
            LibroDatos = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }

        public void DatosLibroPrestamo()
        {
            Console.WriteLine($"Usuario: {Usuario}");
            Console.WriteLine($"Libro: {LibroDatos.NombreLibro}");
            Console.WriteLine($"Fecha prestamo: {FechaPrestamo}");
            Console.WriteLine($"Fecha devolucion: {FechaDevolucion}");
        }
    }
}
