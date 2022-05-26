using System;

class Program
{
    static void Main()
    {
        int mat = int.Parse(Console.ReadLine());
        int eng = int.Parse(Console.ReadLine());
        int hem = int.Parse(Console.ReadLine());
        if (mat < 4)
            Console.WriteLine("Uci matematiku");
        else if (eng < 4)
             Console.WriteLine("Uci engleski");
        else if (hem < 4)
            Console.WriteLine("Uci hemiju");
    }
}
