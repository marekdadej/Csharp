 //Metoda Zwracająca Wartość
using System;

class Program
{
    static void Main()
    {
        int suma = Dodaj(5, 3);
        Console.WriteLine("Suma: " + suma);
    }

    static  int Dodaj(int a, int b)
    {
        return a +b; 
    }
}