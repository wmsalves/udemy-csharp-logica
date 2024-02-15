using System;

namespace uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o quarto valor ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o quinto valor ");
            int e = int.Parse(Console.ReadLine());

            int cont = 0;
            if (a % 2 == 0)
            {
                cont = cont + 1;
            }
            if (b % 2 == 0)
            {
                cont = cont + 1;
            }
            if (c % 2 == 0)
            {
                cont = cont + 1;
            }
            if (d % 2 == 0)
            {
                cont = cont + 1;
            }
            if (e % 2 == 0)
            {
                cont = cont + 1;
            }
            Console.WriteLine(cont + " valores pares");
        }
    }
}