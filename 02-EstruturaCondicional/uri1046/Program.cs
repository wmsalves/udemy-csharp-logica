using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a hora inicial e hora final do jogo: ");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo teve a duração de: " + duracao + " hora(s)");
        }
    }
}