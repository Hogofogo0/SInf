int a, b, max;
Console.WriteLine("Enter two integers:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if(a > b)
    max = a;
else
    max = b;
Console.WriteLine($"{max} je větší");
