using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę wpisz swoje imię:");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name + "!");
        }
    }
}
