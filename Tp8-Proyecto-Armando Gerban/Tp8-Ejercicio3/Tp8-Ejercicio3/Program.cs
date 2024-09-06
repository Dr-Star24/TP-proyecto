using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp8_Ejercicio3.Clases;

namespace Tp8_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Una tienda en línea desea desarrollar un sistema para gestionar sus productos y pedidos. Cada
producto tiene un nombre, precio, descripción y cantidad en stock. Los pedidos incluyen un
identificador de pedido, fecha de pedido, cliente y el precio total del pedido. Los clientes tienen
un nombre, dirección de envío y dirección de correo electrónico. Diseña un programa que
permita agregar productos, gestionar el stock, y procesar pedidos. Identifica los objetos,
atributos y métodos necesarios para este sistema.*/
            GestionTienda gestion = new GestionTienda();

            Producto producto1 = new Producto("Laptop", 300500, "Laptop Dell", 10);
            Producto producto2 = new Producto("Mouse", 9500, "Mouse Logitech", 50);

            gestion.AgregarProducto(producto1);
            gestion.AgregarProducto(producto2);

            Cliente cliente1 = new Cliente("Cintia Nadia", "123 Loro Huasi", "amoanaza@pancracio.com");
            Cliente cliente2 = new Cliente("Pancracio 3", "123 Loro Huasi", "llamalover@pancracio.com");
            Cliente cliente3 = new Cliente("Sevati", "El Cerrito", "sevati@sevati.com");

            Pedido pedido = new Pedido(1, DateTime.Now, cliente1);


            pedido.Productos.Add(producto1);
            pedido.Productos.Add(producto2);

            gestion.ProcesarPedido(pedido);

            pedido.MostrarDatosPedido();

            gestion.GestionarStock("Laptop", 5);

            producto1.MostrarProducto();
            producto2.MostrarProducto();

            Console.ReadKey();
        }
    }
}
