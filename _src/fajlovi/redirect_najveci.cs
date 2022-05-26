using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int najveci = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            int sledeci = int.Parse(Console.ReadLine());
            if (najveci < sledeci)
                najveci = sledeci;
        }
        Console.WriteLine(najveci);
    }
}