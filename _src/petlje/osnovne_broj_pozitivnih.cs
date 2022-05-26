using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int brPoz = 0;
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
                brPoz++;
        }
        Console.WriteLine(brPoz);
    }
}
