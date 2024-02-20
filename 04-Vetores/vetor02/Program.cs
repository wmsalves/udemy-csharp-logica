using System;

namespace vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:\n- todos os números pares \n- a quantidade de números pares");
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();

            int quantidadeDePares = 0;
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    quantidadeDePares++;
                }
            }
            Console.WriteLine(quantidadeDePares);
        }
    }
}