/*
 * Zadanie 11
 * Napisz program, w którym podaj się dwie liczby całkowite dodatnie. Następnie wybiera 
 * operację arytmetyczną, a program wyświetla jej wynik. W programie użyj instrukcji switch 
 * oraz typ char.
 */
namespace Zadanie11;

class Program
{
    static void Main(string[] args)
    {
        double a, b;
        char operacja;
        Console.Write("Podaj pierwszą liczbę: ");
        a = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Podaj drugą liczbę: ");
        b = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Podaj znak operacji (+ - / *): ");
        operacja = char.Parse(Console.ReadLine() ?? string.Empty);
        switch (operacja)
        {
            case '+':
                Console.WriteLine($"{a}+{b}={a + b}");
                break;
            case '-':
                Console.WriteLine($"{a}-{b}={a - b}");
                break;
            case '*':
                Console.WriteLine($"{a}*{b}={a * b}");
                break;
            case '/':
                Console.WriteLine( b != 0 
                    ? $"{a}/{b}={a / b}"
                    : "Nie można dzielić przez 0");
                break;
            default:
                Console.WriteLine("Nieprawidłowy znak");
                break;
        }
    }
}