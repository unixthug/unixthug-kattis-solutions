using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();
        int r1 = Convert.ToInt32(nums[0]);
        int s = Convert.ToInt32(nums[1]);
        
        Console.WriteLine((s*2) - r1);
    }
}
