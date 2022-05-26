using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 4)
            if (n < 2)
                if (n < 1) Console.WriteLine("nulti");
                else Console.WriteLine("prvi");
            else 
                if (n < 3) Console.WriteLine("drugi");
                else Console.WriteLine("treci");
        else
            if (n < 6)
                if (n < 5) Console.WriteLine("cetvrti");
                else Console.WriteLine("peti");
            else
                if (n < 7) Console.WriteLine("sesti");
                else Console.WriteLine("sedmi");
    }
}
