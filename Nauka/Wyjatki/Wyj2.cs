//Użycie Bloku finally
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Jakiś kod, który może spowodować wyjątek
        }
        catch (Exception e)
        {
            Console.WriteLine("Wyjątek: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Ten kod wykonuje się zawsze.");
        }
    }
}
