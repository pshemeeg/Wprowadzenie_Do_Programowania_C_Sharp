using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] tab = { 31,23,255,2,54,37};
            byte min = tab[0];
            foreach (byte num in tab)
            {
                if (num<min)
                {
                    min = num;
                }
            }
            Console.WriteLine("Najmniejszy element {0} znajduje się na pozycji {1}",min, Array.IndexOf(tab, min));
        }
    }
}
