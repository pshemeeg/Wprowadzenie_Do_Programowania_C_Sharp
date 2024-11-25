/*
 * Zadanie 4
 * Napisz program, który czyta trzy liczby (wszystkie różne) i wyświetla największą z nich. 
 * W rozwiązaniu zastosuj instrukcje if z operatorem logicznym koniunkcji.
 */
namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            c = double.Parse(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine(a);
            }
            else if ((b > c))
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
        }
    }
}
