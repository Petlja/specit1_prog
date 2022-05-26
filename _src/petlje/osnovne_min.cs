using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int najmanji = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (najmanji > x)
                najmanji = x;
        }
        Console.WriteLine(najmanji);
    }
}
