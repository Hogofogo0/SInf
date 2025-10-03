using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        printFrame();
        bool selected = true;

        while (true)
        {
            
            printGamemodeWindow(selected);
            ConsoleKeyInfo key = Console.ReadKey(true);
            if(key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.UpArrow)
            {
                selected = !selected;
            }
            if (key.Key == ConsoleKey.Enter && selected == false)
            {
                break;
            }
            if (key.Key == ConsoleKey.Enter && selected == true)
            {
                runGame();
            }

        }
        

    }

    public static void runGame()
    {
        int a = 49;
        Console.CursorLeft = a;
        Console.CursorTop = 12;
        Console.WriteLine("+--------------------------------+");
        for (int i = 1; i < 6; i++)
        {
            Console.CursorLeft = a;
            Console.CursorTop = 12 + i;
            Console.WriteLine("|                                |");
        }


        Console.CursorLeft = a;
        Console.CursorTop = 18;
        Console.WriteLine("+--------------------------------+");

        Console.CursorLeft = a + 12;
        Console.CursorTop = 13;

        Console.WriteLine("  VALUES  ");
        Console.CursorLeft = a + 5;
        Console.CursorTop = 15;
        
        Console.WriteLine(" Minimum value: ");
        
        Console.CursorLeft = a + 5;
        Console.CursorTop = 16;
        Console.WriteLine(" Maximum value: ");

        Console.CursorLeft = a + 5;
        Console.CursorTop = 17;
        Console.WriteLine(" Speed: ");
        Console.CursorLeft = a + 5 + 16;
        Console.CursorTop = 15;
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        float minV = float.Parse(Console.ReadLine());
        Console.CursorLeft = a + 5 + 16;
        Console.CursorTop = 16;
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        float maxV = float.Parse(Console.ReadLine());
        Console.CursorLeft = a + 5 + 8;
        Console.CursorTop = 17;
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        float speed = float.Parse(Console.ReadLine());
        bool hit = isSuccess(speed, minV, maxV);

        Console.CursorLeft = a;
        Console.CursorTop = 12;
        Console.WriteLine("+--------------------------------+");
        for (int i = 1; i < 6; i++)
        {
            Console.CursorLeft = a;
            Console.CursorTop = 12 + i;
            Console.WriteLine("|                                |");
        }


        Console.CursorLeft = a;
        Console.CursorTop = 18;
        Console.WriteLine("+--------------------------------+");

        if (hit)
        {
            Console.CursorLeft = a + 12;
            Console.CursorTop = 15;
            Console.WriteLine("  HIT!  ");
        }
        else
        {
            Console.CursorLeft = a + 7;
            Console.CursorTop = 15;
            Console.WriteLine($"  MISS!  ({(maxV <= speed * speed / 9.81 ? " Too Far" : "Too Close" )})");
        }
        Console.ReadLine();

    }

    public static void printFrame()
    {
        Console.Clear();
        for (int i = 0; i < 30; i++)
        {
            Console.WriteLine();
        }
        Console.CursorLeft = 30;
        Console.CursorTop = 5;
        Console.WriteLine("+---------------------------------------------------------------------+");
        for (int i = 1; i < 20; i++)
        {
            Console.CursorLeft = 30;
            Console.CursorTop = 5+i;
            Console.WriteLine("|                                                                     |");
        }


        Console.CursorLeft = 30;
        Console.CursorTop = 25;
        Console.WriteLine("+---------------------------------------------------------------------+");
    }
    public static void printGamemodeWindow(bool playGame = true)
    {

        int a = 49;
        Console.CursorLeft = a;
        Console.CursorTop = 12;
        Console.WriteLine("+--------------------------------+");
        for (int i = 1; i < 6; i++)
        {
            Console.CursorLeft = a;
            Console.CursorTop = 12 + i;
            Console.WriteLine("|                                |");
        }


        Console.CursorLeft = a;
        Console.CursorTop = 18;
        Console.WriteLine("+--------------------------------+");

        Console.CursorLeft = a + 10;
        Console.CursorTop = 13;
        
        Console.WriteLine("  GAME OVER  ");
        Console.CursorLeft = a + 10;
        Console.CursorTop = 15;
        if (playGame){
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
        }
        Console.WriteLine(" ~Play game~ ");
        Console.ResetColor();
        if
            (!playGame){
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
        }
        Console.CursorLeft = a + 10;
        Console.CursorTop = 16;
        Console.WriteLine(" ~Exit game~ ");
        Console.ResetColor(); 
        
        
        Console.ResetColor();
        
    }

    public static bool isSuccess(float speed, float low, float high) => (high >= speed*speed/9.81) && (low <= speed * speed / 9.81);
}
