using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int z1 = 1, z2 = n;
        for (int red = 1; red <= n; red++)
        {
            for (int kol = 1; kol <= n; kol++)
            {
                if (kol == z1 || kol == z2)
                    Console.Write('*');
                else
                    Console.Write('.');
            }
            Console.WriteLine();
            z1++; z2--;
        }
    }
}