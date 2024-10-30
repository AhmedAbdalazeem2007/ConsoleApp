
namespace ConsolePractices;

public static  class Array_
{
    public static void fill(this int[] A)
    {
        for (int i = 0; i < A.Length; i++)
            A[i] = i + 1;
    }
    public static void enter_unique_numbers(int[] A)
    {
        int count = 0;
        while (count < A.Length)
        {
            Console.WriteLine("Enter the number");
            int x = int.Parse(Console.ReadLine());
            while (A.Contains(x))
            {
                Console.WriteLine("Enter another number");
                x = int.Parse(Console.ReadLine());
            }
            A[count++] = x;
        }
    }

    public static void fill(int[] A, int value)
    {
        for (int i = 0; i < A.Length; i++)
            A[i] = value;
    }

    public static void zeros(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
            A[i] = 0;
    }

    public static void ones(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
            A[i] = 1;
    }

    public static int sum(this int[] A)
    {
        return A.Sum();
    }

    public static double avg(this int[] A)
    {
        int s = A.Sum();
        double b = A.Length;
        double a = s / b;
        return a;
    }

    public static int[] merge(int[] A, int[] B)
    {
        int[] C = new int[A.Length + B.Length];
        int count = 0, a_index = 0, b_index = 0;
        while (count < C.Length)
        {
            if (A[a_index] > B[b_index])
                C[count++] = B[b_index++];
            else
                C[count++] = A[a_index++];
            if (a_index >= A.Length)
                for (int i = b_index; i < B.Length; i++)
                    C[count++] = B[i];
            if (b_index >= B.Length)
                for (int i = a_index; i < A.Length; i++)
                    C[count++] = A[i];
        }
        return C;
    }

    public static IEnumerable<T> combine_two_array_without_duplicate<T>(T[] a1, T[] a2)
    {
        var all = a1.Union(a2).ToArray();
        return all;
    }
    public static void replace(int[] A, int v, int num)
    {
        for (int i = 0; i < A.Length; i++)
            if (A[i] == v)
                A[i] = num;
    }

    public static bool is_sorted(this int[] A)
    {
        for (int i = 1; i < A.Length; i++)
            if (A[i] < A[i - 1])
                return false;
        return true;
    }
    public static bool is_symmetric(this int[] A)
    {
        int count = A.Length - 1;
        for (int i = 0; i < A.Length / 2; i++)
            if (A[i] != A[count--])
                return false;
        return true;
    }

    public static int[] sum_of_certain_series(this int[] A, int sum)
    {
        return A;
    }
    public static void display(this int[] A)
    {
        for (int i = 0; i < A.Length; i++)
            Console.WriteLine(A[i]);
    }

    public static void display(this char[] A)
    {
        for (int i = 0; i < A.Length; i++)
            Console.WriteLine(A[i]);
    }

    public static void print_all_possible_numbers(int[] A)
    {

    }
    public static void print_odd(this int[] A)
    {
        for (int i = 0; i < A.Length; i++)
            if (A[i] % 2 != 0)
                Console.WriteLine(A[i]);
    }
    public static int min(this int[] A)
    {
        int m = A[0];
        for (int i = 1; i < A.Length; i++)
            if (A[i] < m)
                m = A[i];
        return m;
    }

    public static int max(this int[] A)
    {
        int m = A[0];
        for (int i = 1; i < A.Length; i++)
            if (A[i] > m)
                m = A[i];
        return m;
    }

    public static void reverse_in_place(this int[] A)
    {
        int swap = 0;
        int c = A.Length - 1;
        for (int i = 0; i < A.Length / 2; i++)
        {
            swap = A[i];
            A[i] = A[c];
            A[c] = swap;
            c--;
        }
    }

    public static int[] reverse(int[] A)
    {
        int[] B = new int[A.Length];
        for (int i = A.Length - 1; i >= 0; i--)
            B[A.Length - i - 1] = A[i];
        return B;
    }

    public static bool find(int[] A, int x)
    {
        for (int i = 0; i < A.Length; i++)
            if (A[i] == x)
                return true;
        return false;
    }

    public static int Occurence(int[] A, int x)
    {
        int count = 0;
        for (int i = 0; i < A.Length; i++)
            if (A[i] == x)
                count++;
        return count;

    }

    public static int most_common(this int[] A)
    {
        int c = 0, m = 0, n = 0;
        for (int i = 0; i < A.Length; i++)
        {
            c = Occurence(A, A[i]);
            if (c > m)
            {
                m = c;
                n = A[i];
            }
        }
        return n;
    }

