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

        if (mali)
            if (crveni)
                if (popunjen)
                    if (krug) Console.WriteLine("mali crveni popunjen krug");
                    else Console.WriteLine("mali crveni popunjen kvadrat");
                else
                    if (krug) Console.WriteLine("mali crveni prazan krug");
                    else Console.WriteLine("mali crveni prazan kvadrat");
            else
                if (popunjen)
                    if (krug) Console.WriteLine("mali plavi popunjen krug");
                    else Console.WriteLine("mali plavi popunjen kvadrat");
                else
                    if (krug) Console.WriteLine("mali plavi prazan krug");
                    else Console.WriteLine("mali plavi prazan kvadrat");
        else
            if (crveni)
                if (popunjen)
                    if (krug) Console.WriteLine("veliki crveni popunjen krug");
                    else Console.WriteLine("veliki crveni popunjen kvadrat");
                else
                    if (krug) Console.WriteLine("veliki crveni prazan krug");
                    else Console.WriteLine("veliki crveni prazan kvadrat");
            else
                if (popunjen)
                    if (krug) Console.WriteLine("veliki plavi popunjen krug");
                    else Console.WriteLine("veliki plavi popunjen kvadrat");
                else
                    if (krug) Console.WriteLine("veliki plavi prazan krug");
                    else Console.WriteLine("veliki plavi prazan kvadrat");
    }
}
