using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int zbirPoz = 0;
        int brojPoz = 0;
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                brojPoz++;
                zbirPoz += x;
            }
        }
        if (brojPoz > 0)
            Console.WriteLine((double)zbirPoz / brojPoz);
        else
            Console.WriteLine("Nema pozitivnih");
    }
}
