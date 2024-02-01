//Typy Strukturalne (Struct)
using System;

class Program
{
    struct Punkt
    {
        public int x;
        public int y;
    }

    static void Main()
    {
        Punkt punkt = new Punkt();
        punkt.x = 10;
        punkt.y = 20;

        Console.WriteLine($"x: {punkt.x}, y: {punkt.y}");
    }
}
