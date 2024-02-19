using System;

namespace uri1153 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe um valor para saber o seu fatorial: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}