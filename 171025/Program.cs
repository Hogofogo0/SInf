using System.Numerics;

double w = Console.WindowWidth;
double h = Console.WindowHeight;
double posH = 20;
double posV = 20;
bool f = true;
bool u = true;
Random random = new Random();
int ph = 20;
float speed = 1;
int miss = 0;

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
    //Console.WriteLine( posH +" "+ f + " "+  posV + " " + u);
    
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
    if (posH > w-10) f = false;
    if (posH < 10) { 
        f = true; 
        if(!(posV >= ph-1 && posV <= ph+7))
        {
            speed = Math.Max(speed - .2f, 0.1f);
            miss++;
        }
            
    }

    if (posV > h - 10) u = false;
    if (posV < 10) u = true;


    Random r = new Random();

    if (r.Next(0, 50) == 0) speed += 0.1f;
    

    posH = f ? posH += 2 * speed : posH-=2 * speed;
    posV = u ? posV+=1 : posV-=1;
    Thread.Sleep(30);

    

}
