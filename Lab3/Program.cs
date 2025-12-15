using System;

interface IModular
{
    double Module();
}

class ComplexNumber : ICloneable, IEquatable<ComplexNumber>, IModular
{
    private double re;
    private double im;

    public double Re
    {
        get { return re; }
        set { re = value; }
    }

    public double Im
    {
        get { return im; }
        set { im = value; }
    }

    public ComplexNumber(double re, double im)
    {
        this.re = re;
        this.im = im;
    }

    public override string ToString()
    {
        if (im >= 0)
            return re + " + " + im + "i";
        else
            return re + " - " + (-im) + "i";
    }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.re + b.re, a.im + b.im);
    }

    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.re - b.re, a.im - b.im);
    }

    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(
            a.re * b.re - a.im * b.im,
            a.re * b.im + a.im * b.re
        );
    }

    public static ComplexNumber operator -(ComplexNumber a)
    {
        return new ComplexNumber(a.re, -a.im);
    }

    public object Clone()
    {
        return new ComplexNumber(re, im);
    }

    public bool Equals(ComplexNumber other)
    {
        if (other == null)
            return false;

        return re == other.re && im == other.im;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as ComplexNumber);
    }

    public override int GetHashCode()
    {
        return re.GetHashCode() ^ im.GetHashCode();
    }

    public static bool operator ==(ComplexNumber a, ComplexNumber b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if ((object)a == null || (object)b == null)
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(ComplexNumber a, ComplexNumber b)
    {
        return !(a == b);
    }

    public double Module()
    {
        return Math.Sqrt(re * re + im * im);
    }
}

class Program
{
    static void Main()
    {
        ComplexNumber z1 = new ComplexNumber(6, 7);
        ComplexNumber z2 = new ComplexNumber(2, -3);

        Console.WriteLine("z1 = " + z1);
        Console.WriteLine("z2 = " + z2);

        Console.WriteLine("z1 + z2 = " + (z1 + z2));
        Console.WriteLine("z1 - z2 = " + (z1 - z2));
        Console.WriteLine("z1 * z2 = " + (z1 * z2));

        ComplexNumber z3 = (ComplexNumber)z1.Clone();
        Console.WriteLine("Klon z1 = " + z3);

        Console.WriteLine("z1 == z3 ? " + (z1 == z3));
        Console.WriteLine("Modul z1 = " + z1.Module());

        ComplexNumber sprzezenie = -z1;
        Console.WriteLine("Sprzezenie z1 = " + sprzezenie);
    }
}
