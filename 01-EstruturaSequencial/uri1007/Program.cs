using System;

namespace uri1007 {
    class Program {
        static void Main(string[] args) {

            int A, B, C, D, dif;
            Console.WriteLine("Informe o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");            
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor: ");            
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o quarto valor: ");            
            D = int.Parse(Console.ReadLine());


            dif = A * B - C * D;

            Console.WriteLine("A diferença entre os valores é: " + dif);
        }
    }
}