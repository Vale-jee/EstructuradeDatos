using System;

class Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public decimal Precio { get; set; }
}

class Nodo
{
    public Vehiculo Dato;
    public Nodo Siguiente;

    public Nodo(Vehiculo vehiculo)
    {
        Dato = vehiculo;
        Siguiente = null;
    }
}

class ListaVehiculos
{
    private Nodo primero;

    public ListaVehiculos()
    {
        primero = null;
    }

    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        Nodo nuevo = new Nodo(vehiculo);
        if (primero == null)
        {
            primero = nuevo;
        }
        else
        {
            Nodo actual = primero;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    public Vehiculo BuscarPorPlaca(string placa)
    {
        Nodo actual = primero;
        while (actual != null)
        {
            if (actual.Dato.Placa == placa)
                return actual.Dato;
            actual = actual.Siguiente;
        }
        return null;
    }

    public void VerPorAño(int año)
    {
        Nodo actual = primero;
        bool encontrado = false;
        while (actual != null)
        {
            if (actual.Dato.Año == año)
            {
                MostrarVehiculo(actual.Dato);
                encontrado = true;
            }
            actual = actual.Siguiente;
        }
        if (!encontrado)
            Console.WriteLine("No hay vehículos registrados en ese año.");
    }

    public void VerTodos()
    {
        Nodo actual = primero;
        if (actual == null)
        {
            Console.WriteLine("No hay vehículos registrados.");
            return;
        }
        while (actual != null)
        {
            MostrarVehiculo(actual.Dato);
            actual = actual.Siguiente;
        }
    }

    public void EliminarVehiculo(string placa)
    {
        Nodo actual = primero;
        Nodo anterior = null;

        while (actual != null)
        {
            if (actual.Dato.Placa == placa)
            {
                if (anterior == null)
                    primero = actual.Siguiente;
                else
                    anterior.Siguiente = actual.Siguiente;

                Console.WriteLine("Vehículo eliminado exitosamente.");
                return;
            }
            anterior = actual;
            actual = actual.Siguiente;
        }

        Console.WriteLine("Vehículo no encontrado.");
    }

    private void MostrarVehiculo(Vehiculo v)
    {
        Console.WriteLine($"Placa: {v.Placa}, Marca: {v.Marca}, Modelo: {v.Modelo}, Año: {v.Año}, Precio: ${v.Precio}");
    }
}

class Program
{
    static void Main()
    {
        ListaVehiculos lista = new ListaVehiculos();
        string opcion;

        do
        {
            Console.WriteLine("\n--- Menú Estacionamiento Área de Ingeniería ---");
            Console.WriteLine("a. Agregar vehículo");
            Console.WriteLine("b. Buscar vehículo por placa");
            Console.WriteLine("c. Ver vehículos por año");
            Console.WriteLine("d. Ver todos los vehículos");
            Console.WriteLine("e. Eliminar vehículo registrado");
            Console.WriteLine("f. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine().ToLower();

            switch (opcion)
            {
                case "a":
                    Vehiculo v = new Vehiculo();
                    Console.Write("Ingrese placa: ");
                    v.Placa = Console.ReadLine();
                    Console.Write("Ingrese marca: ");
                    v.Marca = Console.ReadLine();
                    Console.Write("Ingrese modelo: ");
                    v.Modelo = Console.ReadLine();
                    Console.Write("Ingrese año: ");
                    v.Año = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese precio: ");
                    v.Precio = decimal.Parse(Console.ReadLine());

                    lista.AgregarVehiculo(v);
                    Console.WriteLine("Vehículo agregado con éxito.");
                    break;

                case "b":
                    Console.Write("Ingrese la placa a buscar: ");
                    string placaBuscar = Console.ReadLine();
                    Vehiculo encontrado = lista.BuscarPorPlaca(placaBuscar);
                    if (encontrado != null)
                    {
                        Console.WriteLine("Vehículo encontrado:");
                        Console.WriteLine($"Placa: {encontrado.Placa}, Marca: {encontrado.Marca}, Modelo: {encontrado.Modelo}, Año: {encontrado.Año}, Precio: ${encontrado.Precio}");
                    }
                    else
                    {
                        Console.WriteLine("Vehículo no encontrado.");
                    }
                    break;

                case "c":
                    Console.Write("Ingrese el año a buscar: ");
                    int añoBuscar = int.Parse(Console.ReadLine());
                    lista.VerPorAño(añoBuscar);
                    break;

                case "d":
                    Console.WriteLine("\nVehículos registrados:");
                    lista.VerTodos();
                    break;

                case "e":
                    Console.Write("Ingrese la placa del vehículo a eliminar: ");
                    string placaEliminar = Console.ReadLine();
                    lista.EliminarVehiculo(placaEliminar);
                    break;

                case "f":
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != "f");
    }
}
