using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int brRazmaka1 = 0, brZvezdica = n + 1, brRazmaka2 = n - 1;
        for (int red = 1; red <= 2 * n; red++)
        {
            for (int i = 0; i < brRazmaka1; i++)
                Console.Write(' ');

            for (int i = 0; i < brZvezdica; i++)
                Console.Write('*');

            for (int i = 0; i < brRazmaka2; i++)
                Console.Write(' ');

            Console.Write("**");

            for (int i = 0; i < brRazmaka2; i++)
                Console.Write(' ');

            for (int i = 0; i < brZvezdica; i++)
                    Console.Write('*');

            Console.WriteLine();
            if (red < n)
            {
                brRazmaka1 += 2;
                brZvezdica--;
                brRazmaka2--;
            }
            else if (red > n)
            {
                brRazmaka1 -= 2;
                brZvezdica++;
                brRazmaka2++;
            }
        }
    }
}