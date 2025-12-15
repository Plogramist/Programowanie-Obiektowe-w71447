using System;

// p1

class Zwierze
{
    protected string nazwa;

    public Zwierze(string nazwa)
    {
        this.nazwa = nazwa;
    }

    public virtual void DajGlos()
    {
        Console.WriteLine("...");
    }
}

class Pies : Zwierze
{
    public Pies(string nazwa) : base(nazwa) { }

    public override void DajGlos()
    {
        Console.WriteLine(nazwa + " robi woof woof!");
    }
}

class Kot : Zwierze
{
    public Kot(string nazwa) : base(nazwa) { }

    public override void DajGlos()
    {
        Console.WriteLine(nazwa + " robi miau miau!");
    }
}

class Waz : Zwierze
{
    public Waz(string nazwa) : base(nazwa) { }

    public override void DajGlos()
    {
        Console.WriteLine(nazwa + " robi ssssssss!");
    }
}

class Program
{
    static void PowiedzCos(Zwierze z)
    {
        z.DajGlos();
        Console.WriteLine("Typ obiektu: " + z.GetType().Name);
    }

    static void Main()
    {
        Zwierze z = new Zwierze("Zwierzak");
        Zwierze pies = new Pies("Reksio");
        Zwierze kot = new Kot("Filemon");
        Zwierze waz = new Waz("Kaa");

        PowiedzCos(z);
        PowiedzCos(pies);
        PowiedzCos(kot);
        PowiedzCos(waz);

        // p2

        Pracownik p = new Piekarz();
        p.Pracuj();

        // p3
        Console.WriteLine();
        A a = new A();
        Console.WriteLine();
        B b = new B();
        Console.WriteLine();
        C c = new C();
    }
}

// p4

abstract class Pracownik
{
    public abstract void Pracuj();
}

class Piekarz : Pracownik
{
    public override void Pracuj()
    {
        Console.WriteLine("Trwa pieczenie...");
    }
}

// p5

class A
{
    public A()
    {
        Console.WriteLine("To jest konstruktor A");
    }
}

class B : A
{
    public B() : base()
    {
        Console.WriteLine("To jest konstruktor B");
    }
}

class C : B
{
    public C() : base()
    {
        Console.WriteLine("To jest konstruktor C");
    }
}
