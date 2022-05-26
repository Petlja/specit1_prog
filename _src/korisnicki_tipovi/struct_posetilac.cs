using System;

class Program
{
    struct Posetilac
    {
        public string ime;
        public int h1, m1, s1, h2, m2, s2;
        public int TrajanjePosete
        {
            get { return 3600 * (h2 - h1) + 60 * (m2 - m1) + s2 - s1; }
        }
    }

    static Posetilac UnosPosetioca()
    {
        string[] tekst = Console.ReadLine().Split();
        Posetilac p = new Posetilac
        {
            ime = tekst[0],
            h1 = int.Parse(tekst[1]),
            m1 = int.Parse(tekst[2]),
            s1 = int.Parse(tekst[3]),
            h2 = int.Parse(tekst[4]),
            m2 = int.Parse(tekst[5]),
            s2 = int.Parse(tekst[6])
        };
        return p;
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Posetilac maksimalni = UnosPosetioca();
        for (int i = 1; i < n; i++)
        {
            Posetilac novi = UnosPosetioca();
            if (maksimalni.TrajanjePosete < novi.TrajanjePosete)
                maksimalni = novi;
        }
        Console.WriteLine("Najduze je ostao {0}, i to od {1}:{2}:{3} do {4}:{5}:{6}.",
            maksimalni.ime,
            maksimalni.h1, maksimalni.m1, maksimalni.s1,
            maksimalni.h2, maksimalni.m2, maksimalni.s2);
    }
}
