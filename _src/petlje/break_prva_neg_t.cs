using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dan = -1;
        for (int i = 1; i <= n; i++)
        {
            int temperatura = int.Parse(Console.ReadLine());
            if (temperatura < 0)
            {
                dan = i;
                break;
            }
        }
        Console.WriteLine(dan);
    }
}
