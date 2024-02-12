using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {

            double R, A, pi = 3.14159;
            Console.WriteLine("Informe o valor do raio: ");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("O valor da área é: ");
            A = pi * R * R;

            Console.WriteLine("A: " + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}