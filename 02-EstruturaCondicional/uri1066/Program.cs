using System;

namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, pares, impares, positivos, negativos;

            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;
            Console.WriteLine("Informe o primeiro valor: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }
            Console.WriteLine("Informe o segundo valor: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }
            Console.WriteLine("Informe o terceiro valor: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }
            Console.WriteLine("Informe o quarto valor: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }
            Console.WriteLine("Informe o quinto valor: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");

            Console.ReadLine();
        }
    }
}