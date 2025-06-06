using System;

    // Clase Circulo representa un círculo con su radio
    class Circulo
    {
        private double radio; // Atributo privado que representa el radio del círculo

        // Constructor que recibe el valor del radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double, 
        // se utiliza para calcular el área de un círculo
        public double CalcularArea()
        {
            // Fórmula del área: PI * radio * radio
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro devuelve el perímetro del círculo (longitud de la circunferencia)
        public double CalcularPerimetro()
        {
            // Fórmula del perímetro: 2 * PI * radio
            return 2 * Math.PI * radio;
        }
    }

    // Clase Cuadrado representa un cuadrado con su lado
    class Cuadrado
    {
        private double lado; // Atributo privado que representa la longitud del lado del cuadrado

        // Constructor que recibe el valor del lado
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // CalcularArea devuelve el área del cuadrado
        public double CalcularArea()
        {
            // Fórmula del área: lado * lado
            return lado * lado;
        }

        // CalcularPerimetro devuelve el perímetro del cuadrado
        public double CalcularPerimetro()
        {
            // Fórmula del perímetro: 4 * lado
            return 4 * lado;
        }
    }

// Clase principal para probar las figuraclass Program
class Program
{
    static void Main(string[] args)
    {
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine("Área del Círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del Círculo: " + miCirculo.CalcularPerimetro());

        Cuadrado miCuadrado = new Cuadrado(4);
        Console.WriteLine("Área del Cuadrado: " + miCuadrado.CalcularArea());
        Console.WriteLine("Perímetro del Cuadrado: " + miCuadrado.CalcularPerimetro());
    }
}