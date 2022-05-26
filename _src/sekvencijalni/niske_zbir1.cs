using System;

class Program
{
    static void Main()
    {
        string [] s = Console.ReadLine().Split('+');
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);
        Console.WriteLine(a + b + c);
    }
}
