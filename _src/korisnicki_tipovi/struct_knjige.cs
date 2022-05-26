using System;
using System.Collections.Generic;

class Program
{
    struct Knjiga
    {
        public string autor;
        public string naslov;
        public string oblast;
        public int brStrana;
    };

    public static void Main()
    {
        int brKnjiga = int.Parse(Console.ReadLine());
        Knjiga k;
        List<Knjiga> knjige = new List<Knjiga>();
        for (int i = 0; i < brKnjiga; i++)
        {
            string[] tekst = Console.ReadLine().Split(',');
            k.autor = tekst[0].Trim();
            k.naslov = tekst[1].Trim();
            k.oblast = tekst[2].Trim();
            k.brStrana = int.Parse(tekst[3].Trim());
            knjige.Add(k);
        }
        int brUpita = int.Parse(Console.ReadLine());
        for (int i = 0; i < brUpita; i++)
        {
            string upit = Console.ReadLine();
            int ukupnoStrana = 0;
            foreach (Knjiga knjiga in knjige)
            {
                if (knjiga.autor.Contains(upit))
                {
                    Console.WriteLine("{0}: {1}, {2} str.",
                        knjiga.oblast, knjiga.naslov, knjiga.brStrana);
                    ukupnoStrana += knjiga.brStrana;
                }
            }
            Console.WriteLine("Ukupno {0} str.", ukupnoStrana);
        }
    }
}
