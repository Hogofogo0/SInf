class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vyber programy, které chceš spustit:");
        Console.WriteLine("1 - Pozdrav");
        Console.WriteLine("2 - Věk");
        Console.WriteLine("3 - Součet čísel");
        Console.WriteLine("4 - Násobilka");
        Console.WriteLine("5 - Barevná text");
        Console.WriteLine("Napiš čísla programů, které chceš spustit, oddělená mezerou:");
        string? input = Console.ReadLine();
        if (input == null) return;
        int[] programs = Array.ConvertAll( input.Split(' '), int.Parse );
        
        Dictionary<int, Action> programDict = new Dictionary<int, Action>()
        {
            {1, greetUser},
            {2, getAge},
            {3, addAll},
            {4, printMultiplicationTable},
            {5, colorfulText}
        };

        foreach (int program in programs)
        {
            if (programDict.ContainsKey(program))
            {
                programDict[program]();
            }
            else
            {
                Console.WriteLine($"Program {program} neexistuje.");
            }
        }

    }

    // Pozdrav
    public static void greetUser()
    {
        Console.WriteLine("Tak dobrý den, já se jmenuji:");
        string? a = Console.ReadLine();
        Console.WriteLine($"Oh hello there {a}");
    }

    // Věk
    static void getAge()
    {
        Console.WriteLine("Kdy ses narodil(a)?");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Aha, takže je ti {DateTime.Now.Year-b} let.");
    }

    // Součet čísel
    static void addAll()
    {
        Console.WriteLine("Zadej seznam čísel, která se sečtou s mezerami:");
        string? c = Console.ReadLine();
        if (c[c.Length - 1] == ' ') c = c.Remove(c.Length - 1);
        int[] cisla = Array.ConvertAll(c.Split(' '), int.Parse);
        

        int sum = 0;
        foreach (int i in cisla)
        {
            sum += i;
        }
        Console.WriteLine($"Součet je {sum}");
    }

    // Násobilka
    static void printMultiplicationTable()
    {

        Console.WriteLine("Zadej číslo, pro které chceš vidět násobilku:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }

    // Barevný
    static void colorfulText()
    {
        Console.WriteLine("Zadej text, který chceš barevně:");
        string? text = Console.ReadLine();
        for (int r = 0; r <= 255; r += 15)
        {
            for(int g = 0; g <= 255; g += 15)
            {
                for (int b = 0; b <= 255; b += 15)
                {
                    Console.Write($"\x1b[38;2;{r};{g};{b}m");
                    Console.Write(text);
                }
                Console.WriteLine();
            }
            

        }

        Console.CursorLeft = 50;
        Console.CursorTop = 10;
        Console.WriteLine("COMPLETED SUCCESSFULLY");


    }

}





