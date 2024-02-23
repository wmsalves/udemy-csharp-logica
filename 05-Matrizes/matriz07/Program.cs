using System;

namespace matriz7
{
    class Program
    {
        static void Main(string[] args)
        {

            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());

            fila = fila - 1;

            int ultimoDaFila = mat[fila, N - 1];

            for (int j = N - 1; j > 0; j--)
            {
                mat[fila, j] = mat[fila, j - 1];
            }

            mat[fila, 0] = ultimoDaFila;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}