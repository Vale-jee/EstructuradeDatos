using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear la lista del abecedario (en minúsculas)
        List<char> abecedario = new List<char>();
        for (char letra = 'a'; letra <= 'z'; letra++)
        {
            abecedario.Add(letra);
        }

        // Crear una nueva lista excluyendo las letras en posiciones múltiplos de 3
        List<char> resultado = new List<char>();
        for (int i = 0; i < abecedario.Count; i++)
        {
            if ((i + 1) % 3 != 0)  // (posición iniciando en 1)
            {
                resultado.Add(abecedario[i]);
            }
        }

        // Mostrar la lista resultante
        Console.WriteLine("Letras que no están en posiciones múltiplos de 3:");
        Console.WriteLine(string.Join(", ", resultado));
    }
}