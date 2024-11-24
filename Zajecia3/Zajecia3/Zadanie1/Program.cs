using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Podaj długość tablicy: ");
            n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj liczbę:");
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Zawartość tablicy");
            foreach (int number in tab)
            {
                Console.Write("{0}; ", number);
            }
        }
    }
}
