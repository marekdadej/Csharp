//Enum
using System;

class Program
{
    enum DniTygodnia { Poniedzialek, Wtorek, Sroda, Czwartek, Piatek, Sobota, Niedziela }

    static void Main()
    {
        DniTygodnia dzis = DniTygodnia.Poniedzialek;

        Console.WriteLine(dzis);
    }
}
