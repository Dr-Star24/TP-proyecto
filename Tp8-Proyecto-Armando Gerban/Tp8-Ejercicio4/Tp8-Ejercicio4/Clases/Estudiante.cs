using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio4.Clases
{
    internal class Estudiante
    {
        //Los estudiantes tienen un nombre, número de matrícula y el año de cursado

        public string Nombre { get; set; }
        public int NumeroMatricula { get; set; }
        private int AnioCursado { get; set; }

        public Estudiante(string nombre, int numeroMatricula, int anioCursado)
        {
            Nombre = nombre;
            NumeroMatricula = numeroMatricula;
            AnioCursado = anioCursado;
        }

        public void MostrarDatosEstudiante()
        {
            Console.WriteLine($"Nombre: {Nombre}.");
            Console.WriteLine($"Numero de matricula: {NumeroMatricula}");
            Console.WriteLine($"Año cursado: {AnioCursado}");
        }
    }
}
