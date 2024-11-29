/*
 * Zadanie 7
 * Napisz program sprawdzający, która liczba jest większa: pierwiastek z dwóch do potęgi 
 * pierwiastek z trzech czy pierwiastek z trzech do potęgi pierwiastek z dwóch. Uwaga! W 
 * rozwiązaniu użyj metod Pow() i Sqrt().
 */
namespace Zadanie7;

class Program
{
    static void Main(string[] args)
    {
        double a, b;
        a = double.Pow(double.Sqrt(2), double.Sqrt(3));
        b = double.Pow(double.Sqrt(3), double.Sqrt(2));
        Console.WriteLine(a > b
            ? "pierwiastek z dwóch do potęgi pierwiastek z trzech"
            : "pierwiastek z trzech do potęgi pierwiastek z dwóch");
    }
}