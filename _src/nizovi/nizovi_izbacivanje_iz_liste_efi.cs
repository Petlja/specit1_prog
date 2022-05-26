using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace IzbacivanjeIzListe
{
    class Program
    {
        static void IzbaciNegativne1(List<int> a)
        {
            int i = 0;
            while (i < a.Count)
                if (a[i] < 0) a.RemoveAt(i);
                else i++;
        }

        static void IzbaciNegativne2(List<int> a)
        {
            int n = 0;
            for (int i = 0; i < a.Count; i++)
                if (a[i] >= 0)
                {
                    a[n] = a[i];
                    n++;
                }

            a.RemoveRange(n, a.Count - n);
        }

        static void IzbaciNegativne3(List<int> a)
        {
            a.RemoveAll(x => x < 0);
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Stopwatch t = new Stopwatch();

            a.AddRange(Enumerable.Repeat(-1, 100000));
            a.AddRange(Enumerable.Repeat(1, 900000));
            Console.Write("IzbaciNegativne1: ");
            t.Start(); IzbaciNegativne1(a); t.Stop();
            Console.WriteLine(t.Elapsed);
            t.Reset();

            a.Clear();
            a.AddRange(Enumerable.Repeat(-1, 100000));
            a.AddRange(Enumerable.Repeat(1, 900000));
            Console.Write("IzbaciNegativne2: ");
            t.Start(); IzbaciNegativne2(a); t.Stop();
            Console.WriteLine(t.Elapsed);
            t.Reset();

            a.Clear();
            a.AddRange(Enumerable.Repeat(-1, 100000));
            a.AddRange(Enumerable.Repeat(1, 900000));
            Console.Write("IzbaciNegativne3: ");
            t.Start(); IzbaciNegativne3(a); t.Stop();
            Console.WriteLine(t.Elapsed);
            t.Reset();
        }
    }
}
