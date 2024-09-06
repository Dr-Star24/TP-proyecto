using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp8_Ejercicio2.Clases;

namespace Tp8_Ejercicio2
{
    internal class Program
    {
        /*Una compañía aérea desea implementar un sistema de gestión de vuelos. Los vuelos tienen un
número, una fecha de salida, un destino y un precio. Los pasajeros tienen un nombre, número
de pasaporte y nacionalidad. Se requiere un programa que permita gestionar los vuelos,
incluyendo la adición y eliminación de vuelos, así como la gestión de los pasajeros en cada
vuelo. Identifica los posibles objetos, atributos y métodos necesarios para implementar este
sistema.
        */
        static void Main(string[] args)
        {
            GestorDeVuelos gestor = new GestorDeVuelos();

            Vuelo vuelo1 = new Vuelo(777, new DateTime(2023, 12, 20, 14, 0, 0), "Santa Maria", 299.99m);
            Vuelo vuelo2 = new Vuelo(778, new DateTime(2023, 12, 25, 14, 0, 0), "Loro Huasi", 300.99m);

            gestor.AgregarVuelo(vuelo1);
            gestor.AgregarVuelo(vuelo2);

            Pasajero pasajero1 = new Pasajero("Cintia", 2609, "Argentina");
            Pasajero pasajero2 = new Pasajero("Pancracio 33c", 2610, "argentina");

            vuelo1.AgregarPasajeros(pasajero1);
            vuelo2.AgregarPasajeros(pasajero2);


            Console.WriteLine("Mostrando vuelos: \n");
            gestor.MostrarVuelo();


            gestor.QuitarVuelo(778);

            Console.WriteLine();
            Console.WriteLine("Mostrando vuelos: \n");
            gestor.MostrarVuelo();

            Console.ReadKey();
        }
    }
}
