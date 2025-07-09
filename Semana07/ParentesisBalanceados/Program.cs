using System;
using System.Collections.Generic;

class VerificadorBalanceo
{
    // Función que revisa si los paréntesis, corchetes y llaves están balanceados
    static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>(); // Creamos una pila para guardar los símbolos de apertura

        foreach (char c in expresion) // Recorremos cada carácter de la expresión
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c); // Guardamos en la pila los símbolos de apertura
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0) return false; // Si no hay elementos para cerrar → desbalanceado

                char cima = pila.Pop(); // Tomamos el último símbolo abierto

                // Comprobamos si el símbolo de cierre corresponde al que se abrió
                if ((c == ')' && cima != '(') ||
                    (c == '}' && cima != '{') ||
                    (c == ']' && cima != '['))
                {
                    return false; // Si no coincide, la fórmula está mal balanceada
                }
            }
        }

        // Si al final la pila está vacía, todo fue cerrado correctamente
        return pila.Count == 0;
    }

    // Programa principal
    static void Main()
    {
        Console.Write("Ingrese una expresión matemática: ");
        string expresion = Console.ReadLine(); // Leer la expresión del usuario

        // Verificamos si está balanceada
        if (EstaBalanceado(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula desbalanceada.");
    }
}