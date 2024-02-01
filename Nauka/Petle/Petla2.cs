//Pętla foreach
using System;

class Program
{
    static void Main()
    {
        string[] fruits = { "Jabłko", "Banana", "Mango" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine("Owoc: " + fruit);
        }
    }
}
