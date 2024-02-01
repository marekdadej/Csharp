//Dziedziczenie
using System;

class Pojazd
{
    public string Marka { get; set; }

    public void UruchomSilnik()
    {
        Console.WriteLine("Silnik uruchomiony!");
    }
}

class Samochod : Pojazd
{
    public int LiczbaKol { get; set; }
}

class Program
{
    static void Main()
    {
        Samochod samochod = new Samochod();
        samochod.Marka = "Toyota";
        samochod.LiczbaKol = 4;
        samochod.UruchomSilnik();
        Console.WriteLine($"Marka: {samochod.Marka}, Liczba kół: {samochod.LiczbaKol}");
    }
}
