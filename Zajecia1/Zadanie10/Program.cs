/*
 * Zadanie 10
 * Podaj trzy różne liczby i wyświetl je posortowane od najmniejszej do największej. 
 * UWAGA! W kodzie może wystąpić tylko raz instrukcja Console.WriteLine(), np.:  
 * Console.WriteLine(a + ” ” + b  +  ” ” + ” ” + c).
 */
namespace Zadanie10;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;
        string wynik = "";
        Console.Write("Podaj pierwszą liczbę: ");
        a = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Podaj drugą liczbę: ");
        b = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Podaj trzecią liczbę: ");
        c = double.Parse(Console.ReadLine() ?? string.Empty);
        if (a > b)
        {
            if (a > c)
            {
                wynik = b > c ? $"{c},  {b},  {a}" : $"{b},  {c},  {a}";
            }
            else
            {
                wynik = $"{b},  {a},  {c}";
            }
        }
        else
        {
            if (b > c)
            {
                wynik = a > c ? $"{c},  {a},  {b}" : $"{a},  {c},  {b}";
            }
            else
            {
                wynik = $"{a},  {b},  {c}";
            }
        }
        Console.WriteLine(wynik);
    }
}