//Konwersja Typów
using System;

class Program
{
    static void Main()
    {
        int liczba = 10;
        double liczbaDouble = liczba;  // Niejawna konwersja

        double liczbaZmiennoprzecinkowa = 9.8;
        int zaokraglonaLiczba = (int)liczbaZmiennoprzecinkowa;  // Jawna konwersja

        Console.WriteLine(liczbaDouble);
        Console.WriteLine(zaokraglonaLiczba);
    }
}
