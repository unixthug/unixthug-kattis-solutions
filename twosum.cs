using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();
        Console.WriteLine(Convert.ToInt32(nums[0]) + Convert.ToInt32(nums[1]));
    }
}
