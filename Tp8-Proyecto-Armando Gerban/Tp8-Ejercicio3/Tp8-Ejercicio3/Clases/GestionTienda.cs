using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio3.Clases
{
    internal class GestionTienda
    {
        public List<Producto> Productos { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public GestionTienda()
        {
            Productos = new List<Producto>();
            Pedidos = new List<Pedido>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void GestionarStock(string nombre, int stock)
        {
            Producto producto = null;

            foreach (var item in Productos)
            {
                if ((item.Nombre == nombre) && (item.Stock >= 1))
                {
                    producto = item;
                    break;
                }
            }

            if (producto != null)
            {
                producto.ActualizarStock(stock);
                Console.WriteLine($"El stock del producto {producto.Nombre} fue actualizado.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado");
            }
        }

        public void ProcesarPedido(Pedido pedido)
        {
            foreach (var item in pedido.Productos)
            {
                Producto prod = null;
                foreach (var item2 in Productos)
                {
                    if (item2.Nombre.Equals(item.Nombre))
                    {
                        prod = item2;
                        break;
                    }
                }

                if ((prod != null) && (prod.Stock >= 1))
                {
                    prod.ActualizarStock(-1);
                }
                else
                {
                    Console.WriteLine($"El producto {prod} no se encuentra disponible en la tienda.");
                    break;
                }
            }
            pedido.CalcularPrecio();
            Pedidos.Add(pedido);
            Console.WriteLine($"Pedido ID: {pedido.IdPedido} ha sido procesado.");
        }
    }
}
