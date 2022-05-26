using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int z1 = n, z2 = n, z3 = 1;
        for (int red = 1; red <= 2*n; red++)
        {
            for (int kol = 1; kol <= n; kol++) Console.Write((kol == z1 ? '*' : ' '));
            Console.Write(' ');
            for (int kol = 1; kol <= n; kol++) Console.Write((kol == z2 ? '*' : ' '));
            Console.Write(' ');
            for (int kol = 1; kol <= n; kol++) Console.Write((kol == z3 ? '*' : ' '));
            Console.WriteLine();
            if (red < n) { z1--; z3++; }
            else if (red > n) { z1++; z3--; }
            if (red % 2 == 0) z2--;
        }
    }
}