//Hermetyzacja
using System;

class KontoBankowe
{
    private double saldo;

    public KontoBankowe(double saldoPoczatkowe)
    {
        saldo = saldoPoczatkowe;
    }

    public void Wplac(double kwota)
    {
        saldo += kwota;
    }

    public void Wyplac(double kwota)
    {
        if (saldo >= kwota)
        {
            saldo -= kwota;
        }
        else
        {
            Console.WriteLine("Niewystarczające środki na koncie.");
        }
    }

    public double PokazSaldo()
    {
        return saldo;
    }
}

class Program
{
    static void Main()
    {
        KontoBankowe konto = new KontoBankowe(1000);
        konto.Wplac(500);
        konto.Wyplac(200);
        Console.WriteLine("Saldo: " + konto.PokazSaldo());
    }
}
