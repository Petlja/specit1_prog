using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double r = Math.Sqrt(n) * Math.Sqrt(n);
        Console.WriteLine(r - n);
        Console.WriteLine(Math.Floor(r));
        Console.WriteLine(r);
        Console.WriteLine(Math.Ceiling(r));
    }
}
