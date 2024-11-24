using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab =
            {
                {3,8,0,2,6},
                {1,3,5,7,3},
                {1,2,3,4,5}
            };
            for (int w = 0; w < 3; w++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write("{0} ", tab[w, k]);
                }
                Console.WriteLine();

            }
            Console.WriteLine("\nTranspozycja\n");
            for (int w = 0; w < 5; w++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("{0} ", tab[k, w]);
                }
                Console.WriteLine();
            }
        }
    }
}
