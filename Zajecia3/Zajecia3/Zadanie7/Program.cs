using System;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            Console.WriteLine("Wpisz zdanie: ");
            tekst = Console.ReadLine();
            for (int i = 0; i < tekst.Length-1; i++)
            {
                if ((tekst[i] == ' ') && (tekst[i + 1] == ' '))
                    continue;
                Console.Write(tekst[i]);
            }
            Console.Write(tekst[tekst.Length - 1]);
        }
    }
}
