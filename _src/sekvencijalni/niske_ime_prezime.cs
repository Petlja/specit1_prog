using System;

class Program
{
    static void Main()
    {
        string [] s = Console.ReadLine().Split();
        string prezime = s[0];
        string ime = s[1];
        Console.WriteLine(ime + " " + prezime);
    }
}
