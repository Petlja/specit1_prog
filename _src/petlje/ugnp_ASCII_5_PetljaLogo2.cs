using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int z1 = n, z2 = 2 * n + 1, z3 = 2 * n + 3;
        for (int red = 1; red <= 2 * n; red++)
        {
            for (int kol = 1; kol <= 3 * n + 2; kol++)
            {
                if (kol == z1 || kol == z2 || kol == z3) Console.Write('*');
                else Console.Write(' ');
            }
            Console.WriteLine();
            if (red < n) { z1--; z3++; }
            else if (red > n) { z1++; z3--; }
            if (red % 2 == 0) z2--;
        }
    }
}