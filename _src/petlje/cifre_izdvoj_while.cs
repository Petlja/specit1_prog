using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            int c = n % 10;
            Console.WriteLine(c);
            n = n / 10;
        }
    }
}
