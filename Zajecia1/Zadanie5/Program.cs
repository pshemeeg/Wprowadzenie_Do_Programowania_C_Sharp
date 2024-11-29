/*
 * Zadanie5
 * Napisz program, który oblicza trójmian kwadratowy.
 */
namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Podaj a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2d * a);
                x2 = (-b + Math.Sqrt(delta)) / (2d * a);
                Console.WriteLine("Trójmian ma dwa rozwiązanie {0} oraz {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = -b / (2d * a);
                Console.WriteLine("Trójmian ma jedno rozwiązanie {0} ", x1);
            }
            else
                Console.WriteLine("Trójmian nie ma rozwiązań");
        }
    }
}
