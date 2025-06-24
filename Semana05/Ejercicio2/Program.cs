using System;
using System.Collections.Generic;

namespace CursoAsignaturas
{
    // Clase que representa un Curso
    class Curso
    {
        private string nombre;
        private List<string> asignaturas;

        // Constructor que recibe el nombre del curso
        public Curso(string nombreCurso)
        {
            nombre = nombreCurso;
            asignaturas = new List<string>
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        // Método para mostrar el mensaje personalizado por cada asignatura
        public void MostrarAsignaturasEstudiadas()
        {
            Console.WriteLine($"Estudiante del curso {nombre}:");
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el curso "Primero BGU 'A'"
            Curso miCurso = new Curso("Primero BGU 'A'");

            // Mostrar el mensaje por cada asignatura
            miCurso.MostrarAsignaturasEstudiadas();
        }
    }
}