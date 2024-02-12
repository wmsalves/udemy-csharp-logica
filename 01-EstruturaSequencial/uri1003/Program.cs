using System;

namespace uri1003
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, soma;
            Console.WriteLine("Informe o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA: " + soma);
        }
    }
}