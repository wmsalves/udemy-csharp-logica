using System;
using System.Globalization;

namespace vetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos elementos. Depois mostrar todos os elementos do vetor que estejam abaixo da média.");
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }
            double media = soma / N;
            Console.WriteLine("MEDIA = " + media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}