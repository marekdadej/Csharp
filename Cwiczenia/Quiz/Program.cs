using System;
using System.IO;
using System.Linq;

class Program
{
    static string[] tresc = new string[20];
    static string[] odpA = new string[20], odpB = new string[20], odpC = new string[20], odpD = new string[20];
    static string[] poprawna = new string[20];
    static string odpowiedz;
    static int punkty = 0;

    static void Main(string[] args)
    {
        int nrPytania = 0;

        try
        {
            using (StreamReader plik = new StreamReader("quiz.txt"))
            {
                while (!plik.EndOfStream && nrPytania < tresc.Length)
                {
                    tresc[nrPytania] = plik.ReadLine();
                    odpA[nrPytania] = plik.ReadLine();
                    odpB[nrPytania] = plik.ReadLine();
                    odpC[nrPytania] = plik.ReadLine();
                    odpD[nrPytania] = plik.ReadLine();
                    poprawna[nrPytania] = plik.ReadLine().ToLower();
                    nrPytania++;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("\n\tNie udalo sie otworzyc pliku!");
            return;
        }

        for (int i = 0; i < nrPytania; i++)
        {
            Console.WriteLine("\n" + tresc[i]);
            Console.WriteLine("\n\tA. " + odpA[i]);
            Console.WriteLine("\n\tB. " + odpB[i]);
            Console.WriteLine("\n\tC. " + odpC[i]);
            Console.WriteLine("\n\tD. " + odpD[i]);

            Console.Write("\n\tTwoja odpowiedz: ");
            odpowiedz = Console.ReadLine().ToLower();

            if (odpowiedz == poprawna[i])
            {
                Console.WriteLine("\n\tDobrze! Zdobywasz punkt!");
                punkty++;
            }
            else
            {
                Console.WriteLine("\n\tZle! Brak punktu! Poprawna odpowiedz: " + poprawna[i]);
            }
        }

        Console.WriteLine("\n\tKoniec quizu! Zdobyte punkty: " + punkty);
    }
}
