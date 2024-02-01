//Deklaracja i Inicjalizacja Tablicy
using System;

class Program
{
    static void Main()
    {
        string[] kolory = new string[3];
        kolory[0] = "Czerwony";
        kolory[1] = "Zielony";
        kolory[2] = "Niebieski";

        foreach (string kolor in kolory)
        {
            Console.WriteLine(kolor);
        }
    }
}
