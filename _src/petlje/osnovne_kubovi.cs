using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(x*x*x);
        }
    }
}
