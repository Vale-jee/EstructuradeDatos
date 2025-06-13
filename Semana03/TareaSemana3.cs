using System;  // Importa el espacio de nombres necesario para usar funciones básicas como Console

namespace RegistroEstudiante
{
    // Definición de la clase Estudiante
    class Estudiante
    {
        // Propiedades públicas que representan los datos de un estudiante
        public int Id;
        public string Nombres;
        public string Apellidos;
        public string Direccion;
        public string[] Telefonos = new string[3]; // Arreglo para guardar 3 números de teléfono

        // Método que muestra los datos del estudiante en consola
        public void MostrarDatos()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            // Recorre el arreglo de teléfonos y muestra cada número
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
            Console.WriteLine("-------------------------------------\n");
        }
    }

    // Clase principal que contiene el método Main
    class Program
    {
        // Método principal de ejecución del programa
        static void Main(string[] args)
        {
            // Se declara un arreglo de 3 estudiantes
            Estudiante[] estudiantes = new Estudiante[3];

            // Se asignan los datos del Estudiante 1
            estudiantes[0] = new Estudiante
            {
                Id = 1, // No uses ceros a la izquierda (001 genera advertencias en C#)
                Nombres = "Valeria Carolina",
                Apellidos = "Chucchilan Guanoluisa",
                Direccion = "Quito, Carapungo",
                Telefonos = new string[] { "0987654321", "022345678", "0991122334" }
            };

            // Se asignan los datos del Estudiante 2
            estudiantes[1] = new Estudiante
            {
                Id = 2,
                Nombres = "Carlos Andrés",
                Apellidos = "Vega Molina",
                Direccion = "Guayaquil, Urdesa",
                Telefonos = new string[] { "0981122334", "042223344", "0999988776" }
            };

            // Se asignan los datos del Estudiante 3
            estudiantes[2] = new Estudiante
            {
                Id = 3,
                Nombres = "María Fernanda",
                Apellidos = "Pérez Zambrano",
                Direccion = "Cuenca, El Batán",
                Telefonos = new string[] { "0976655443", "072334455", "0980011223" }
            };

            // Muestra el mensaje de encabezado
            Console.WriteLine("--- Lista de Estudiantes Registrados ---\n");

            // Recorre el arreglo de estudiantes y muestra los datos de cada uno
            foreach (Estudiante estudiante in estudiantes)
            {
                estudiante.MostrarDatos();
            }

            // Pausa la consola hasta que el usuario presione una tecla
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}