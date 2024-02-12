using System;

namespace uri1016 {
    class Program {
        static void Main(string[] args) {

            int distancia, tempo;
            Console.WriteLine("Informe a distância percorrida em Km: ");
            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * 2;
            Console.WriteLine(tempo + " minutos");
        }
    }
}