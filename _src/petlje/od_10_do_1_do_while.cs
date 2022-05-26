using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Da li ste spremni?");
        int i = 10;
        do
        {
            Console.WriteLine(i);
            i--;
        } while (i > 0);

        Console.WriteLine("Polazak!");
    }
}
