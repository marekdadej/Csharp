//Obsługa Wielu Wyjątków
using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 5;
            int y = 0;
            int wynik = x / y; // Spowoduje to wyjątek DivideByZeroException
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Nie można dzielić przez zero: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Wystąpił inny wyjątek: " + e.Message);
        }
    }
}
