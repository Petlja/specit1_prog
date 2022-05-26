using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = 1; i <= n; i++)
        {
            int t = 0;
            for (int k = 1; k <= i; k++)
                t += k;

            p += t;
            Console.Write(p + " ");
        }
        Console.WriteLine();
    }
}