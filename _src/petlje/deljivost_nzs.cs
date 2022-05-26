using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int a1 = a, b1 = b;
        while (b1 > 0)
        {
            int t = a1 % b1;
            a1 = b1;
            b1 = t;
        }

        int nzd = a1;
        int nzs = a * (b / nzd);
        Console.WriteLine(nzs);
    }
}