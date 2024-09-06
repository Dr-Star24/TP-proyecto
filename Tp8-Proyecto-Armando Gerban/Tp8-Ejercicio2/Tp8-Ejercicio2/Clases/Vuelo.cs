using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio2.Clases
{
    internal class Vuelo
    {
        public int NumeroDeVuelo { get; set; }
        private DateTime FechaSalida { get; set; }
        private string Destino { get; set; }
        private decimal Precio { get; set; }

        // profe cano escribio: private DateTime hora;

        private List<Pasajero> pasajeros = new List<Pasajero>();

        public Vuelo(int numero_vuelo, DateTime fecha_salida, string destino, decimal precio)
        {
            NumeroDeVuelo = numero_vuelo;
            FechaSalida = fecha_salida;
            Destino = destino;
            Precio = precio;
        }

        public void AgregarPasajeros(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }

        public void RemoverPasajeros(Pasajero pasajero)
        {
            pasajeros.Remove(pasajero);
        }

        public void MostrarDetallesVuelo()
        {
            Console.WriteLine($"Numero de vuelo: {NumeroDeVuelo}");
            Console.WriteLine($"Fecha de salida: {FechaSalida}");
            Console.WriteLine($"Destino: {Destino}");
            Console.WriteLine($"Precio en dolares (USD): {Precio}");
            Console.WriteLine("======Pasajeros======");
            foreach (var pasajero in pasajeros)
            {
                pasajero.MostrarDatosPasajero();
                Console.WriteLine();
            }
        }
    }
}
