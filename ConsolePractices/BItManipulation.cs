

namespace ConsolePractices;

public class BItManipulation
{
    public static bool is_even(int num)
    {
        return (num & 1) == 0;
    }

    public static void print_binary_num(int num)
    {
        while (num != 0)
        {
            Console.Write((num & 1) + "\t");
            num >>= 1;
        }
    }
    public static string fromdicbin(int num)
    {
        return Convert.ToString(num, 2);
    }
    public static int from_dic_bin(int num)
    {
        int s = 0;
        int b = 1;
        while (num != 0)
        {
            int d = num % 2;
            d *= b;
            s += d;
            b *= 10;
            num /= 2;
        }
        return s;
    }

    public static int from_dic_oct(int num)
    {
        int s = 0;
        int b = 1;
        while (num != 0)
        {
            int d = num % 8;
            d *= b;
            s += d;
            b *= 10;
            num /= 8;
        }
        return s;
    }
    public static string fromdichex(int num)
    {
        return num.ToString("x");
    }
    public static int from_dic_hex(int num)
    {
        int s = 0;
        int b = 1;
        while (num != 0)
        {
            int d = num % 16;
            if (d > 9)
            {
                ;
            }
            d *= b;
            s += d;
            b *= 10;
            num /= 16;
        }
        return s;
    }

    public static void print_binary_num_2(int num)
    {
        while (num != 0)
        {
            Console.Write((num % 2 + "\t"));
            num /= 2;
        }
    }
    public static int from_bin_dic(int num)
    {
        int sum = 0;
        string x = num.ToString();
        //   x = string.reverse(x);
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == '0')
                sum += 0;
            else sum += (pow_2(i));
        }
        return sum;
    }

    public static int pow_2(int pow)
    {
        int sum = 1;
        for (int i = 1; i <= pow; i++)
            sum *= 2;
        return sum;
    }
    public static int and(int x, int y)
    {
        return x & y;
    }
    public static int or(int x, int y)
    {
        return x | y;
    }
    public static int x_or(int x, int y)
    {
        return x ^ y;
    }
    public static int not(int x)
    {
        return ~x;
    }
    public static int first_complement(int num)
    {
        return num;
    }
    public static int second_complement(int num)
    {
        return num;
    }


}