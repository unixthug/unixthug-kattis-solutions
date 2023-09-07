using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0) {
            Console.WriteLine("second");
        } else {
            Console.WriteLine("first");
        }
    }
}
