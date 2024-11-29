/*
 * Zadanie 1.1
 * Napisz program, który prosi o padanie twego imienia, a następnie wypisuje tekst w rodzaju:
 *„Witaj Tomasz”. 
 */
namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.WriteLine("Podaj swoje imię: ");
            imie = Console.ReadLine();
            Console.WriteLine("Witaj " + imie+"!");
        }
    }
}
