using System;

class Program
{
    static int Spoji(int x, int y, int mesnaVrednost)
    {
        if (x > y) return mesnaVrednost * x + y;
        else return mesnaVrednost * y + x;
    }

    static void Main()
    {
        int d11 = int.Parse(Console.ReadLine());
        int d12 = int.Parse(Console.ReadLine());
        int d21 = int.Parse(Console.ReadLine());
        int d22 = int.Parse(Console.ReadLine());
        Console.WriteLine(Spoji(Spoji(d11, d12, 10), Spoji(d21, d22, 10), 100));
    }
}
