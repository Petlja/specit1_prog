using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (b > 0)
        {
            int t = a % b;
            a = b;
            b = t;
        }
        Console.WriteLine(a);
    }
}