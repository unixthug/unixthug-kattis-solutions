using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();
        int n = int.Parse(nums[0]);
        int t = int.Parse(nums[1]);
        int m = int.Parse(nums[2]);
        
        Console.WriteLine(n * t * m);
    }
}
