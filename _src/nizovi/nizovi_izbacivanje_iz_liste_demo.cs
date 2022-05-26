using System;
using System.Collections.Generic;

namespace IzbacivanjeIzListe
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
            List<int> a = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1 };
            IspisiListu("Pocetna lista je: ", a);

            if (a.Remove(3))
                IspisiListu("Nakon a.Remove(3), lista je: ", a);

            a.RemoveAt(0);
            IspisiListu("Nakon a.RemoveAt(0), lista je: ", a);

            int izbaceno = a.RemoveAll(Paran);
            IspisiListu("Nakon a.RemoveAll(Paran), lista je: ", a);
            Console.WriteLine("Broj izbacenih elemenata: {0}", izbaceno);

            a.RemoveRange(1, 3);
            IspisiListu("Nakon a.RemoveRange(1, 3), lista je: ", a);
        }
    }
}
