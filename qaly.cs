using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] nums = new string[n*2];
        string temp;
        int index;
        double qaly, yrs;
        double tqaly = 0;
        for (int count = 0 ; count < n ; count++) {
            temp = Console.ReadLine();
            index = temp.IndexOf(' ');
            for (int i = 0 ; i < n*2; i++) {
                if (nums[i] == null) {
                nums[i] = temp.Substring(0, index);
                nums[i+1] = temp.Substring(index+1);
                qaly = Convert.ToDouble(nums[i]);
                yrs = Convert.ToDouble(nums[i+1]);
                tqaly += (qaly * yrs);
                break;
                }
            }
        }
        Console.WriteLine(tqaly);
    }
}
