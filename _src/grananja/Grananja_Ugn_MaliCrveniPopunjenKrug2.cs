using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mali?");
        bool mali = (Console.ReadLine() == "d");
        Console.WriteLine("Crveni?");
        bool crveni = (Console.ReadLine() == "d");
        Console.WriteLine("Popunjen?");
        bool popunjen = (Console.ReadLine() == "d");
        Console.WriteLine("Krug?");
        bool krug = (Console.ReadLine() == "d");

        Console.Write(mali ? "mali " : "veliki ");
        Console.Write(crveni ? "crveni " : "plavi ");
        Console.Write(popunjen ? "popunjen " : "prazan ");
        Console.WriteLine(krug ? "krug" : "kvadrat");
    }
}
