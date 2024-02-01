//Instrukcja else if
using System;

class Program
{
    static void Main()
    {
        int ocena = 85;

        if (ocena >= 90)
        {
            Console.WriteLine("Bardzo dobry");
        }
        else if (ocena >= 80)
        {
            Console.WriteLine("Dobry");
        }
        else if (ocena >= 70)
        {
            Console.WriteLine("Dostateczny");
        }
        else
        {
            Console.WriteLine("Niedostateczny");
        }
    }
}
