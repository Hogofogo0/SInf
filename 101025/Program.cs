int a = int.Parse(Console.ReadLine());


for(int i = a; i >=0; i--)
{
    
    for (int j = 0; j <= i; j++)
    {
        //Console.Write(i*j + new string(' ', (double) Math.Log10((double) a*a)-i*j/100));
        Console.Write("*");
    }
    Console.WriteLine();
}

for(int i = a; i>=0; i--)
{
    for(int j = 0;j <= i; j++)
    {
        Console.Write(" ");
    }
    for(int j = 0; j<= a-i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for(int i = 0; i <= a; i++)
{
    for( int j = 0; j <= a; j++)
    {
        if(j % 2 == 0 && i % 2 == 0)
        {
            Console.Write("||");
        }
        else if(j % 2 == 1 && i % 2 == 0)
        {
            Console.Write("  ");
        }else if(j % 2 == 1 && i % 2 == 1){
            Console.Write("||");
        }
        else { Console.Write("  "); }
    }
    Console.WriteLine();
}