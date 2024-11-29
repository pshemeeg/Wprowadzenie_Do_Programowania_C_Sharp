/*
 * Zadanie 8
 * Napisz program sprawdzający, czy podany rok jest rokiem przestępny, czy nim nie jest. 
 * UWAGA! Rok jest przestępny, jeśli spełnia jeden z następujących warunków: 
 * - jest podzielny przez 4, ale nie jest podzielny przez 100 
 * - jest podzielny przez 400
 */
namespace Zadanie8;

class Program
{
    static void Main(string[] args)
    {
        int rok;
        Console.Write("Podaj rok: ");
        rok = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Console.WriteLine((rok%4==0 && rok%100!=0) || (rok%400==0) 
            ?"ten rok jest przestępny!"
            :"ten rok nie jest przestępny!"
            );
    }
}