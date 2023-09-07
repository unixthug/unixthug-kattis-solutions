using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0 ; i < n ; i++) {
            sum += Convert.ToInt32(Console.ReadLine());
        }
        Console.Write(sum - (n - 1));
    }
}
