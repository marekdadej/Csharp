//Klasa z Właściwościami i Metodami
using System;

class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public void PrzedstawSie()
    {
        Console.WriteLine("Witaj, nazywam się " + Imie + " " + Nazwisko);
    }
}

class Program
{
    static void Main()
    {
        Osoba osoba = new Osoba();
        osoba.Imie = "Jan";
        osoba.Nazwisko = "Kowalski";
        osoba.PrzedstawSie();
    }
}
