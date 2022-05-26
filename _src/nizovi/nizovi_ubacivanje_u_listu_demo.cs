using System;
using System.Collections.Generic;

namespace UbacivanjeUListu
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

        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 2, 3 };
            IspisiListu("Pocetna lista je: ", a);

            a.Insert(1, 7);
            IspisiListu("Nakon a.Insert(1, 7), lista je: ", a);

            int[] b = { 21, 22 };
            a.InsertRange(3, b);
            IspisiListu("Nakon a.InsertRange(3, b), lista je: ", a);

            a.Add(9);
            IspisiListu("Nakon a.Add(9), lista je: ", a);

            int[] c = { 91, 92 };
            a.AddRange(c);
            IspisiListu("Nakon a.AddRange(c), lista je: ", a);
        }
    }
}
