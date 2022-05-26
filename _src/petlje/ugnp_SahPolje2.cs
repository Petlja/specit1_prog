using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int redTable = 1; redTable <= n; redTable++)
        {
            for (int redPolja = 1; redPolja <= 3; redPolja++)
            {
                for (int kolonaTable = 1; kolonaTable <= n; kolonaTable++)
                {
                    for (int kolonaPolja = 1; kolonaPolja <= 6; kolonaPolja++)
                    {
                        if ((redTable + kolonaTable) % 2 == 0) Console.Write('X');
                        else Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
