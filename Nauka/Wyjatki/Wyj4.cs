//Tworzenie Własnych Wyjątków
using System;

public class MojWyjatek : Exception
{
    public MojWyjatek(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            throw new MojWyjatek("To jest mój własny wyjątek.");
        }
        catch (MojWyjatek e)
        {
            Console.WriteLine("Mój wyjątek: " + e.Message);
        }
    }
}
