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
                if (red == 1 || red == n || kol == 1 || kol == n)
                    Console.Write('*');
                else
                    Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}