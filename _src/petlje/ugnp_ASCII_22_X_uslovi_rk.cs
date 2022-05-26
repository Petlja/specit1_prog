using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int red = 1; red <= n; red++)
        {
            for (int kol = 1; kol <= n; kol++)
            {
                if (kol == red || kol + red == n + 1)
                    Console.Write('*');
                else
                    Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}
