

namespace ConsolePractices;

public class Prime_numbers
{
    StreamReader sr;
    List<int> list;
    public Prime_numbers()
    {

        list = new List<int>();
        sr = new StreamReader("50million_primes.txt");
        string op = sr.ReadLine();
        while (op != null)
        {
            int num = int.Parse(op);
            list.Add(num);
            op = sr.ReadLine();
        }
        sr.Close();
    }
    public void oop()
    {
        int sum = 0;
        StreamWriter streamWriter = new StreamWriter("ppppp.txt");
        for (int i = 0; i < 10; i++)
        {
            int val = list[i];
            for (int j = 0; j < val; j++)
                sum += list[j];
            Console.WriteLine(val + "\t" + sum);
            streamWriter.WriteLine(val + "\t" + sum);
            sum = 0;
        }
        streamWriter.Close();
    }
    public void write_files()
    {
        StreamWriter streamWriter;
        string name = "Prime_-";
        int count = 2;
        while (count < 175)
        {
            name = "prime_-";
            name += count + ".txt";
            streamWriter = new StreamWriter(name);
            for (int i = 0; i < list.Count - 1; i++)
                if (list[i + 1] - list[i] == count)
                    streamWriter.WriteLine(list[i] + "\t" + list[i + 1]);
            count += 2;
        }
    }
    public void oooop()
    {
        for (int i = 1; i < 10; i++)
        {
            int val = i;
            val++;
            val *= val;
            for (int j = i * i; j < val; j++)
                Console.Write(j + "\t");
            Console.WriteLine();
        }
    }
    public int value(int index)
    {
        index--;
        if (index < 0 || index >= list.Count)
            return -1;
        return list[index];
    }
    public int gap()
    {
        int max = 0;
        for (int i = 0; i < list.Count - 1; i++)
            if (list[i + 1] - list[i] > max)
                max = list[i + 1] - list[i];
        return max;
    }
    public bool prime(int num)
    {
        return list.Contains(num);
    }
    public void write()
    {
        StreamWriter sw = new StreamWriter("prim.txt");
        for (int i = 0; i < 100000; i++)
            sw.WriteLine((i + 1).ToString() + "\t" + list[i]);
    }
    public int next_prime(int x)
    {
        x++;
        while (!prime(x))
            x++;
        return x;

    }
    public bool indecies(int index_)
    {
        int sum = 0;
        for (int i = 0; i < index_ - 1; i++)
            sum += list[i];
        int ind = index(index_);
        return ind == sum;
    }
    public List<int> get()
    {
        return this.list;
    }
    public int index(int num)
    {
        if (list.Contains(num))
            return list.IndexOf(num) + 1;
        return -1;
    }
    public int[] prime_numbers_range(int num)
    {
        for (int i = num; i > 1; i--)
            if (prime(i))
                num = i;
        num = index(num);
        int[] A = new int[num + 1];
        for (int i = 0; i <= num; i++)
            A[i] = list[i];
        return A;
    }
    public int[] prime_with_n(int num)
    {
        int[] A = new int[num];
        int count = 0;
        int i = 1;
        while (count < num)
        {
            if (prime(i))
                A[count++] = i;
            i++;
        }
        return A;
    }
    public int[] not_prime_numbers_range(int num)
    {
        int[] A;
        int c = 0;
        for (int i = 1; i < num; i++)
            if (!prime(i))
                c++;
        A = new int[c];
        c = 0;
        for (int i = 1; i < num; i++)
            if (!prime(i))
                A[c++] = i;
        return A;
    }
    public int sum_n(int num)
    {
        int sum = 0;
        for (int i = 0; i <= num; i++)
            if (prime(i))
                sum += i;
        return sum;
    }
    public int sum_numbers(int num)
    {
        int count = 0;
        int sum = 0;
        int i = 1;
        while (count <= num)
        {
            if (prime(i))
            {
                sum += i;
                count++;
            }
            i++;
        }
        return sum;
    }
    public int sum_n_value(int value)
    {
        int sum = 0;
        int count = 0;
        int i = 1;
        while (sum < value)
        {
            if (prime(i))
            {
                sum += i;
                count++;
            }
            i++;
        }
        return count;
    }
    public bool is_symmetric(int num)
    {
        if (!prime(num))
            return false;
        string x = num.ToString();
        // x = string.re(x);
        int b = int.Parse(x);
        return b == num;
    }
    public bool is_mersen(int num)
    {
        if (!prime(num))
            return false;
        num--;
        return Number_.is_pow_2(num);
    }
    public bool is_twin(int x, int y)
    {
        if (prime(x) && prime(y))
            return x - y == 2;
        return false;
    }
    public bool additive(int num)
    {
        if (!prime(num))
            return false;
        int sum = Number_.sum_of_digits(num);
        return prime(sum);
    }
    public bool pure(int num)
    {
        if (!additive(num)) return false;
        int index = Number_.count_of_digits(num);
        return prime(index);
    }
    public bool is_Cousin(int x, int y)
    {
        if (prime(y) && prime(x))
            return x - y == 4;
        return false;
    }
    public bool is_euclid(int num)
    {
        if (!prime(num))
            return false;
        num--;
        while (num != 1)
        {
            ;
        }
        return false;
    }
    public bool is_fact(int num)
    {
        if (!prime(num))
            return false;
        num--;
        if (Number_.is_fact(num))
            return true;
        num += 2;
        if (Number_.is_fact(num))
            return true;
        return false;
    }
    public bool is_isolated(int num)
    {
        num -= 2;
        if (prime(num)) return false;
        num += 4;
        if (prime(num))
            return false;
        return true;
    }
    public bool is_safe(int num)
    {
        if (!prime(num)) return false;
        num--;
        num /= 2;
        return prime(num);
    }
    public bool is_carol(int num)
    {
        if (!prime(num))
            return false;
        num -= 2;
        num = Number_.square_root(num);
        return false;

    }

    public bool is_super(int num)
    {
        if (!prime(num))
            return false;
        int i = index(num);
        return prime(i);
    }

    public bool is_Sophie_germain(int num)
    {
        if (!prime(num))
            return false;
        int i = 2 * num + 1;
        return prime(i);
    }

    public bool is_sexy(int num1, int num2)
    {
        if (prime(num1) && prime(num2))
            if (num1 - num2 == 6)
                return true;
        return false;
    }

}
