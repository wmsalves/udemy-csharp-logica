namespace uri1075;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um valor inteiro: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numeros entre 1 e 1000 que dividos por {n} dão resto igual a 2: ");
        for (int i = 1; i <= 10000; i++)
        {
            if (i % n == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
