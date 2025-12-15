using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine( "To jest cwiczenie 1" );

        Zwierze[] zwierzeta = new Zwierze[4];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("\nZwierze nr " + ( i + 1 ) );

            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj typ (Pies/Kot/Krowa): ");
            string typ = Console.ReadLine();

            int iloscNog;
            while (true)
            {
                Console.Write("Podaj ilosc nog: ");
                if (int.TryParse(Console.ReadLine(), out iloscNog))
                    break;

                Console.WriteLine("To nie jest liczba, sprobuj jeszcze raz.");
            }

            zwierzeta[i] = new Zwierze(imie, typ, iloscNog);
        }

        zwierzeta[3] = new Zwierze(zwierzeta[0]);

        Console.Write("\nPodaj nowe imie dla klona: ");
        string noweImie = Console.ReadLine();
        zwierzeta[3].Imie = noweImie;   



        Console.WriteLine("\n--- INFORMACJE O ZWIERZETACH ---");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("\nZwierze nr " + (i + 1));
            Console.WriteLine("Imie: " + zwierzeta[i].Imie);            
            Console.WriteLine("Typ: " + zwierzeta[i].GetTyp());
            Console.WriteLine("Ilosc nog: " + zwierzeta[i].GetIloscNog());
            zwierzeta[i].DajGlos();
        }

        Console.WriteLine("\nIlosc utworzonych zwierzat: " + Zwierze.GetIloscZwierzat());
    }
}

public class Zwierze
{
    // Info
    private string imie;    
    private string typ;
    private int iloscNog;

    private static int iloscZwierzat = 0;

    public string Imie
    {
        get { return imie; }
        set { imie = value; }
    }

    // Gettery 
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

    // Construktory
    public Zwierze()
    {
        imie = "Rex";
        typ = "Pies";
        iloscNog = 4;
        iloscZwierzat++;
    }

    public Zwierze( string imie, string typ, int iloscNog )
    {
        this.imie = imie;
        this.typ = typ;
        this.iloscNog = iloscNog;
        iloscZwierzat++;
    }

    public Zwierze( Zwierze inne )
    {
        this.imie = inne.imie;
        this.typ = inne.typ;
        this.iloscNog = inne.iloscNog;
        iloscZwierzat++;
    }

    public void DajGlos()
    {
        if ( typ == "Pies" )
        {
            Console.WriteLine( "Hau Hau" );
        }
        else if ( typ == "Kot" )
        {
            Console.WriteLine( "Miau Miau" );
        }
        else if ( typ == "Krowa" )
        {
            Console.WriteLine( "Muu Muu" );
        }
        else
        {
            Console.WriteLine( "Nieznany dzwiek" );
        }
    }
}
