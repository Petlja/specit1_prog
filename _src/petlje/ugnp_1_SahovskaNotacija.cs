using System;

class Program
{
    static void Main(string[] args)
    {
        for (int red = 8; red > 0; red--)
        {
            for (char kolona = 'A'; kolona <= 'H'; kolona++)
                Console.Write("{0}{1} ", kolona, red);
            Console.WriteLine();
        }
    }
}