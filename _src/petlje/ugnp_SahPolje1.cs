using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int red = 1; red <= n; red++)
        {
            for (int kolona = 1; kolona <= n; kolona++)
            {
                if ((red + kolona) % 2 == 0) Console.Write('X');
                else Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}