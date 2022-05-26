using System;

class Program
{
    static bool[,] UcitajMatricu()
    {
        int n = int.Parse(Console.ReadLine());
        bool[,] a = new bool[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] str = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
                a[i, j] = (str[j] == "1");
        }
        return a;
    }

    static void IspisiMatricu(bool[,] a)
    {
        int n = a.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(a[i, j] ? "1 " : "0 ");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        bool[,] mama = UcitajMatricu();
        bool[,] tata = UcitajMatricu();
        int n = mama.GetLength(0);
        bool[,] baba = new bool[n, n];
        bool[,] deda = new bool[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                baba[i, j] = false;
                for (int k = 0; k < n && !baba[i, j]; k++)
                {
                    if (mama[i, k] && (mama[k, j] || tata[k, j]))
                        baba[i, j] = true;
                }

                deda[i, j] = false;
                for (int k = 0; k < n && !deda[i, j]; k++)
                {
                    if (tata[i, k] && (mama[k, j] || tata[k, j]))
                        deda[i, j] = true;
                }
            }
        }
        Console.WriteLine("Babe:");
        IspisiMatricu(baba);
        Console.WriteLine("Dede:");
        IspisiMatricu(deda);
    }
}
