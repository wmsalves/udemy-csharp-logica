using System;
using System.Globalization;

namespace uri1006 {
    class Program {
        static void Main(string[] args) {

            double A, B, C, media;
            Console.WriteLine("Informe o primeiro valor: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o segundo valor: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o terceiro valor: ");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o primeiro valor: ");
            media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;

            Console.WriteLine("O valor da média é: " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}