//Przekazywanie Tablicy do Metody
using System;

class Program
{
    static void Main()
    {
        int[] liczby = { 1, 2, 3, 4, 5 };
        WypiszTablice(liczby);
    }

    static void WypiszTablice(int[] tablica)
    {
        foreach (int liczba in tablica)
        {
            Console.WriteLine(liczba);
        }
    }
}
