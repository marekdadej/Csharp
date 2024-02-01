//Przeciążenie Metod
using System;

class Program
{
    static void Main()
    {
        Wypisz("Witaj");
        Wypisz(100);
    }

    static void Wypisz(string wiadomosc)
    {
        Console.WriteLine("String: " + wiadomosc);
    }

    static void Wypisz(int liczba)
    {
        Console.WriteLine("Int: " + liczba);
    }
}
