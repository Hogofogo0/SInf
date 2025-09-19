int a, b, max;
Console.WriteLine("Enter two integers:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
max = Math.Max(a, b);
Console.WriteLine($"{max} je větší");
