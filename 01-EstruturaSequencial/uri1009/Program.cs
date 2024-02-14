using System;
using System.Globalization;

namespace uri1009;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        double salarioFixo, totalVendas, salarioTotal;

        Console.WriteLine("Informe o seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe o seu salario fixo: ");
        salarioFixo = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o total de venda: ");
        totalVendas = double.Parse(Console.ReadLine());
        
        salarioTotal = totalVendas * 0.15 + salarioFixo;
        Console.WriteLine("O salario total é: " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
    }
}
