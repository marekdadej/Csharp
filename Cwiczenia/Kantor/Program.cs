using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Dictionary<string, decimal> kursyWalut = new Dictionary<string, decimal>();

    static void Main(string[] args)
    {
        WczytajKursyWalut("kurs.txt");

        Console.WriteLine("Wprowadź kod waluty docelowej (np. USD):");
        string walutaDocelowa = Console.ReadLine().ToUpper();

        Console.WriteLine("Wprowadź kwotę w złotówkach do przeliczenia:");
        decimal kwota = Convert.ToDecimal(Console.ReadLine());

        try
        {
            decimal przeliczonaKwota = PrzeliczZPLNnaWalute(kwota, walutaDocelowa);
            Console.WriteLine($"{kwota} PLN = {przeliczonaKwota} {walutaDocelowa}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }

    static void WczytajKursyWalut(string sciezkaPliku)
    {
        string[] linie = File.ReadAllLines(sciezkaPliku);
        foreach (var linia in linie)
        {
            string[] elementy = linia.Split(' ');
            if (elementy.Length == 2 && decimal.TryParse(elementy[1], out decimal kurs))
            {
                kursyWalut[elementy[0]] = kurs;
            }
        }
    }

    static decimal PrzeliczZPLNnaWalute(decimal kwota, string walutaDocelowa)
    {
        if (!kursyWalut.ContainsKey(walutaDocelowa))
        {
            throw new Exception("Nie znaleziono waluty docelowej.");
        }

        decimal kursDocelowy = kursyWalut[walutaDocelowa];
        return kwota / kursDocelowy;
    }
}