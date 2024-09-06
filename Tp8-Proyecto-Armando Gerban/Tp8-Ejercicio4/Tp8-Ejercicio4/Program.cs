using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp8_Ejercicio4.Clases;

namespace Tp8_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una universidad desea crear un sistema para la gestión de cursos y estudiantes. Cada curso
    tiene un código, nombre, profesor y la materia que dicta. Los estudiantes tienen un nombre,
    número de matrícula y el año de cursado. El sistema debe permitir la inscripción y des
    inscripción de estudiantes en cursos, así como la visualización de la lista de estudiantes por
    curso. Identifica los objetos, atributos y métodos necesarios para implementar este sistema.
                */
            Gestion gestion = new Gestion();

            Curso curso1 = new Curso(777, "Introduccion a la Programacion", "Profesor Cano", "Programacion");
            Curso curso2 = new Curso(778, "Calculo I", "Profesora Roxana", "Matematicas");

            gestion.AgregarCurso(curso1);
            gestion.AgregarCurso(curso2);

            Estudiante estudiante1 = new Estudiante("Cintia Romero", 2609, 2023);
            Estudiante estudiante2 = new Estudiante("Pancracio 3", 26010, 2023);
            Estudiante estudiante3 = new Estudiante("Sevati", 2611, 2023);

            Console.WriteLine("------------------------------------------------------------");

            gestion.AgregarEstudianteCurso(estudiante1, 777);
            gestion.AgregarEstudianteCurso(estudiante2, 778);
            gestion.AgregarEstudianteCurso(estudiante3, 777);

            Console.WriteLine("------------------------------------------------------------");

            curso1.MostrarEstudiantes();

            Console.WriteLine("------------------------------------------------------------");

            curso2.MostrarEstudiantes();

            Console.WriteLine("------------------------------------------------------------");

            gestion.QuitarEstudianteCurso(estudiante1, 777);

            Console.WriteLine("------------------------------------------------------------");

            curso1.MostrarEstudiantes();

            Console.ReadKey();
        }
    }
}