using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Para segundos => 10s = 10 segundos");
            Console.WriteLine("Para minutos => 1m = 1 minuto");
            Console.WriteLine("9 - Sair");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); //ToLower para transformar toda a string em minuscula
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //Substring pega um determinado intervalo de char na string | data.Length - 1 pega o ultimo char
            int time = int.Parse(data.Substring(0, data.Length - 1)); //pega todos os char da string menos o ultimo
            int multiplier = 1; // 1 = segundos

            if (type == 'm')
                multiplier = 60; // se for selecionado minutos entao multiplier vale 60

            if (time == 9)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(1000);
            Menu();
        }
    }
}