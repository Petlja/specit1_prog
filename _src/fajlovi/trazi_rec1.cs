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
        StreamReader sr = new StreamReader(putanja);
        string linija;
        int brLinije = 0;
        int brojPojavljivanja = 0;
        char[] separatori = "[]() ;,.:{}+-*/=&!~^\"'".ToCharArray();
        while ((linija = sr.ReadLine()) != null)
        {
            brLinije++;
            string[] reci = linija.Split(separatori, StringSplitOptions.RemoveEmptyEntries);
            for (int brReci = 0; brReci < reci.Length; brReci++)
                if (trazenaRec == reci[brReci])
                {
                    Console.WriteLine("Linija {0} rec {1}", brLinije, brReci + 1);
                    brojPojavljivanja++;
                }
        }
        sr.Close();
        if (brojPojavljivanja > 0)
            Console.WriteLine("Ukupno {0} pojavljivanja.", brojPojavljivanja);
        else
            Console.WriteLine("Rec {0} se ne pojavljuje u navedenom fajlu", trazenaRec);
    }
}
