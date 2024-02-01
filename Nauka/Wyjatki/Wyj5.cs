//Użycie Bloku catch bez Specyfikacji Typu Wyjątku
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Kod, który może spowodować dowolny wyjątek
        }
        catch
        {
            Console.WriteLine("Wystąpił jakiś wyjątek.");
        }
    }
}
