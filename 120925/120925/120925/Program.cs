class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tak dobrý den, já se jmenuji:");
        string? a = Console.ReadLine();

        Console.WriteLine($"Oh hello there {a}");
        Console.WriteLine("Kdy ses narodil(a)?");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Aha, takže je ti {getAge(b)} let.");
    }

    static int getAge(int birth)
    {
        return DateTime.Now.Year-birth;
    }
}





