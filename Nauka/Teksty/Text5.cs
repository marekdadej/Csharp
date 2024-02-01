//Czytanie i Wypisywanie Danych Użytkownika
using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj swoje imię: ");
        string imie = Console.ReadLine();
        Console.WriteLine("Witaj, " + imie + "!");
    }
}
