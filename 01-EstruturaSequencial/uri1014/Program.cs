using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {

            int X;
            double Y, kml;
            Console.WriteLine("Informe o valor total percorrido em Km: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o total de combustivel gasto: ");
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kml = (double)X / Y;

            Console.WriteLine("O consumo médio do veículo é: " + kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}