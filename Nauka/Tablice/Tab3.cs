//Tablica Tablic (Jagged Array)
using System;

class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        jaggedArray[1] = new int[2] { 5, 6 };
        jaggedArray[2] = new int[3] { 7, 8, 9 };

        foreach (int[] tablica in jaggedArray)
        {
            foreach (int liczba in tablica)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();
        }
    }
}
