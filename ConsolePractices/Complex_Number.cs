
namespace ConsolePractices;

public class Complex_Number
{
    public double real { get; set; }
    public double img { get; set; } = 0;
    public Complex_Number()
    {
        this.real = this.img = 0;
    }
    public Complex_Number(double x, double y)
    {
        this.real = x; this.img = y;
    }
    public Complex_Number add(Complex_Number c1, Complex_Number c2)
    {
        Complex_Number c3 = new Complex_Number();
        c3.real = c1.real + c2.real;
        c3.img = c1.img + c2.img;
        return c3;
    }
    public Complex_Number sub(Complex_Number c1, Complex_Number c2)
    {
        Complex_Number c3 = new Complex_Number();
        c3.real = c1.real - c2.real;
        c3.img = c1.img - c2.img;
        return c3;
    }

    public Complex_Number mul(Complex_Number c1, Complex_Number c2)
    {
        Complex_Number c3 = new Complex_Number();
        double x = c1.real * c2.real;
        double y = c1.img * c2.img;
        x = x - y;
        c3.real = x;
        x = c1.real * c2.img;
        y = c2.real * c1.img;
        x = x + y;
        c3.img = x;
        return c3;
    }
    public Complex_Number div(Complex_Number c1, Complex_Number c2)
    {
        Complex_Number c3 = new Complex_Number();
        double x = c1.real * c2.real;
        double y = c1.img * c2.img;
        c3.real = x + y;
        x = c1.real * c2.img;
        x *= -1;
        y = c1.img * c2.real;
        c3.img = x + y;
        x = c2.real * c2.real;
        y = c2.img * c2.img;
        x = x + y;
        c3.real /= x;
        c3.img /= y;
        return c3;
    }
    public static double abs(Complex_Number c1, Complex_Number c2)
    {
        double s = 0;
        c1.real = c1.real - c2.real;
        c1.img = c1.img - c2.img;
        c1.real = Math.Abs(c1.real);
        c1.img = Math.Abs(c1.img);
        s = c1.real * c1.real + c2.img * c2.img;
        s = Math.Sqrt(s);
        return s;
    }
    public static Complex_Number operator +(Complex_Number c1, Complex_Number c2)
    {
        return new Complex_Number(c1.real + c2.real, c1.img + c2.img);
    }
    public static Complex_Number operator -(Complex_Number c1, Complex_Number c2)
    {
        return new Complex_Number(c1.real - c2.real, c1.img - c2.img);
    }
    public static Complex_Number operator ++(Complex_Number c1)
    {
        return new Complex_Number(c1.real + 1, c1.img);
    }
    public static Complex_Number operator --(Complex_Number c1)
    {
        return new Complex_Number(c1.real - 1, c1.img);
    }
    public static bool operator >(Complex_Number c1, Complex_Number c2)
    {
        if (c1.real == c2.real)
            return c1.img > c2.img;
        else
            return c1.real > c2.real;
    }
    public static bool operator <(Complex_Number c1, Complex_Number c2)
    {
        if (c1.real == c2.real)
            return c1.img < c2.img;
        else
            return c1.real < c2.real;
    }
    public static bool operator ==(Complex_Number c1, Complex_Number c2)
    {
        if ((c1.real == c2.real) && (c1.img == c2.img))
            return true;
        return false;
    }

    public static bool operator !=(Complex_Number c1, Complex_Number c2) =>
        ((c1.real != c2.real) && (c1.img != c2.img));

    public static explicit operator double(Complex_Number c1) => c1.real;
}