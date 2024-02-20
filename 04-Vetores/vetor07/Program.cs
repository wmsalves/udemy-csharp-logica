using System;
using System.Globalization;

namespace vetor7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres. Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados, considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new String[N];
            double[] notasSemestre1 = new double[N];
            double[] notasSemestre2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                notasSemestre1[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                notasSemestre2[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++)
            {
                double media = (notasSemestre1[i] + notasSemestre2[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}