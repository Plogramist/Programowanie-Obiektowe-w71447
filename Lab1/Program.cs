using System;   

public class Program
{
    public static void Main()
    {
        Console.WriteLine("To jest cwiczenie 1");
    }
}


public class Zwierze
{
    // Info
    private string imie;
    private string typ;
    private int iloscNog;
    private static int iloscZwierzat = 0;

    // Metody

    public string GetImie()
    {
        return imie;
    }

    public string GetTyp()
    {
        return typ;
    }

    public int GetIloscNog()
    {
        return iloscNog;
    }

    public static int GetIloscZwierzat()
    {
        return iloscZwierzat;
    }

    public void SetImie(string NoweImie)
    {
        imie = NoweImie;
    }

    // Construktory

    public Zwierze()
    {
        imie = "Rex";
        typ = "Pies";
        iloscNog = 4;
        iloscZwierzat++;
    }

    public Zwierze(string imie, string typ, int iloscNog)
    {
        imie = imie;
        typ = typ;
        iloscNog = iloscNog;
        iloscZwierzat++;
    }

    public Zwierze(Zwierze inne)
    {
        this.imie = inne.imie;
        this.typ = inne.typ;
        this.iloscNog = inne.iloscNog;
        iloscZwierzat++;
    }

    public void DajGlos()
    {
        if (typ == "Pies")
        {
            Console.WriteLine("Hau Hau");
        }

        else if (typ == "Kot")
        {
            Console.WriteLine("Miau Miau");
        }

        else if (typ == "Krowa")
        {
            Console.WriteLine("Muu Muu");
        }

        else
        {
            Console.WriteLine("Nieznany dzwiek");
        }
    }
}