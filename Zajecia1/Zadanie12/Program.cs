/*
 * Zadanie12
 * Dla liczby z przedziału 1 do 999 sprawdź, czy jest ona podzielna przez 3, stosując cechę 
 * podzielności liczby przez 3. Czecha to mówi, że liczba jest podzielna przez 3, jeżeli suma 
 * jej cyfr daje liczbę podzielną przez 3.
 */
namespace Zadanie12;

class Program
{
    static void Main(string[] args)
    {
        int liczba = 0, suma = 0;
        Console.Write("Podaj liczbę (od 1 do 999): ");
        liczba = int.Parse(Console.ReadLine() ?? string.Empty);
        if (liczba < 1 || liczba > 999)
            Console.WriteLine("Podano złą liczbę!");
        else
        {
            suma = liczba % 10 + liczba / 10 % 10 + liczba / 100 % 10;
            if (suma%3==0)
            {
                Console.WriteLine($"Liczba {liczba} jest podzielna przez 3!");
            }else
                Console.WriteLine($"Liczba {liczba} nie jest podzielna przez 3!");

        }
    }
}
