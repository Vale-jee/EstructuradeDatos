using System;
using System.Collections.Generic;

// Clase que representa una torre con una pila de discos
class Torre
{
    public Stack<int> Discos = new Stack<int>(); // Pila que representa los discos en la torre
    public string Nombre; // Nombre de la torre (A, B o C)

    public Torre(string nombre)
    {
        Nombre = nombre;
    }

    // Método que mueve un disco de esta torre a otra torre
    public void MoverDiscoA(Torre destino)
    {
        int disco = Discos.Pop(); // Tomamos el disco superior
        destino.Discos.Push(disco); // Lo colocamos en la torre destino
        Console.WriteLine($"Mover disco {disco} desde {Nombre} hacia {destino.Nombre}");
    }
}

// Clase que contiene el algoritmo para resolver las Torres de Hanoi
class Hanoi
{
    // Función recursiva que resuelve el problema
    static void Resolver(int n, Torre origen, Torre auxiliar, Torre destino)
    {
        if (n == 1)
        {
            origen.MoverDiscoA(destino); // Si hay solo un disco, lo movemos directamente
        }
        else
        {
            Resolver(n - 1, origen, destino, auxiliar); // Paso 1: mover n-1 discos a la torre auxiliar
            origen.MoverDiscoA(destino);               // Paso 2: mover el disco más grande al destino
            Resolver(n - 1, auxiliar, origen, destino); // Paso 3: mover los discos desde la auxiliar al destino
        }
    }

    // Método principal
    static void Main()
    {
        int n = 4; // Número de discos (puedes cambiarlo a 4 o más para ver más pasos)

        // Creamos las tres torres
        Torre torreA = new Torre("A");
        Torre torreB = new Torre("B");
        Torre torreC = new Torre("C");

        // Colocamos los discos en la torre A, del más grande al más pequeño
        for (int i = n; i >= 1; i--)
        {
            torreA.Discos.Push(i);
        }

        // Mostramos los pasos para resolver el problema
        Console.WriteLine("Solución paso a paso de las Torres de Hanoi:");
        Resolver(n, torreA, torreB, torreC);
    }
}