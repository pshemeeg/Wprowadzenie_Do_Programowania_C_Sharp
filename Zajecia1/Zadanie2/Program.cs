/*
 * Zadanie 1.2
 * Napisz program, który oblicza średnią arytmetyczną dwóch liczb.
 */

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Podaj pierwszą liczbę");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Średnia arytmetyczna tych liczb wynosi: " + (a + b) / 2);
        }
    }
}
