using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] tab = new int[5, 5];
            int sum = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = rand.Next(0, 9);
                }
            }
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if ((i==j)||(i+j == tab.GetLength(0)-1))
                    {
                        sum += tab[i, j];
                    }
                }
            }
            Console.WriteLine("Suma przekątnych tej tablicy wynosi: {0}", sum);
        }
    }
}
