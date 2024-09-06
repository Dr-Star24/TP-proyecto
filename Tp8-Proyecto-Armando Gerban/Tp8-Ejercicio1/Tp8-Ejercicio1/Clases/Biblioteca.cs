using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio1.Clases {
internal class Biblioteca
{
    private List<Libro> libros = new List<Libro>();
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Prestamo> prestamos = new List<Prestamo>();

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    public void PrestarLibro(string titulo, string nombreUsuario)
    {
        Libro libro = null;
        Usuario usuario = null;

        foreach (var librito in libros)
        {
            if ((librito.NombreLibro == titulo) && (librito.Disponibilidad == true))
            {
                libro = librito;
                break;
            }
        }

        foreach (var pibes in usuarios)
        {
            if (pibes.NombreUsuario == nombreUsuario)
            {
                usuario = pibes;
                break;
            }
        }

        if (libro == null)
        {
            Console.WriteLine("Libro no encontrado.");
        }

        if (usuario == null)
        {
            Console.WriteLine("Usuario no encontrado.");
        }

        libro.Disponibilidad = false;
        Console.WriteLine($"El libro {libro.NombreLibro} fue prestado a {usuario.NombreUsuario}.");
    }

    public void DevolverLibro(string titulo)
    {
        foreach (var librito in libros)
        {
            if ((librito.NombreLibro == titulo) && (librito.Disponibilidad != true))
            {
                librito.Disponibilidad = true;
                Console.WriteLine($"El libro {librito.NombreLibro} fue devuelto.");
                break;
            }
            else
            {
                Console.WriteLine("El libro no fue encontrado.");
            }
        }

    }

    public void MostrarLibros()
    {
        foreach (Libro libro in libros)
        {
            libro.MostrarDatos();
            Console.WriteLine();
        }
    }

    public void MostrarUsuarios()
    {
        foreach (Usuario usuario in usuarios)
        {
            usuario.MostrarDetalles();
            Console.WriteLine();
        }
    }
}
}