using System;

namespace uri1044
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe 2 valores para verificar se são multiplos entre si: ");
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}