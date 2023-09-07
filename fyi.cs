using System;

class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        string area = number.Substring(0, 3);
        if (area == "555") {
            Console.WriteLine(1);
        } else {
            Console.WriteLine(0);
        }
    }
}
