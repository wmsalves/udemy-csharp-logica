using System;
using System.Globalization;

namespace uri1005 {
    class Program {
        static void Main(string[] args) {

            double A, B, media;
            
            Console.Write("Informe o primeiro valor: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o primeiro valor: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("O valor da media é: " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}