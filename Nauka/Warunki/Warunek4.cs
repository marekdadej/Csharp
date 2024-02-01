//Instrukcja switch
using System;

class Program
{
    static void Main()
    {
        string kolor = "zielony";

        switch (kolor)
        {
            case "czerwony":
                Console.WriteLine("Wybrano czerwony.");
                break;
            case "zielony":
                Console.WriteLine("Wybrano zielony.");
                break;
            case "niebieski":
                Console.WriteLine("Wybrano niebieski.");
                break;
            default:
                Console.WriteLine("Inny kolor.");
                break;
        }
    }
}
