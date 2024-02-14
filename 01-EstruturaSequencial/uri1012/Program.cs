using System;
using System.Globalization;

namespace uri1012;

class Program
{
    static void Main(string[] args)
    {
        double valorA, valorB, valorC;
        double triangulo, circulo, trapezio, quadrado, retangulo;
        string[] valores = Console.ReadLine().Split(' ');

        Console.WriteLine("Informe o valor A");
        valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
        Console.WriteLine("Informe o valor B");
        valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
        Console.WriteLine("Informe o valor C");
        valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

        triangulo = valorA * valorC / 2.0;
        circulo = 3.14159 * valorC * valorC;
        trapezio = (valorA + valorB) / 2.0 * valorC;
        quadrado = valorB * valorB;
        retangulo = valorA * valorB;

        Console.WriteLine("Area do triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("Area do circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("Area do trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("Area do quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("Area do retangulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }
}
