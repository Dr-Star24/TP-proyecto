using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio3.Clases
{
    internal class Cliente
    {
        //nombre, dirección de envío y dirección de correo electrónico
        public string Nombre { get; set; }
        public string DireccionEnvio { get; set; }
        public string Email { get; set; }

        public Cliente(string nombre, string direccionEnvio, string email)
        {
            Nombre = nombre;
            DireccionEnvio = direccionEnvio;
            Email = email;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Direccion del envio: {DireccionEnvio}");
            Console.WriteLine($"Correo electronico: {Email}");
        }
    }
}
