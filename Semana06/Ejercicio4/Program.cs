using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();
        LinkedList<int> numeros = new LinkedList<int>();

        // Crear lista con 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            int numero = random.Next(1, 1000); // 1000 no incluido
            numeros.AddLast(numero);
        }

        Console.WriteLine("Lista original:");
        MostrarLista(numeros);

        // Leer el rango desde el teclado
        Console.Write("\nIngrese el valor mínimo del rango: ");
        int minimo = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int maximo = int.Parse(Console.ReadLine());

        // Eliminar nodos fuera del rango
        var nodo = numeros.First;
        while (nodo != null)
        {
            var siguiente = nodo.Next;
            if (nodo.Value < minimo || nodo.Value > maximo)
            {
                numeros.Remove(nodo);
            }
            nodo = siguiente;
        }

        // Mostrar la lista final
        Console.WriteLine("\nLista después de eliminar los nodos fuera del rango:");
        MostrarLista(numeros);
    }

    static void MostrarLista(LinkedList<int> lista)
    {
        foreach (int numero in lista)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}