using System;
using System.Globalization;


namespace uri1011;

class Program
{
    static void Main(string[] args)
    {
        double raio, volume;
        Console.WriteLine("Informe o valor do raio: ");
        raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        volume = 4.0 / 3.0 * 3.14159 * raio * raio * raio;
        Console.WriteLine("O volume da esfera é de: " + volume.ToString("F3", CultureInfo.InvariantCulture));
    }
}
