using System;

class Program
{
    public enum RezultatPretvaranja
    {
        Uspeh,
        PrvaJedinicaNepoznata,
        DrugaJedinicaNepoznata,
        ObeJediniceNepoznate
    }

    static string[] jediniceDuzine = { "mm", "cm", "m", "km", "in", "ft", "yd", "mi", "nmi" };
    static double[] velicineDuzine = { 0.001, 0.01, 1, 1000, 0.0254, 0.3048, 0.9144, 1609.344, 1852 };

    static string[] jediniceMase = { "g", "kg", "oz", "lb", "t" };
    static double[] velicineMase = { 0.001, 1, 0.02835, 0.454, 1000 };

    static string[] jediniceZapremine = { "ml", "l", "m3", "in3", "ft3", "pt", "qt", "gal", "bbl" };
    static double[] velicineZapremine = { 0.000001, 0.001, 1, 0.000016387064, 0.028316846592,
            0.000473176473, 0.000946352946, 0.003785411784, 0.119240471196 };

    public static RezultatPretvaranja Pretvori(
        string[] naziviJedinica, 
        double[] velicine,
        string polaznaJedinica, 
        string ciljnaJedinica, 
        double polaznaVelicina,
        out double ciljnaVelicina)
    {
        // Potrazi zadate jednice u spisku
        int iPolazno = Array.IndexOf(naziviJedinica, polaznaJedinica);
        int iCiljno = Array.IndexOf(naziviJedinica, ciljnaJedinica);
        if (iPolazno >= 0 && iCiljno >= 0) // ako su obe jedinice nadjene
        {
            ciljnaVelicina = polaznaVelicina * velicine[iPolazno] / velicine[iCiljno];
            return RezultatPretvaranja.Uspeh;
        }

        ciljnaVelicina = 0;

        if (iCiljno >= 0)
            return RezultatPretvaranja.PrvaJedinicaNepoznata;

        if (iPolazno >= 0)
            return RezultatPretvaranja.DrugaJedinicaNepoznata;

        return RezultatPretvaranja.ObeJediniceNepoznate;
    }

    public static void IspisiJedinice(string zaSta, string[] jedinice)
    {
        Console.Write("Jedinice {0}:", zaSta);
        foreach (string jedinica in jedinice)
            Console.Write(" {0}", jedinica);
        Console.WriteLine();
    }

    public static void Upotreba()
    {
        Console.WriteLine("Upotreba: pretvori <iz_jedinica> <u_jedinice> <broj>");
        Console.WriteLine("Na primer: pretvori in mm 1.5");

        IspisiJedinice("za duzinu", jediniceDuzine);
        IspisiJedinice("za masu", jediniceMase);
        IspisiJedinice("za zapreminu", jediniceZapremine);
    }

    public static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Upotreba();
            return;
        }
        double x = 0, y = 0;
        if (!double.TryParse(args[2], out x))
        {
            Console.WriteLine("Treci parametar treba da bude broj");
            Upotreba();
            return;
        }

        string polaznaJedinica = args[0];
        string ciljnaJedinica = args[1];
        string[][] jedinice = { jediniceDuzine, jediniceMase, jediniceZapremine };
        double[][] velicine = { velicineDuzine, velicineMase, velicineZapremine };
        RezultatPretvaranja rez = RezultatPretvaranja.Uspeh;
        for (int i = 0; i < jedinice.Length; i++)
        {
            rez = Pretvori(jedinice[i], velicine[i], polaznaJedinica, ciljnaJedinica, x, out y);
            if (rez != RezultatPretvaranja.ObeJediniceNepoznate)
                break; // Bar jedna jedinica je prepoznata, u pravom smo spisku jedinica
        }
           
        if (rez == RezultatPretvaranja.Uspeh)
            Console.WriteLine("{0} {1} = {2} {3}", x, polaznaJedinica, y, ciljnaJedinica);
        else if (rez == RezultatPretvaranja.PrvaJedinicaNepoznata)
            Console.WriteLine("Nepoznata jedinica: {0}", polaznaJedinica);
        else if (rez == RezultatPretvaranja.DrugaJedinicaNepoznata)
            Console.WriteLine("Nepoznata jedinica: {0}", ciljnaJedinica);
        else
            Console.WriteLine("Nepoznate jedinice {0} i {1}", polaznaJedinica, ciljnaJedinica);

        // Ako je preracunavanje bilo neuspesno, uputiti korisnika
        if (rez != RezultatPretvaranja.Uspeh)
            Upotreba();
    }
}