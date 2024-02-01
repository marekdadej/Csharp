//Kopiowanie Tablic
using System;

class Program
{
    static void Main()
    {
        int[] oryginalna = { 1, 2, 3, 4, 5 };
        int[] kopia = new int[5];

        Array.Copy(oryginalna, kopia, oryginalna.Length);

        foreach (int liczba in kopia)
        {
            Console.WriteLine(liczba);
        }
    }
}
