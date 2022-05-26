using System;

class Program
{
    static void Main()
    {
        int d11 = int.Parse(Console.ReadLine());
        int d12 = int.Parse(Console.ReadLine());
        int d21 = int.Parse(Console.ReadLine());
        int d22 = int.Parse(Console.ReadLine());
        int d1 = d11 > d12 ? 10 * d11 + d12 : 10 * d12 + d11;
        int d2 = d21 > d22 ? 10 * d21 + d22 : 10 * d22 + d21;
        int d = d1 > d2 ? 100 * d1 + d2 : 100 * d2 + d1;
        Console.WriteLine(d);
    }
}
