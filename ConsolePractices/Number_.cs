

namespace ConsolePractices;

public static class Number_
{
    public static void divisor(int num)
    {
        for (int i = 2; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
                num /= i;
                i--;
            }
        }
    }
    public static bool is_positive(this int num)
    {
        return num >= 0;
    }
    public static bool is_negative(this int num)
    {
        return num < 0;
    }

    public static bool is_pow_2(this int num)
    {
        while (num > 1)
        {
            if (!is_even(num))
                return false;
            num /= 2;
        }
        return true;
    }
    public static int[] find_square_equation(int a, int b, int c)
    {
        int[] A = new int[2];
        double s = b * b - 4 * a * c;
        if (s > 0)
        {
            s = MathF.Sqrt((float)Convert.ToDouble(s));

            double p1 = (-b + s) / 2 * a;
            double p2 = (-b - s) / 2 * a;
            A[0] = (int)p1;
            A[1] = (int)p2;
        }
        else if (s == 0)
        {
            double p = -b / 2 * a;
            A[0] = A[1] = (int)p;
            Console.WriteLine("one root");
        }
        else
            Console.WriteLine("no roots");
        return A;
    }
    public static bool is_even(this int num)
    {
        return num % 2 == 0;
    }

    public static int sum_even_n(this int num)
    {
        int sum = 0;
        for (int i = 0; i <= num; i += 2)
            sum += i;
        return sum;
    }

    public static int sum_odd_n(this int num)
    {
        int sum = 0;
        for (int i = 0; i <= num; i += 2)
            sum += i;
        return sum;
    }
    public static double pi()
    {
        //            Console.WriteLine(p);
        return Math.PI;
    }
    public static bool is_balance(this int num)
    {
        int s = sum_of_digits(num);
        s /= 2;
        int m = max_digit(num);
        return (s == m);
    }
    public static bool is_vampire_number(this int x, int y)
    {
        return false;
    }
    public static bool is_magic(this int num)
    {
        int a = sum_of_digits(num);
        int s = reverse_num(a);
        return a * s == num;
    }

    public static bool is_palindrome(this int num)
    {
        int x = reverse_num(num);
        return num == x;
    }
    public static bool is_abundant(int num)
    {
        return sum_of_divisors(num) > num;

    }

    public static bool is_deficient(this int num)
    {
        return sum_of_divisors(num) < num;

    }

    public static bool is_perfect(this int num)
    {
        return sum_of_divisors(num) == num;

    }

    public static bool is_disarium(this int num)
    {
        num = reverse_num(num);
        int a = num;
        int sum = 0;
        int c = 1;
        while (num != 0)
        {
            int d = num % 10;
            d = pow(d, c);
            sum += d;
            num /= 10;
            c++;
        }
        a = reverse_num(a);
        return sum == a;
    }

    public static bool is_happy(this int num)
    {
        int b = 0;
        int sum = 0;
        while (sum != 1)
        {
            sum = 0;
            while (num != 0)
            {
                int d = num % 10;
                d *= d;
                sum += d;
                num /= 10;
            }
            num = sum;
            if (b++ > 100)
                return false;
        }
        return true;
    }

    public static bool is_harshed(this int num)
    {
        if (num < 1)
            return false;
        int s = sum_of_digits(num);
        return num % s == 0;
    }

    public static bool is_automorphic(this int num)
    {
        int x = num * num;
        int a = last_digit(x);
        int b = last_digit(num);
        return a == b;
    }

    public static bool is_duck(this int num)
    {
        while (num != 0)
        {
            int d = num % 10;
            if (d == 0)
                return true;
            num /= 10;
        }
        return false;

    }

    public static bool is_amicable(int x, int y)
    {
        int s1 = sum_of_divisors(x);
        int s2 = sum_of_divisors(y);
        return s1 == y && s2 == x;
    }

    public static bool is_narcissistic(this int num)
    {
        int a = num;
        int c = count_of_digits(num);
        int sum = 0;
        while (num != 0)
        {
            int d = num % 10;
            d = pow(d, c);
            num /= 10;
            sum += d;
        }
        return sum == a;
    }

    public static bool is_armstrong(this int num)
    {
        int sum = 0;
        int a = num;
        while (num != 0)
        {
            int d = num % 10;
            d = pow(d, 3);
            sum += d;
            num /= 10;
        }
        return sum == a;
    }
    public static bool is_start_equal_end(this int num)
    {
        int s = first_digit(num);
        int e = last_digit(num);
        return s == e;
    }

    public static int fact(this int num)
    {
        int f = 1;
        if (is_negative(num) || num == 0)
            return f;
        for (int i = 1; i <= num; i++)
            f *= i;
        return f;
    }
    public static bool is_fact(this int num)
    {
        if (num == 0)
            return false;
        int i = 2;
        while (num != 1)
        {
            if (num % i != 0)
                return false;
            num = num / i;
            i++;
        }
        return true;
    }
    public static int refact(this int num)
    {
        int count = 2;
        int i = 2;
        while (num != 1)
        {
            num = num / i;
            i++;
            count++;
        }
        return --count;
    }
    public static int pow(this int num, int x)
    {
        if (x == 0)
            return 1;

        int a = 1;
        for (int i = 1; i <= x; i++)
            a *= num;
        return a;
    }

    public static double pow_2(this int x)
    {
        int f = 1;
        for (int i = 1; i <= x; i++)
            f *= 2;
        return f;
    }
    public static int square_root(this int num)
    {
        for (int i = 1; i <= num; i++)
            if (i * i == num)
                return i;
        return 1;
    }

    public static int n_root(this int num, int x)
    {
        int f = 1;
        for (int i = 1; i <= num; i++)
        {
            f = 1;
            for (int j = 1; j <= x; j++)
                f *= i;
            if (f == num)
                return i;
        }
        return f;
    }
    public static int reverse_num(this int num)
    {
        int a = 0;
        while (num > 0)
        {
            int x = num % 10;
            a = a * 10 + x;
            num /= 10;
        }
        return a;
    }

    public static int max_digit(this int num)
    {
        int max = num % 10;
        while (num > 0)
        {
            int a = num % 10;
            if (a > max)
                max = a;
            num /= 10;
        }
        return max;
    }

    public static int min_digit(this int num)
    {
        int min = num % 10;
        while (num > 0)
        {
            int a = num % 10;
            if (a < min)
                min = a;
            num /= 10;
        }
        return min;
    }

    public static int sum_of_digits(this int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
    public static int sum_of_divisors(this int num)
    {
        int sum = 0;
        for (int i = 2; i < num; i++)
            if (num % i == 0)
                sum += i;
        return sum;
    }

    public static int count_of_digits(this int num)
    {
        int c = 0;
        while (num != 0)
        {
            num /= 10;
            c++;
        }
        return c;
    }

    public static int[] factors(this int num)
    {
        int count = 0;
        int y = num;
        int[] A;
        while (num > 1)
        {
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    num /= i;
                    break;
                }
            }
        }
        A = new int[count];
        count = 0;
        while (y > 1)
        {
            for (int i = 2; i <= y; i++)
            {
                if (y % i == 0)
                {
                    A[count++] = i;
                    y /= i;
                    break;
                }
            }
        }
        return A;
    }
    public static List<int> count_of_divisor(this double num)
    {
        List<int> list = new List<int>();

        if (num < 1)
            return list;
        else
        {
            for (int i = 1; i <= num / 2; i++)
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    list.Add(i);
                }
        }
        return list;
    }

    public static int first_digit(this int num)
    {
        int d = num % 10;
        while (num != 0)
        {
            d = num % 10;
            num /= 10;
        }
        return d;
    }

    public static int last_digit(this int num)
    {
        return num % 10;
    }

    public static int remove_first_digit(this int num, int x)
    {
        string y = num.ToString();
        int index = y.IndexOf(x.ToString());
        string b = y.Substring(0, index) + y.Substring(index + 1);
        num = int.Parse(b);
        return num;
    }
    public static int remove_all_digit(this int num, int x)
    {
        int a = 0;
        while (num != 0)
        {
            int d = num % 10;
            if (d != x)
            {
                a = a * 10 + d;
            }
            num /= 10;
        }
        a = reverse_num(a);
        return a;
    }


    public static string to_string(this int num)
    {
        return num.ToString();
    }
    public static void pell_number(int count)
    {

    }
    public static void Fibonacci_numbers(this int count)
    {
        Console.Write(0);
        int a = 0;
        int b = 1;
        int c = 0;
        for (int i = 1; i < count - 1; i++)
        {
            Console.Write("\t" + b);
            c = b;
            b = b + a;
            a = c;
        }
    }
    public static bool is_fibonacci(this int num)
    {
        int x = 1; int y = 0;
        int s = 1;
        while (x < num)
        {
            s = x;
            x = x + y;
            y = s;
            if (x == num)
                return true;
        }
        return false;
    }
    public static int sort_num(this int x)
    {
        int y = 0;
        int d = 1;
        while (x != 0)
        {
            int m = max_digit(x);
            x = remove_first_digit(x, m);
            m *= d;
            y += m;
            d *= 10;

        }
        return y;
    }
    public static int sort_num_2(this int x)
    {
        string y = x.ToString();
        //  y = string.sort(y);
        x = int.Parse(y);
        return x;
    }
    public static bool find(this int num, int x)
    {
        while (num != 0)
        {
            int d = num % 10;
            if (d == x)
                return true;
            num /= 10;
        }
        return false;
    }
    public static int occure_digit(this int num, int x)
    {
        int count = 0;
        while (num != 0)
        {
            int d = num % 10;
            if (d == x)
                count++;
            num /= 10;
        }
        return count;
    }

    public static double value_E()
    {
        double e = 2;
        for (int i = 2; i <= 100; i++)
        {
            double s = fact(i);
            s = 1 / s;
            e += s;
        }
        return e;
    }
    public static int gcd(this int x, int y)
    {
        int z = 0;
        while (y != 0)
        {
            z = y;
            y = x % y;
            x = z;
        }
        return x;
    }
    public static int lcd(this int x, int y)
    {
        int z = 0;


        return z;
    }

    public static int even_odd(this int num)
    {
        int a = 0;
        int b = num;
        while (num != 0)
        {
            int d = num % 10;
            if (d % 2 != 0)
            {
                num /= 10;
                continue;
            }
            else
                a = a * 10 + d;
            num /= 10;
        }
        while (b != 0)
        {
            int d = b % 10;
            if (d % 2 == 0)
            {
                b /= 10;
                continue;
            }
            else
                a = a * 10 + d;
            b /= 10;
        }
        return a;
    }
    public static void sum_even_odd_prime(this int num)
    {
        int sum_even = 0, sum_odd = 0, sum_prime = 0;
        while (num != 0)
        {
            int d = num % 10;
            if (is_even(d))
                sum_even = sum_even + d;
            if (!is_even(d))
                sum_odd = sum_odd + d;
            // if (prime(d))
            sum_prime = sum_prime + d;
            num /= 10;
        }
        Console.WriteLine("sum_even=" + sum_even + "sum_odd" + sum_odd + "sum_prime" + sum_prime);
    }
}
