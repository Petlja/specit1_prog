using System;

namespace Sudoku
{
    class Program
    {
        static void IspisiTablu(string s)
        {
            int p = 0;
            string linija = "+---+---+---+";
            Console.WriteLine(linija);
            for (int grupaRedova = 0; grupaRedova < 3; grupaRedova++)
            {
                for (int red = 0; red < 3; red++)
                {
                    for (int grupaKolona = 0; grupaKolona < 3; grupaKolona++)
                    {
                        Console.Write("|");
                        Console.Write(s.Substring(p, 3));
                        p += 3;
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine(linija);
            }
        }

        static void Main(string[] args)
        {
            string s =
                ".71..4..." +
                "...2981.." +
                ".2...7..3" +
                "64.8..379" +
                ".1.....4." +
                "789..5.12" +
                "4..9...3." +
                "..7416..." +
                "...7..86.";
            IspisiTablu(s);
        }
    }
}
