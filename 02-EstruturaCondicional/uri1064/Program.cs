using System;
using System.Globalization;

namespace uri1064
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o segundo valor: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o terceiro valor: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o quarto valor: ");
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o quinto valor: ");
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o sexto valor: ");
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cont = 0;
            double soma = 0.0;
            if (a > 0.0)
            {
                cont = cont + 1;
                soma = soma + a;
            }
            if (b > 0.0)
            {
                cont = cont + 1;
                soma = soma + b;
            }
            if (c > 0.0)
            {
                cont = cont + 1;
                soma = soma + c;
            }
            if (d > 0.0)
            {
                cont = cont + 1;
                soma = soma + d;
            }
            if (e > 0.0)
            {
                cont = cont + 1;
                soma = soma + e;
            }
            if (f > 0.0)
            {
                cont = cont + 1;
                soma = soma + f;
            }
            Console.WriteLine(cont + " valores positivos");

            double media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}