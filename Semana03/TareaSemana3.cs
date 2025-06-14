using System; // Permite usar la clase Console para imprimir en pantalla

namespace RegistroEstudiante // Agrupa las clases dentro de un mismo “espacio de nombres”
{
    // ----- Clase que representa a un estudiante -----
    class Estudiante
    {
        // Campos (datos) públicos del estudiante
        public int Id;                  // Identificador
        public string Nombres;          // Nombres
        public string Apellidos;        // Apellidos
        public string Direccion;        // Dirección
        public string[] Telefonos = new string[3]; // Arreglo de 3 teléfonos

        // ----- Muestra todos los datos del estudiante -----
        public void MostrarDatos()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            // Recorre el arreglo y muestra cada teléfono
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    // ----- Clase principal que contiene el punto de entrada -----
    class Program
    {
        // Método Main: la aplicación empieza aquí
        static void Main(string[] args)
        {
            // Crea un objeto Estudiante con datos fijos
            Estudiante estudiante = new Estudiante
            {
                Id = 1,
                Nombres = "Valeria Carolina",
                Apellidos = "Chucchilan Guanoluisa",
                Direccion = "Quito, Carapungo",
                Telefonos = new string[]
                {
                    "0987654321",
                    "022345678",
                    "0991122334"
                }
            };

            // Llama al método para imprimir los datos en pantalla
            estudiante.MostrarDatos();
        }
    }
}