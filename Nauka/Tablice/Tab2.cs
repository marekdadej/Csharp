//Tablica Wielowymiarowa
using System;

class Program
{
    static void Main()
    {
        int[,] macierz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < macierz.GetLength(0); i++)
        {
            for (int j = 0; j < macierz.GetLength(1); j++)
            {
                Console.Write(macierz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
