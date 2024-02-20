using System;

namespace vetor6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome da pessoa mais velha.");
            int N = int.Parse(Console.ReadLine());

            String[] nomes = new String[N];
            int[] idades = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);
            }

            int maiorIdade = idades[0];
            int posicaoMaiorIdade = 0;

            for (int i = 1; i < N; i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    posicaoMaiorIdade = i;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);
        }
    }
}