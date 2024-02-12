using System;
using System.Globalization;

namespace uri1017 {
    class Program {
        static void Main(string[] args) {

            int tempo, velocidade, distancia;
            double litros;

            Console.WriteLine("Informe o tempo gasto em viagem: ");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a velocidade média durante a viagem: ");
            velocidade = int.Parse(Console.ReadLine());
            distancia = tempo * velocidade;
            litros = distancia / 12.0;
            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}