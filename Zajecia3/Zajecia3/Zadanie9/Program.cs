using System;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int i;
            Console.WriteLine("Podaj swoje imie i nazwisko: ");
            name = Console.ReadLine();
            i = name.IndexOf(' ');
            Console.WriteLine("Podaj drugie imie: ");
            name = name.Insert(i+1, Console.ReadLine() + " ");
            Console.WriteLine(name);
            name = name.Substring(i + 1);
            Console.WriteLine(name);
            i = name.IndexOf(' ');
            Console.WriteLine("{0} {1}", name[0], name[i+1]);


        }
    }
}
