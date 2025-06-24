using System;
using System.Collections.Generic;

namespace CursoAsignaturas
{
    // Clase que representa un Curso
    class Curso
    {
        // Atributo: lista de asignaturas
        private List<string> asignaturas;

        // Constructor: inicializa las asignaturas del curso
        public Curso()
        {
            asignaturas = new List<string>
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        // Método para mostrar las asignaturas
        public void MostrarAsignaturas()
        {
            Console.WriteLine("Las asignaturas del curso son:");
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine(asignatura);
            }
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Curso
            Curso miCurso = new Curso();

            // Llamar al método para mostrar las asignaturas
            miCurso.MostrarAsignaturas();
        }
    }
}
