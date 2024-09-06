using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio3.Clases
{
    internal class Pedido
    {
        //identificador de pedido, fecha de pedido, cliente y el precio total del pedido
        public int IdPedido { get; set; }
        private DateTime FechaPedido { get; set; }
        private Cliente ClientePedido { get; set; }
        private int PrecioPedido { get; set; }
        public List<Producto> Productos { get; set; }

        public Pedido(int idPedido, DateTime fechaPedido, Cliente cliente)
        {
            IdPedido = idPedido;
            FechaPedido = fechaPedido;
            ClientePedido = cliente;
            Productos = new List<Producto>();
        }

        public void CalcularPrecio()
        {
            PrecioPedido = 0;

            foreach (var product in Productos)
            {
                PrecioPedido += product.Precio;
            }
        }

        public void MostrarDatosPedido()
        {
            Console.WriteLine($"Id del Pedido: {IdPedido}");
            Console.WriteLine($"Fecha del pedido: {FechaPedido}");
            ClientePedido.MostrarDatos();
            Console.WriteLine("Productos: \n");
            foreach (var product in Productos)
            {
                product.MostrarProducto();
            }
            Console.WriteLine($"Precio del pedido: {PrecioPedido}");
        }

    }
}
