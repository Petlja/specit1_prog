using System;

class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Unesite cele brojeve u komandnoj liniji");
        }
        int s = 0;
        for (int i = 0; i < args.Length; i++)
            s += int.Parse(args[i]);

        Console.WriteLine(s);
    }
}
