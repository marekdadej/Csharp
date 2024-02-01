//Metoda Rekurencyjna
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Fibonacci 5: " + Fibonacci(5));
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
