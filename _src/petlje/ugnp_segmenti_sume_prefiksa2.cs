using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += i;
            Console.Write(s + " ");
        }
        Console.WriteLine();
    }
}
