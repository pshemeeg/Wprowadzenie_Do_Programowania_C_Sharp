/*
 * Zadanie 9
 * Podaj 3 różne liczby i wyświetl środkową (tzn. nie najmniejszą ani nie największą). 
 * UWAGA! Jeżeli liczby nie będą różne, wypisz jakiś komunikat i zakończ program. 
 */
namespace Zadanie9;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;
        Console.Write("Podaj pierwszą liczbę: ");
        a = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Podaj drugą liczbę: ");
        b = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Podaj trzecią liczbę: ");
        c = double.Parse(Console.ReadLine() ?? string.Empty);
        if(a == b || b == c || c == a)
            Console.WriteLine("Liczby muszą być różne!");
        else if((a > b && a < c) || (a < b && a > c))
            Console.WriteLine($"środkowa liczba to {a}.");
        else if((b < a && b > c) || (b > a && b < c))
            Console.WriteLine($"środkowa liczba to {b}.");
        else
            Console.WriteLine($"środkowa liczba to {c}.");
    }
}