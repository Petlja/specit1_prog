using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kolika je solja?");
        double SOLJA = double.Parse(Console.ReadLine());
        Console.WriteLine("Koliko ima u bokalu?");
        double BOKAL = double.Parse(Console.ReadLine());
        double brSolja = Math.Round(BOKAL / SOLJA, 9);
        Console.WriteLine("Broj punih solja je {0}", Math.Floor(brSolja));
    }
}
