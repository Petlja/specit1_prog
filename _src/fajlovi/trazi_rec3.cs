using System;
using System.IO;

class Program
{

    static void Main()
    {
        Console.WriteLine("Koju rec trazite? ");
        string trazenaRec = Console.ReadLine();
        Console.WriteLine("U kom falju trazite (navedite celu putanju)? ");
        string putanja = Console.ReadLine();

        int brLinije = 0;
        int brojPojavljivanja = 0;
        char[] separatori = "[]() ;,.:{}+-*/=&!~^\"'".ToCharArray();

        foreach (string linija in File.ReadLines(putanja))
        {
            brLinije++;
            string[] reci = linija.Split(separatori, StringSplitOptions.RemoveEmptyEntries);
            for (int brReci = 0; brReci < reci.Length; brReci++)
            {
                if (trazenaRec == reci[brReci])
                {
                    Console.WriteLine("Linija {0} rec {1}", brLinije, brReci + 1);
                    brojPojavljivanja++;
                }
            }
        }

        if (brojPojavljivanja > 0)
            Console.WriteLine("Ukupno {0} pojavljivanja.", brojPojavljivanja);
        else
            Console.WriteLine("Rec {0} se ne pojavljuje u navedenom fajlu", trazenaRec);
    }
}
