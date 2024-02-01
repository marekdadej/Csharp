//Metoda z Wartościami Domyślnymi Parametrów
using System;

class Program
{
    static void Main()
    {
        PowiedzCos("Cześć");
        PowiedzCos(); // używa domyślnej wartości parametru
    }

    static void PowiedzCos(string wiadomosc = "Witaj, świecie!")
    {
        Console.WriteLine(wiadomosc);
    }
}
