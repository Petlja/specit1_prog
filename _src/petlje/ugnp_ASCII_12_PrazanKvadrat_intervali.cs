using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int kol = 1; kol <= n; kol++)
            Console.Write('*');
        Console.WriteLine();

        for (int red = 2; red <= n - 1; red++)
        {
            Console.Write('*');
            for (int kol = 2; kol <= n - 1; kol++)
                    Console.Write(' ');
            Console.WriteLine('*');
        }

        for (int kol = 1; kol <= n; kol++)
            Console.Write('*');
        Console.WriteLine();
    }
}