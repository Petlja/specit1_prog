using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool sviPozitivni = true;
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x <= 0)
                sviPozitivni = false;
        }
        if (sviPozitivni)
            Console.WriteLine("da");
        else
            Console.WriteLine("ne");
    }
}
