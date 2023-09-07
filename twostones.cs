using System;

class Program
{
    static void Main(string[] args)
    {
        int stones = Convert.ToInt32(Console.ReadLine());
        if (stones % 2 == 0) {
            Console.WriteLine("Bob");
        } else {
            Console.WriteLine("Alice");
        }
    }
}
