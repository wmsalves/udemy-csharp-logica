using System;
using System.Globalization;

namespace matriz6
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double[,] mat = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
                }
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > 0.0)
                    {
                        soma = soma + mat[i, j];
                    }
                }
            }
            Console.WriteLine("Soma dos Positivos: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            Console.Write("Linha Escolhida: ");
            for (int j = 0; j < N; j++)
            {
                Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("Coluna Escolhida ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("Diagonal Principal: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0.0)
                    {
                        mat[i, j] = mat[i, j] * mat[i, j];
                    }
                }
            }
            Console.WriteLine("Matriz Alterada:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}