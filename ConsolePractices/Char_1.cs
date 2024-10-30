

namespace ConsolePractices;

public static class Char_1
{
    
    public static void oop()
    {
        char a = '\u0050';
        Console.WriteLine(a);
    }
    public static bool is_small(this char x)
    {
        return (x >= 97 && x <= 122);
    }
    public static bool is_capital(this char x)
    {
        return (x >= 65 && x <= 90);
    }
    public static bool is_letter(this char x)
    {
        return (is_capital(x) || is_small(x));
    }
    public static bool is_vowel(this char x)
    {
        Char[] A = { 'a', 'A', 'I', 'i', 'o', 'O', 'U', 'u', 'E', 'e' };
        return A.Contains(x);
    }
    public static bool is_consonant(this char x)
    {
        return !is_vowel(x);
    }
    public static void from_a_z()
    {
        for (char i = 'a'; i <= 'z'; i++)
            Console.WriteLine(i);
    }
    public static void from_A_Z()
    {
        for (char i = 'A'; i <= 'Z'; i++)
            Console.WriteLine(i);
    }
    public static void from_z_a()
    {
        for (char i = 'z'; i >= 'a'; i--)
            Console.WriteLine(i);
    }
    public static void from_Z_A()
    {
        for (char i = 'Z'; i >= 'A'; i--)
            Console.WriteLine(i);
    }
    public static char to_lower(this char x)
    {
        if (!is_letter(x))
            return ' ';
        if (is_small(x))
            return x;
        int a = (int)x;
        a += 32;
        x = (char)a;
        return x;
    }
    public static char to_upper(this char x)
    {
        if (!is_letter(x))
            return ' ';
        if (is_capital(x))
            return x;
        int a = (int)x;
        a -= 32;
        x = (char)a;
        return x;
    }
    public static int asci_1(this char x)
    {
        int a = (int)x;
        return a;
    }
    public static char asci_2(this int num)
    {
        char x = (char)num;
        return x;
    }

    public static void sort_char(char[] A)
    {
        for (int i = 1; i < A.Length; i++)
        {
            char key = A[i];
            int j = i - 1;
            while (j >= 0 && A[j] > key)
            {
                A[j + 1] = A[j];
                j = j - 1;
            }
            A[j + 1] = key;
        }

    }
}