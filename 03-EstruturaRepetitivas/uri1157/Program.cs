using System;

namespace uri1157
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe um valor inteiro N para que seja informado seus divisores: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}