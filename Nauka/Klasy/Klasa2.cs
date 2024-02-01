//Konstruktor
using System;

class Punkt
{
    public int X { get; }
    public int Y { get; }

    public Punkt(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void WypiszPunkt()
    {
        Console.WriteLine($"Punkt ({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        Punkt punkt = new Punkt(5, 10);
        punkt.WypiszPunkt();
    }
}
