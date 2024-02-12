namespace uri1001;

class Program
{
    static void Main(string[] args)
    {
            int A, B, X;
            Console.WriteLine("Insira o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            B = int.Parse(Console.ReadLine());
            X = A + B;
            Console.WriteLine("O resultado é: " + X);
    }
};
