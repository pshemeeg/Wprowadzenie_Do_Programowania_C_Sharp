/*
 * Zadanie6
 * Napisz program który oblicza wyrażenie:   {[(6,2:0,31-5/9*0,9)*0,2+0,15]:0,02}^3.
 */
namespace Zadanie6;

class Program
{
    static void Main(string[] args)
    {
        double wynik = ((6.2 / 0.31 - 5d / 9 * 0.9) * 0.2 + 0.15) / 0.02;
        Console.WriteLine(Math.Pow(wynik, 3));
    }
}