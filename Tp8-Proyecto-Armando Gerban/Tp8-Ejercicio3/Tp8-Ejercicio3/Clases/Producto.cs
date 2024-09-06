using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio3.Clases
{
    internal class Producto
    {
        //  nombre, precio, descripción y cantidad en stock
        public string Nombre { get; set; }
        public int Precio { get; set; }
        private string Descripcion { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, int precio, string descripcion, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
            Stock = stock;
        }

        public void MostrarProducto()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine("-------------------------------------");
        }

        public void ActualizarStock(int stockNuevo)
        {
            Stock += stockNuevo;
        }
    }
}
