using System;

class Program {
    static void Main(string[] args) {
        string[] nums = Console.ReadLine().Split();
        double h = Convert.ToDouble(nums[0]);
        double b = Convert.ToDouble(nums[1]);
        Console.WriteLine(0.5*(b*h));
    }
}
