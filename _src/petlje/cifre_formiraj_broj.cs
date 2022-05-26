using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = 0;
        for (int i =0; i < m; i++)
        {
            int c = int.Parse(Console.ReadLine());
            n = n * 10 + c;
        }
        Console.WriteLine(n);
    }
}
