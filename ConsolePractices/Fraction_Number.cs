
namespace ConsolePractices;

public class Fraction_Number
{
    public double num {  get; set; }
    public double denum { get; set; }
    public Fraction_Number()
    {
        
    }
    public double sum(Fraction_Number f1, Fraction_Number f2)
    {

        double a = f1.num * f2.denum;
        double b = f1.denum * f2.num;
        a += b;
        b = f1.denum * f2.denum;
        Console.WriteLine(a + "/" + b + "\t");
        a = a / b;
        return a;
    }

    public double sub(Fraction_Number f1, Fraction_Number f2)
    {

        double a = f1.num * f2.denum;
        double b = f1.denum * f2.num;
        a -= b;
        b = f1.denum * f2.denum;
        Console.WriteLine(a + "/" + b + "\t");
        a = a / b;
        return a;
    }

    public double mul(Fraction_Number f1, Fraction_Number f2)
    {

        double a = f1.num * f2.num;
        double b = f1.denum * f2.denum;
        Console.WriteLine(a + "/" + b + "\t");
        a = a / b;
        return a;
    }

    public double div(Fraction_Number f1, Fraction_Number f2)
    {

        double a = f1.num * f2.denum;
        double b = f1.denum * f2.num;
        Console.WriteLine(a + "/" + b + "\t");
        a = a / b;
        return a;
    }
    public static bool operator >(Fraction_Number c1, Fraction_Number c2)
    {
        if (c1.denum == c2.denum)
            return c1.num > c2.num;
        return c1.num > c2.num;
    }
    public static bool operator <(Fraction_Number c1, Fraction_Number c2)
    {
        if (c1.denum == c2.denum)
            return c1.num < c2.num;
        return c1.num < c2.num;
    }

}
