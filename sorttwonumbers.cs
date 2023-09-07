using System;

class Program
{
    static void Main(string[] args)
    {
        string[] num = Console.ReadLine().Split();
        int a = int.Parse(num[0]);
        int b = int.Parse(num[1]);
        if (a < b) {
            Console.WriteLine(a + " " + b);
        } else {
            Console.WriteLine(b + " " + a);
        }
    }
}
