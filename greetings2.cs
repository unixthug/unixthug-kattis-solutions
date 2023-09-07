using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string e = "";
        char ch = 'e';
        int freq = str.Count(f => (f == ch));
        for (int i = 0 ; i < freq * 2 ; i++ ) {
            e += "e";
        }
        Console.WriteLine("h" + e + "y");
    }
}
