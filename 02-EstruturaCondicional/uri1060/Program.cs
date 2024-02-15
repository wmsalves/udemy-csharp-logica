using System;
using System.Globalization;

namespace uri1060 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o primeiro valor");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o segundo valor");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o terceiro valor");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o quarto valor");
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o quinto valor");
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o sexto valor");
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cont = 0;
            if (a > 0.0) {
                cont = cont + 1;
            }
            if (b > 0.0) {
                cont = cont + 1;
            }
            if (c > 0.0) {
                cont = cont + 1;
            }
            if (d > 0.0) {
                cont = cont + 1;
            }
            if (e > 0.0) {
                cont = cont + 1;
            }
            if (f > 0.0) {
                cont = cont + 1;
            }
            Console.WriteLine(cont + " valores positivos");
        }
    }
}