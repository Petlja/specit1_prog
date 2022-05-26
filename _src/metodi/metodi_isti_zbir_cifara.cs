using System;

class Program
{
    static int ZbirCifara(int n)
    {
        int rez = 0;
        while (n > 0)
        {
            rez += n % 10;
            n /= 10;
        }
        return rez;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine()));
        int b = int.Parse(Console.ReadLine()));
        if (ZbirCifara(a) == ZbirCifara(b))
            Console.WriteLine("DA");
        else
            Console.WriteLine("NE");
    }
}
