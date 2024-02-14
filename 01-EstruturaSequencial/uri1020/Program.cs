using System;

namespace uri1020 {
    class Program {
        static void Main(string[] args) {
            int N, anos, meses, dias, resto;

            Console.WriteLine("Informe sua idade em dias: ");
            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            resto = N % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}