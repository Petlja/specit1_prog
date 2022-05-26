using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int s = 0;
            for (int k = 1; k <= i; k++)
                s += k;

            Console.Write(s + " ");
        }
        Console.WriteLine();
    }
}
