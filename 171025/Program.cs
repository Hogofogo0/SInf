using System.Numerics;

double w = Console.WindowWidth;
double h = Console.WindowHeight;
double posH = 20;
double posV = 20;
bool f = true;
bool u = true;
Random random = new Random();
int speed = 1;
int ph = 20;

int miss = 0;
double time = (double) Math.Log10(DateTime.Now.Second);

Console.CursorVisible = false;

while (true)
{


    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if(key.Key == ConsoleKey.Enter)
        {
            break;
        }

        if(key.Key == ConsoleKey.DownArrow && ph + 6 < h)
        {
            ph++;
        }

        if (key.Key == ConsoleKey.UpArrow && ph - 6 > 0)
        {
            ph--;
        }

    }


    Console.CursorLeft = 0;
    Console.CursorTop = 0;
    Console.WriteLine( posH +" "+ f + " "+  posV + " " + u);
    
    Console.Clear();
    Console.WriteLine(miss.ToString());

    for (int i = 0; i < 6; i++)
    {
        Console.CursorTop = ph + i;
        Console.CursorLeft = 8;

        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(" ");
    }


    //Console.CursorTop = Math.Max(0, Math.Min((int)posV, Console.BufferHeight-1));       
    //Console.CursorLeft = Math.Max(0, Math.Min((int) posH, Console.BufferHeight-1));
    Console.CursorTop = (int) posV;
    Console.CursorLeft = (int) posH;
    
    Console.Write(" ");
    Console.ResetColor();
    if (posH > w-10) f = !f;
    if (posH < 10) { 
        f = !f; 
        if(!(posV >= ph-1 && posV <= ph+7)) 
            miss++;
    }

    if (posV > h - 10) u = !u;
    if (posV < 10) u = !u;


    

    

    posH = f ? posH++ : posH--;
    posV = u ? posV++ : posV--;
    Thread.Sleep(30);

    

}
