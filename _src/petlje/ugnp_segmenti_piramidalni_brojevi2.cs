using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int t = 0;
        int p = 0;
        for (int i = 1; i <= n; i++)
        {
            t += i;
            p += t;
            Console.Write(p + " ");
        }
        Console.WriteLine();
    }
}