    public static bool is_distinct(this int[] A)
    {
        for (int i = 0; i < A.Length; i++)
            if (Occurence(A, A[i]) > 1)
                return false;
        return true;
    }


    public static string to_string(this int[] A)
    {
        string x = "";
        for (int i = 0; i < A.Length; i++)
            x += A[i].ToString();
        return x;
    }

    public static string to_string(this char[] A)
    {
        string x = "";
        for (int i = 0; i < A.Length; i++)
            x += A[i];
        return x;
    }

    public static int first_index(this int[] A, int v)
    {
        int index = -1;
        for (int i = 0; i < A.Length; i++)
            if (A[i] == v)
                return i;
        return index;
    }

    public static int last_index(this int[] A, int v)
    {
        int index = -1;
        for (int i = 0; i < A.Length; i++)
            if (A[i] == v)
                index = i;
        return index;
    }

    public static int get_value(this int[] A, int index)
    {
        if (index < A.Length && index >= 0)
            return A[index];
        Console.WriteLine("invalid index");
        return -1;
    }

    public static void delete_start(this int[] A)
    {
        A[0] = 0;
        for (int i = 0; i < A.Length - 1; i++)
            A[i] = A[i + 1];
        A[A.Length - 1] = 0;
    }


    public static void delete_end(this int[] A)
    {
        A[A.Length - 1] = 0;
    }

    public static void delete_index(this int[] A, int index)
    {
        if (!(index < A.Length && index >= 0))
            return;
        A[index] = 0;
        for (int i = index; i < A.Length - 1; i++)
            A[i] = A[i + 1];
        A[A.Length - 1] = 0;
    }

    public static void delete_first_value(this int[] A, int v)
    {
        int index = first_index(A, v);
        if (index == -1)
            return;
        A[index] = 0;
        for (int i = index; i < A.Length - 1; i++)
            A[i] = A[i + 1];
        A[A.Length - 1] = 0;
    }

    public static void delete_last_value(this int[] A, int v)
    {
        int index = last_index(A, v);
        if (index == -1)
            return;
        A[index] = 0;
        for (int i = index; i < A.Length - 1; i++)
            A[i] = A[i + 1];
        A[A.Length - 1] = 0;

    }
    public static int[] large_3_element(int[] A)
    {
        int[] B = new int[3];
        Sort_.selection_sort(A);
        int c = 0;
        for (int i = A.Length - 3; i < A.Length; i++)
            B[c++] = A[i];
        return B;
    }

    public static int second_large_element(this int[] A)
    {
        Sort_.selection_sort(A);
        int m = A[A.Length - 1];
        for (int i = A.Length - 1; i >= 0; i--)
            if (A[i] < m)
                return A[i];
        return -1;
    }
    public static bool equal(int[] A, int[] B)
    {
        if (A.Length != B.Length)
            return false;
        for (int i = 0; i < A.Length; i++)
            if (A[i] != B[i])
                return false;
        return true;
    }

    public static int count_of_unique_numbers(int[] A)
    {
        int count = 0;
        for (int i = 0; i < A.Length; i++)
            if (Occurence(A, A[i]) == 1)
                count++;
        return count;
    }

    public static int[] to_distinict_1(int[] A)
    {
        int[] B;
        int count = 0;
        for (int i = 0; i < A.Length; i++)
            if (Occurence(A, A[i]) == 1) count++;
        B = new int[count];
        count = 0;
        for (int i = 0; i < A.Length; i++)
            if (Occurence(A, A[i]) == 1)
                B[count++] = A[i];
        return B;
    }

    public static int[] to_distinict_2(int[] A)
    {
        return A.Distinct().ToArray();
    }
    public static T[] distinict<T>(T[] A)
    {
        return A.Distinct().ToArray();
    }
    public static void move_zeros_end(int[] A)
    {
        int c = A.Length - 1;
        for (int i = 0; i < A.Length; i++)
            if (A[i] == 0)
            {
                int swap = A[i];
                A[i] = A[c];
                A[c] = swap;
                c--;
            }

    }
    public static int[] sum(int[] A, int[] B)
    {
        int[] C = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
            C[i] = A[i] + B[i];
        return C;
    }
    public static int[] mul(int[] A, int[] B)
    {
        int[] C = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
            C[i] = A[i] * B[i];
        return C;
    }
}
