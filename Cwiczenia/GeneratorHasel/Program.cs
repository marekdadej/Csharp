using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj długość hasła: ");
        int dlugosc = int.Parse(Console.ReadLine());

        Console.Write("Użyć cyfr? (t/n): ");
        bool uzyjCyfr = Console.ReadLine().ToLower() == "t";

        Console.Write("Użyć znaków specjalnych? (t/n): ");
        bool uzyjZnakowSpecjalnych = Console.ReadLine().ToLower() == "t";

        string haslo = GenerujHaslo(dlugosc, uzyjCyfr, uzyjZnakowSpecjalnych);
        Console.WriteLine($"Wygenerowane hasło: {haslo}");
    }

    static string GenerujHaslo(int dlugosc, bool uzyjCyfr, bool uzyjZnakowSpecjalnych)
    {
        const string litery = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string cyfry = "0123456789";
        const string znakiSpecjalne = "!@#$%^&*_-";
        string dozwoloneZnaki = litery;

        if (uzyjCyfr) dozwoloneZnaki += cyfry;
        if (uzyjZnakowSpecjalnych) dozwoloneZnaki += znakiSpecjalne;

        StringBuilder haslo = new StringBuilder();
        Random rnd = new Random();
        for (int i = 0; i < dlugosc; i++)
        {
            int indeks = rnd.Next(dozwoloneZnaki.Length);
            haslo.Append(dozwoloneZnaki[indeks]);
        }

        return haslo.ToString();
    }
}
