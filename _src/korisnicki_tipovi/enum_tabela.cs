using System;

class Program
{
    private static void Linija(int brKolona, int sirinaKolone, string uzorak)
    {
        char pocetni = uzorak[0];  // pre svih kolona
        char kolona = uzorak[1];
        char granica1 = uzorak[2]; // posle prve kolone
        char granica2 = uzorak[3]; // posle ostalih kolona
        char zavrsni = uzorak[4];  // posle svih kolona
        
        for (int i = 0; i < brKolona; i++)
        {
            if (i == 0)
                Console.Write(pocetni);
            else if (i == 1)
                Console.Write(granica1);
            else
                Console.Write(granica2);
            Console.Write(new string(kolona, sirinaKolone));
        }
        Console.WriteLine(zavrsni);
    }

    public enum StilOkvira
    {
        Jednostruki,
        Dvostruki,
        PrviRedDvostruki,
        PrvaKolonaDvostruki,
    }

    public static void Tabela(int brRedova, int brKolona, int visinaReda, int sirinaKolone, StilOkvira stil)
    {
        string uzorakPocetniRed = "┌─┬┬┐"; // pre prvog reda tabele
        string uzorakSrednjiRed = "│ │││"; 
        string uzorakLinija1Red = "├─┼┼┤"; // posle prvog reda tabele
        string uzorakLinija2Red = "├─┼┼┤"; // posle ostalih redova tabele
        string uzorakZavrsniRed = "└─┴┴┘"; // posle svih redova tabele
        switch (stil)
        {
            case StilOkvira.Jednostruki:
                uzorakPocetniRed = "┌─┬┬┐";
                uzorakSrednjiRed = "│ │││";
                uzorakLinija1Red = "├─┼┼┤";
                uzorakLinija2Red = "├─┼┼┤";
                uzorakZavrsniRed = "└─┴┴┘";
                break;
            case StilOkvira.Dvostruki:
                uzorakPocetniRed = "╔═╦╦╗";
                uzorakSrednjiRed = "║ ║║║";
                uzorakLinija1Red = "╠═╬╬╣";
                uzorakLinija2Red = "╠═╬╬╣";
                uzorakZavrsniRed = "╚═╩╩╝";
                break;
            case StilOkvira.PrviRedDvostruki:
                uzorakPocetniRed = "╒═╤╤╕";
                uzorakSrednjiRed = "│ │││";
                uzorakLinija1Red = "╞═╪╪╡";
                uzorakLinija2Red = "├─┼┼┤";
                uzorakZavrsniRed = "└─┴┴┘";
                break;
            case StilOkvira.PrvaKolonaDvostruki:
                uzorakPocetniRed = "╓─╥┬┐";
                uzorakSrednjiRed = "║ ║││";
                uzorakLinija1Red = "╟─╫┼┤";
                uzorakLinija2Red = "╟─╫┼┤";
                uzorakZavrsniRed = "╙─╨┴┘ ";
                break;
        }
        for (int redTabele = 0; redTabele < brRedova; redTabele++)
        {
            if (redTabele == 0)
                Linija(brKolona, sirinaKolone, uzorakPocetniRed);
            else if (redTabele == 1)
                Linija(brKolona, sirinaKolone, uzorakLinija1Red);
            else
                Linija(brKolona, sirinaKolone, uzorakLinija2Red);

            for (int redTeksta = 0; redTeksta < visinaReda; redTeksta++)
                Linija(brKolona, sirinaKolone, uzorakSrednjiRed);
        }
        Linija(brKolona, sirinaKolone, uzorakZavrsniRed);
        Console.WriteLine();
    }

    public static void Main()
    {
        Tabela(3, 4, 2, 5, StilOkvira.Jednostruki);
        Tabela(3, 4, 2, 5, StilOkvira.Dvostruki);
        Tabela(3, 4, 2, 5, StilOkvira.PrviRedDvostruki);
        Tabela(3, 4, 2, 5, StilOkvira.PrvaKolonaDvostruki);
    }
}
