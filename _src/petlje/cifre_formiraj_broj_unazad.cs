using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = 0;
        int tezina = 1;
        for (int i =0; i < m; i++)
        {
            int c = int.Parse(Console.ReadLine());
            n = c * tezina + n;
            tezina = tezina * 10;
        }
        Console.WriteLine(n);
    }
}