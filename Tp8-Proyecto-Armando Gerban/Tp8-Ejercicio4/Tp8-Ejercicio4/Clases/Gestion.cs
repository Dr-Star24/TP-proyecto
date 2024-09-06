using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8_Ejercicio4.Clases
{
    internal class Gestion
    {//El sistema debe permitir la inscripción y desinscripción de estudiantes en cursos, así como la visualización de la lista de estudiantes por curso
        //añadir curso, remover curso, añadir estudiante, remover estudiante.
        private List<Curso> Cursos { get; set; }

        public Gestion()
        {
            Cursos = new List<Curso>();
        }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
            Console.WriteLine($"El curso {curso.Nombre} fue agregado.");
        }

        public void QuitarCurso(int codigo)
        {
            Curso curso = null;

            foreach (var curs in Cursos)
            {
                if (curs.Codigo == codigo)
                {
                    curso = curs;
                    break;
                }
            }

            if (curso != null)
            {
                Cursos.Remove(curso);
                Console.WriteLine($"El curso {curso.Nombre} fue eliminado.");
            }
            else
            {
                Console.WriteLine($"El curso {curso.Nombre} no fue encontrado.");
            }
        }

        public void AgregarEstudianteCurso(Estudiante estudiante, int codigoCurso)
        {
            Curso curso = null;

            foreach (var curs in Cursos)
            {
                if (curs.Codigo == codigoCurso)
                {
                    curso = curs;
                    break;
                }
            }

            if (curso != null)
            {
                curso.InscribirEstudiante(estudiante);
            }
            else
            {
                Console.WriteLine($"El codigo {codigoCurso} no corresponde a ningun curso.");
            }
        }

        public void QuitarEstudianteCurso(Estudiante estudiante, int codigoCurso)
        {
            Curso curso = null;

            foreach (var curs in Cursos)
            {
                if (curs.Codigo == codigoCurso)
                {
                    curso = curs;
                    break;
                }
            }

            if (curso != null)
            {
                curso.DesinscribirEstudiante(estudiante.NumeroMatricula);
            }
            else
            {
                Console.WriteLine($"El codigo {codigoCurso} no corresponde a ningun curso.");
            }
        }
    }
}
