using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int br2 = 0, br3 = 0, br4 = 0, br5 = 0;
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            double uspeh = double.Parse(s[0]);
            if (uspeh < 4.5)
                continue;

            int matem = int.Parse(s[1]);
            if (matem == 2) br2++;
            else if (matem == 3) br3++;
            else if (matem == 4) br4++;
            else if (matem == 5) br5++;
        }
        Console.WriteLine("{0} {1} {2} {3}", br2, br3, br4, br5);
    }
}
