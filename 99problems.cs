using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Start...");
        int n = int.Parse(Console.ReadLine());
        int nn1 = 0;
        int nn2 = 0;
        string temp = "NULL";
        
        for (int i = 0 ; i <= 200 ; i++) {
            temp = Convert.ToString(i+n);
            if (temp.Contains("99")) {
                //Console.WriteLine("Step 1...");
                if (temp.Substring((temp.Length-2), 2).Contains("99")) {
                    nn1 = i+n;
                    //Console.WriteLine(nn1);
                    break;
                }
                continue;
            }
        }
        for (int i = 0 ; i <= 200 ; i++) {
            temp = Convert.ToString(n-i);
            if (temp.Contains("99")) {
                //Console.WriteLine("Step 2...");
                if (temp.Substring((temp.Length-2), 2).Contains("99")) {
                    nn2 = n-i;
                    //Console.WriteLine(nn2);
                    break;
                }
                continue;
            }
        }
        
        if (Math.Abs(nn1 - n) > Math.Abs(nn2 - n)) {
            //Console.WriteLine("CASE 1");
            Console.WriteLine(nn2);
        } else if (Math.Abs(nn1 - n) < Math.Abs(nn2 - n)) {
            //Console.WriteLine("CASE 2");
            Console.WriteLine(nn1);
        } else {
            //Console.WriteLine("CASE 3");
            if (nn1 > nn2) {
            Console.WriteLine(nn1);
            } else {
            Console.WriteLine(nn2);
            }
        }
    }
}
