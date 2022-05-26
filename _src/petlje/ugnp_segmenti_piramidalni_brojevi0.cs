// Veoma lose resenje
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int ip = 1; ip <= n; ip++)
        {
            int P = 0;
            for (int it = 1; it <= ip; it++)
            {
                int T = 0;
                for (int i = 1; i <= it; i++)
                    T += i;

                P += T;
            }
            Console.Write(P + " ");
        }
        Console.WriteLine();
    }
}
