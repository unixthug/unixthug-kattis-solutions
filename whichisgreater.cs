using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split();
        int a = int.Parse(nums[0]);
        int b = int.Parse(nums[1]);
        if (a > b) {
            Console.WriteLine(1);
        } else {
            Console.WriteLine(0);
        }
    }
}
