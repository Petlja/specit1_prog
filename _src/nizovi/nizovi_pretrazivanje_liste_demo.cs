using System;
using System.Collections.Generic;

namespace PretrazivanjeListe
{
    class Program
    {
        static void IspisiListu(string komentar, List<int> a)
        {
            Console.Write(komentar); 
            foreach (int x in a)
                Console.Write("{0} ", x);

            Console.WriteLine();
        }

        static bool Paran(int x) { return x % 2 == 0; }

        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 9, 5, 3, 2, 7, 6, 13, 4};
            IspisiListu("Pocetna lista je: ", a);

            int i = a.FindIndex(Paran);
            Console.WriteLine("a.FindIndex(Paran) vraca {0}", i);

            i = a.FindIndex(5, Paran);
            Console.WriteLine("a.FindIndex(5, Paran) vraca {0}", i);

            i = a.FindIndex(1, 3, Paran);
            Console.WriteLine("a.FindIndex(1, 3, Paran) vraca {0}", i);

            i = a.FindLastIndex(Paran);
            Console.WriteLine("a.FindLastIndex(Paran) vraca {0}", i);

            i = a.FindLastIndex(7, Paran);
            Console.WriteLine("a.FindLastIndex(7, Paran) vraca {0}", i);

            i = a.FindLastIndex(7, 6, Paran);
            Console.WriteLine("a.FindLastIndex(7, 6, Paran) vraca {0}", i);

            List<int> b = a.FindAll(Paran);
            IspisiListu("a.FindAll(Paran) vraca listu: ", b);
        }
    }
}
