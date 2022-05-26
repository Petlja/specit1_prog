using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        do
        {
            int c = n % 10;
            Console.WriteLine(c);
            n = n / 10;
        } while (n > 0);
    }
}
