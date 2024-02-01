//Rzucanie Wyjątków
using System;

class Program
{
    static void Main()
    {
        try
        {
            RzucWyjatek();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Wyjątek: " + e.Message);
        }
    }

    static void RzucWyjatek()
    {
        throw new InvalidOperationException("To jest błąd operacji.");
    }
}
