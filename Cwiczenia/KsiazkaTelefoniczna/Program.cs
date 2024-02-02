using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Kontakt> ksiazkaAdresowa = new List<Kontakt>();

    static void Main(string[] args)
    {
        bool dziala = true;
        while (dziala)
        {
            Console.WriteLine("\n1. Dodaj kontakt");
            Console.WriteLine("2. Usuń kontakt");
            Console.WriteLine("3. Wyświetl wszystkie kontakty");
            Console.WriteLine("4. Wyszukaj kontakt");
            Console.WriteLine("5. Zakończ");

            Console.Write("\nWybierz opcję: ");
            string opcja = Console.ReadLine();

            switch (opcja)
            {
                case "1":
                    DodajKontakt();
                    break;
                case "2":
                    UsunKontakt();
                    break;
                case "3":
                    WyswietlKontakty();
                    break;
                case "4":
                    WyszukajKontakt();
                    break;
                case "5":
                    dziala = false;
                    break;
                default:
                    Console.WriteLine("Nieznana opcja.");
                    break;
            }
        }
    }

    static void DodajKontakt()
    {
        Console.Write("Imię: ");
        string imie = Console.ReadLine();

        Console.Write("Nazwisko: ");
        string nazwisko = Console.ReadLine();

        Console.Write("Numer telefonu: ");
        string numerTelefonu = Console.ReadLine();

        ksiazkaAdresowa.Add(new Kontakt(imie, nazwisko, numerTelefonu));
        Console.WriteLine("Kontakt dodany.");
    }

    static void UsunKontakt()
    {
        Console.Write("Wprowadź nazwisko kontaktu do usunięcia: ");
        string nazwisko = Console.ReadLine();

        var doUsuniecia = ksiazkaAdresowa.FirstOrDefault(k => k.Nazwisko.Equals(nazwisko, StringComparison.OrdinalIgnoreCase));
        if (doUsuniecia != null)
        {
            ksiazkaAdresowa.Remove(doUsuniecia);
            Console.WriteLine("Kontakt usunięty.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono kontaktu.");
        }
    }

    static void WyswietlKontakty()
    {
        foreach (var kontakt in ksiazkaAdresowa)
        {
            Console.WriteLine(kontakt);
        }
    }

    static void WyszukajKontakt()
    {
        Console.Write("Wprowadź nazwisko do wyszukania: ");
        string nazwisko = Console.ReadLine();

        var wyniki = ksiazkaAdresowa.Where(k => k.Nazwisko.Equals(nazwisko, StringComparison.OrdinalIgnoreCase));

        if (wyniki.Any())
        {
            foreach (var kontakt in wyniki)
            {
                Console.WriteLine(kontakt);
            }
        }
        else
        {
            Console.WriteLine("Nie znaleziono kontaktów.");
        }
    }
}
