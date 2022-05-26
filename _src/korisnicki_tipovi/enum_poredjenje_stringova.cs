using System;

class Program
{
    public static void Main()
    {
        string s1 = "Veliki", s2 = "VELIKI";
        Console.WriteLine(s1.Equals(s2));
        Console.WriteLine(s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
    }
}

