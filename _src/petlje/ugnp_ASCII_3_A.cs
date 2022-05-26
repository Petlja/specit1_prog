using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int z1 = n, z2 = n + 1;
        for (int red = 1; red <= n; red++)
        {
            for (int kol = 1; kol <= 2 * n; kol++)
            {
                if (kol == z1 || kol == z2 || (red == n - n / 3 && kol > z1 && kol < z2))
                    Console.Write('*');
                else
                    Console.Write('.');
            }
            Console.WriteLine();
            z1--; z2++;
        }
    }
}