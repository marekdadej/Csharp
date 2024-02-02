public class Kontakt
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string NumerTelefonu { get; set; }

    public Kontakt(string imie, string nazwisko, string numerTelefonu)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        NumerTelefonu = numerTelefonu;
    }

    public override string ToString()
    {
        return $"{Imie} {Nazwisko}, tel: {NumerTelefonu}";
    }
}
