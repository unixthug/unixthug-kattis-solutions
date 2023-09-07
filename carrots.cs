using System;

class Program
{
    static void Main(string[] args)
    {
        string nulllines;
        string[] nums = Console.ReadLine().Split();
        int num1 = Convert.ToInt32(nums[0]);
        int num2 = Convert.ToInt32(nums[1]);
        for (int i = 0 ; i < num1 ; i++) {
            nulllines = Console.ReadLine();
        }
        Console.Write(num2);
    }
}
