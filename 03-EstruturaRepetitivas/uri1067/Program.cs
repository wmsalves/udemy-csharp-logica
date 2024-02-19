namespace uri1067;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um valor para X: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
