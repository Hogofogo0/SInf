/*int a, b, max;
Console.WriteLine("Enter two integers:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if(a > b)
    max = a;
else
    max = b;
Console.WriteLine($"{max} je větší");
*/
// NAJDE NEJVETSI ZE 3
Console.WriteLine("Zadej cisla:");

int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int max = nums[0];
// O(1)
if (nums.Length == 3)
{
    if (nums[0] >= nums[1] && nums[0] >= nums[2])
        max = nums[0];
    else if (nums[1] >= nums[0] && nums[1] >= nums[2])
        max = nums[1];
    else
        max = nums[2];
}
else {
    foreach (int i in nums)
    {
        if (i > max)
            max = i;
    }
}


    // O(n)
    

Console.WriteLine($"{max} je nejvetsi cislo");

