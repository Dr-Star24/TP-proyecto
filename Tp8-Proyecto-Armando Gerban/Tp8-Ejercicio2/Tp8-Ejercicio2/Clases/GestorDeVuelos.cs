using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio2.Clases
{
    internal class GestorDeVuelos
    {
        private List<Vuelo> vuelos = new List<Vuelo>();

        public void AgregarVuelo(Vuelo vuelo)
        {
            vuelos.Add(vuelo);
        }

        public void QuitarVuelo(int numeroVuelo)
        {
            Vuelo vuelo = BuscarVuelo(numeroVuelo);

            if (vuelo != null)
            {
                vuelos.Remove(vuelo);
                Console.WriteLine($"Vuelo {numeroVuelo} eliminado.");
            }
            else
            {
                Console.WriteLine("Vuelo no encontrado.");
            }
            vuelos.Remove(vuelo);
        }

        public Vuelo BuscarVuelo(int numeroVuelo)
        {
            foreach (var vuelo in vuelos)
            {
                if (vuelo.NumeroDeVuelo == numeroVuelo)
                {
                    return vuelo;
                }
            }
            return null;
        }

        public void MostrarVuelo()
        {
            foreach (Vuelo vuel in vuelos)
            {
                vuel.MostrarDetallesVuelo();
                Console.WriteLine();
            }
        }
    }
}
