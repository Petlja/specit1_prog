using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rBrPoslPoz = -1;
        for (int i = 1; i <= n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > 0 && rBrPoslPoz == -1)
                rBrPoslPoz = i;
        }
        Console.WriteLine(rBrPoslPoz);
    }
}
