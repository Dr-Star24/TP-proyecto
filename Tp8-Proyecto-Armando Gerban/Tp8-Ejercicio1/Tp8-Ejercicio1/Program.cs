using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp8_Ejercicio1.Clases;

namespace Tp8_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una biblioteca digital ofrece una amplia variedad de libros a sus usuarios registrados. Los
usuarios pueden buscar libros, leer descripciones, ver la disponibilidad y, si están registrados,
pueden pedir prestados los libros. Los libros pueden estar disponibles en formato digital o físico.
Cada vez que un usuario pide prestado un libro, se registra la fecha de préstamo y la fecha de
devolución prevista. Además, la biblioteca tiene un sistema para enviar recordatorios a los
usuarios cuando se acerca la fecha de devolución de un libro.
            */

            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AgregarLibro(new Libro("El jardin de las palabras", "Makoto Shinkai", true, true));
            biblioteca.AgregarLibro(new Libro("Komi-San", "Tomohito Oda", true, true));

            biblioteca.RegistrarUsuario(new Usuario("Cintia Romero", 2609));
            biblioteca.RegistrarUsuario(new Usuario("Pancracio 3", 2610));
            biblioteca.RegistrarUsuario(new Usuario("Sevati", 2611));

            Console.WriteLine("Los usuarios de la biblioteca son: ");
            biblioteca.MostrarUsuarios();

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Libros en la biblioteca: ");
            biblioteca.MostrarLibros();

            Console.WriteLine("------------------------------------------------");

            biblioteca.PrestarLibro("El jardin de las palabras", "Cintia Romero");

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Mostrando libros luego de un prestamo: ");
            biblioteca.MostrarLibros();

            Console.WriteLine("------------------------------------------------");

            biblioteca.DevolverLibro("El jardin de las palabras");

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Mostrando los libros luego de la devolucion: ");
            biblioteca.MostrarLibros();

            Console.ReadKey();
        }
    }
}
