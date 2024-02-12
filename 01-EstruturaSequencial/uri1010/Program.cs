using System;
using System.Globalization;

namespace uri1010 {
    class Program {
        static void Main(string[] args) {

            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            Console.WriteLine("Informe o código de peça 1: ");
            cod1 = int.Parse(valores[0]);
            Console.WriteLine("Informe o numero de peças 1: ");
            qte1 = int.Parse(valores[1]);
            Console.WriteLine("Informe o valor de uma peça 1: ");
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            Console.WriteLine("Informe o código de peça 2: ");
            cod2 = int.Parse(valores[0]);
            Console.WriteLine("Informe o numero de peças 2: ");
            qte2 = int.Parse(valores[1]);
            Console.WriteLine("Informe o valor de uma peça 3: ");
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("O valor total a se pagar é: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}