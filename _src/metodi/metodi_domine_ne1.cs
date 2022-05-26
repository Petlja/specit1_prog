using System;

class Program
{
    static void Main()
    {
        int d11 = int.Parse(Console.ReadLine());
        int d12 = int.Parse(Console.ReadLine());
        int d21 = int.Parse(Console.ReadLine());
        int d22 = int.Parse(Console.ReadLine());
        int d1, d2, d;

        if (d11 > d12) d1 = 10 * d11 + d12;
        else d1 = 10 * d12 + d11;

        if (d21 > d22) d2 = 10 * d21 + d22;
        else d2 = 10 * d22 + d21;

        if (d1 > d2) d = 100 * d1 + d2;
        else d = 100 * d2 + d1;

        Console.WriteLine(d);
    }
}