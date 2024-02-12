using System;
using System.Globalization;

namespace uri1008 {
    class Program {
        static void Main(string[] args) {

            int numero, horas;
            double valorHora, salario;
            Console.WriteLine("Informe o seu número: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor recebido por hora trabalhada: s");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("Numero: " + numero);
            Console.WriteLine("Salário: " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}