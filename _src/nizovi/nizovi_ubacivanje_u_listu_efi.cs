using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace UbacivanjeUListu
{
    class Program
    {
        static void f1(List<int> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == 0)
                {
                    a.Insert(i, 0);
                    i++;
                }
            }
        }

        static void f2(List<int> a)
        {
            int pocDuzina = a.Count;
            int brojNula = 0;
            foreach (var x in a)
                if (x == 0)
                    brojNula++;
            a.AddRange(Enumerable.Repeat(0, brojNula));
            int k = pocDuzina + brojNula;
            for (int i = pocDuzina - 1; i >= 0; i--)
            {
                k--;
                a[k] = a[i];
                if (a[i] == 0)
                {
                    k--;
                    a[k] = 0;
                }
            }
        }

        static List<int> f3(List<int> a)
        {
            var b = new List<int>();
            foreach (int x in a)
            {
                b.Add(x);
                if (x == 0) b.Add(x);
            }
            return b;
        }


        static void Main(string[] args)
        {
            List<int> a;
            Stopwatch t = new Stopwatch();
            int N = 1000000;

            a = Enumerable.Repeat(0, N).ToList();
            Console.Write("f1: ");
            t.Start();
            f1(a);
            t.Stop();
            Console.WriteLine(t.Elapsed);
            t.Reset();

            a = Enumerable.Repeat(0, N).ToList();
            Console.Write("f2: ");
            t.Start();
            f2(a);
            t.Stop();
            Console.WriteLine(t.Elapsed);
            t.Reset();

            a = Enumerable.Repeat(0, N).ToList();
            Console.Write("f3: ");
            t.Start();
            a = f3(a);
            t.Stop();
            Console.WriteLine(t.Elapsed);
            t.Reset();
        }
    }
}
