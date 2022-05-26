using System;

class Program
{
    public static void Main()
    {
        double x = 2.5;
        double x_zaokr1 = Math.Round(x, MidpointRounding.AwayFromZero);
        double x_zaokr2 = Math.Round(x, MidpointRounding.ToEven);
        Console.WriteLine(x_zaokr1);
        Console.WriteLine(x_zaokr2);
    }
}
