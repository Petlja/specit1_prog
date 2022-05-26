using System;

class Program
{
    static void Main(string[] args)
    {
        int zbir = 0;
        while (true)
        {
            string s = Console.ReadLine();
            if (s == ".")
                break;

            zbir += int.Parse(s);
        }
        Console.WriteLine(zbir);
    }
}