using System;

namespace uri1004 {
    class Program {
        static void Main(string[] args) {

            int x, y, prod;
            Console.WriteLine("Informe o primeiro valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            y = int.Parse(Console.ReadLine());
            prod = x * y;
            Console.WriteLine("PROD = " + prod);
        }
    }
}