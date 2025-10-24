public class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] a = FillWithPrimes(1000000);
        //int[] a = FillListByStep(5, -2,10);
        PrintList(a);
        Console.WriteLine(sumArray(a));

        
    }

    public static void PrintList(int[] a)
    {
        Console.Write("[");
        for (int i = 0; i < a.Length-1; i++) 
            Console.Write($"{a[i]}, ");
        Console.Write(a[a.Length-2]);
        Console.WriteLine("]");
    }

    public static int[] FillListByStep(int step, int length)
    {
        int[] a = new int[length];
        for(int i = 0;i < length; i++)
        {
            a[i] = i * step;
        }
        return a;
    }

    public static int[] FillListByStep(int start, int step, int length)
    {
        int[] a = new int[length];
        for (int i = 0; i < length; i++)
        {
            a[i] = start + i * step;
        }
        return a;
    }

    public static int sumArray(int[] a)
    {
        int s = 0;
        foreach (int i in a) s += i;
        return s;
    }


    public static int[] FillWithPrimes(int max)
    {
        bool[] a = new bool[max];
        Array.Fill(a, true);
        for (int i = 2; i < Math.Sqrt(max); i++)
        {
            if (a[i])
            {
                for(int j = i*i;  j < max; j += i)
                {
                    a[j] = false;
                }
            }
        }

        List<int> b = new List<int>();

        for(int i = 0; i < a.Length; i++)
        {
            if(a[i])
                b.Add(i);
        }
        return b.ToArray();

    }


}