/*
 * Zadanie 3
 * Napisz program, który czyta trzy liczby (wszystkie różne) i wyświetla największą z nich. 
 * W rozwiązaniu zastosuj zagnieżdżone instrukcje if z klauzulą else. 
 */
namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj pierwszą liczbę: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(c);
            }
            else
            {
                if (b>c)
                    Console.WriteLine(b);
                else
                    Console.WriteLine(c);
            }
        }
    }
}
