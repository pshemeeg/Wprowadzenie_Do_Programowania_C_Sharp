using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[20];
            int sum = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i + 1;
                sum += i + 1;
            }
            Console.WriteLine("Średnia tych liczb wyniosi {0}", (double)sum/tab.Length);
        }
    }
}
