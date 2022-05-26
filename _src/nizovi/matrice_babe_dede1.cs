using System;

class Program
{
    static int[,] UcitajMatricu()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] a = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] str = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
                a[i, j] = int.Parse(str[j]);
        }
        return a;
    }

    static void IspisiMatricu(int[,] a)
    {
        int n = a.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write("{0} ", a[i,j]);
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] m = UcitajMatricu();
        int[,] t = UcitajMatricu();
        int n = m.GetLength(0);
        int[,] b = new int[n, n];
        int[,] d = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                b[i, j] = 0;
                for (int k = 0; k < n && (b[i, j] == 0); k++)
                {
                    if (m[i, k] == 1 && (m[k, j] == 1 || t[k, j] == 1))
                        b[i, j] = 1;
                }

                d[i, j] = 0;
                for (int k = 0; k < n && (d[i, j] == 0); k++)
                {
                    if (t[i, k] == 1 && (m[k, j] == 1 || t[k, j] == 1))
                        d[i, j] = 1;
                }
            }
        }
        Console.WriteLine("Babe:");
        IspisiMatricu(b);
        Console.WriteLine("Dede:");
        IspisiMatricu(d);
    }
}
