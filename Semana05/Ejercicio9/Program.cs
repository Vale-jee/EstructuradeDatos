using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir la palabra al usuario
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // Convertimos a minúscula

        // Contadores de vocales
        int a = 0, e = 0, i = 0, o = 0, u = 0;

        // Recorrer cada letra de la palabra
        foreach (char letra in palabra)
        {
            switch (letra)
            {
                case 'a': a++; break;
                case 'e': e++; break;
                case 'i': i++; break;
                case 'o': o++; break;
                case 'u': u++; break;
            }
        }

        // Mostrar los resultados
        Console.WriteLine($"Cantidad de vocales en \"{palabra}\":");
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"e: {e}");
        Console.WriteLine($"i: {i}");
        Console.WriteLine($"o: {o}");
        Console.WriteLine($"u: {u}");
    }
}
