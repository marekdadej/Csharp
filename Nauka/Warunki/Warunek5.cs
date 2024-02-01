//Instrukcje Warunkowe Zagnieżdżone
using System;

class Program
{
    static void Main()
    {
        int liczba = 15;

        if (liczba > 10)
        {
            if (liczba % 2 == 0)
            {
                Console.WriteLine("Liczba jest większa od 10 i parzysta.");
            }
            else
            {
                Console.WriteLine("Liczba jest większa od 10 i nieparzysta.");
            }
        }
        else
        {
            Console.WriteLine("Liczba jest mniejsza lub równa 10.");
        }
    }
}
