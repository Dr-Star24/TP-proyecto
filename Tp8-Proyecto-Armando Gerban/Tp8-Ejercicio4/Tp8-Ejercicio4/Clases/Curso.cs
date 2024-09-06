using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio4.Clases
{
    internal class Curso
    {
        //Cada curso tiene un código, nombre, profesor y la materia que dicta
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        private string Profesor { get; set; }
        private string Materia { get; set; }
        private List<Estudiante> Pibes { get; set; }

        public Curso(int codigo, string nombre, string profesor, string materia)
        {
            Codigo = codigo;
            Nombre = nombre;
            Profesor = profesor;
            Materia = materia;
            Pibes = new List<Estudiante>();
        }

        public void InscribirEstudiante(Estudiante estudiante)
        {
            Pibes.Add(estudiante);
            Console.WriteLine($"El estudiante {estudiante.Nombre} fue inscrito en el curso {Nombre}");
        }

        public void DesinscribirEstudiante(int numeroMatricula)
        {
            Estudiante pibe = null;

            foreach (var estudiante in Pibes)
            {
                if (estudiante.NumeroMatricula == numeroMatricula)
                {
                    pibe = estudiante;
                    break;
                }
            }

            if (pibe != null)
            {
                Pibes.Remove(pibe);
                Console.WriteLine($"El estudiante {pibe.Nombre} fue removido del curso {Nombre}.");
            }
        }

        public void MostrarEstudiantes()
        {
            Console.WriteLine($"Mostrando la lista de estudiantes en el curso {Nombre}");
            foreach (var estudiante in Pibes)
            {
                estudiante.MostrarDatosEstudiante();
            }
        }
    }
}
