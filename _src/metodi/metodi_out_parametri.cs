using System;

class Program
{
    static void NadjiMax(int n, out int max, out int brPoj)
    {
        max = int.Parse(Console.ReadLine());
        brPoj = 1;
        for (int i = 1; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > max) { max = a; brPoj = 1; }
            else if (a == max) brPoj++;
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int max, k;
        NadjiMax(n, out max, out k);
        Console.WriteLine(max + " " + k);
    }
}