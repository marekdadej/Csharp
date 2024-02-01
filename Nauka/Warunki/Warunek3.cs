//Skrócona Instrukcja Warunkowa (? :)
using System;

class Program
{
    static void Main()
    {
        int temperatura = 20;

        string komunikat = temperatura > 15 ? "Ciepło" : "Zimno";
        Console.WriteLine(komunikat);
    }
}
