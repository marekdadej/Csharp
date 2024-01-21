using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, wynik;
            char oper;
            string odp;

            do
            {
                Console.WriteLine("\n\tProgram wykonuje dzialanie na dwoch liczbach:");

                Console.Write("\n\ta: ");
                a = float.Parse(Console.ReadLine());

                do
                {
                    Console.Write("\n\tPodaj operator (+, -, *, /): ");
                    oper = Convert.ToChar(Console.ReadLine());
                } while (oper != '+' && oper != '-' && oper != '*' && oper != '/');

                while (true)
                {
                    Console.Write("\n\tb: ");
                    b = float.Parse(Console.ReadLine());

                    if (b == 0 && (oper == '/' || oper == ':'))
                    {
                        Console.WriteLine("\n\tNie dzieli sie przez 0!");
                    }
                    else
                    {
                        break;
                    }
                }

                wynik = Dzialanie(a, b, oper);
                Console.WriteLine($"\n\tWynik = {wynik}");

                Console.Write("\n\tCzy chcesz kontynuowac? (T/N): ");
                odp = Console.ReadLine();
            } while (odp.Equals("T", StringComparison.OrdinalIgnoreCase));
        }

        static float Dzialanie(float a, float b, char oper)
        {
            switch (oper)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                case ':':
                    return a / b;
                default:
                    throw new ArgumentException("Nieprawidlowy operator");
            }
        }
    }
}
