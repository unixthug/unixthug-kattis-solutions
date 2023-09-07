using System;

class Program
{
    static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0) {
            Console.WriteLine("1");
        } else if (x < 0 && y > 0) {
            Console.WriteLine("2");
        } else if (x < 0 && y < 0) {
            Console.WriteLine("3");
        } else{
            Console.WriteLine("4");
        }
            
    }
}
