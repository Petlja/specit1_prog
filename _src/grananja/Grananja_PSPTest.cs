using System;

class Program
{
    static void Main()
    {
        int polozili = 0;
        int poeni;

        poeni = int.Parse(Console.ReadLine());
        if (poeni <= 3)
            polozili++;

        poeni = int.Parse(Console.ReadLine());
        if (poeni <= 3)
            polozili++;

        poeni = int.Parse(Console.ReadLine());
        if (poeni <= 3)
            polozili++;

        poeni = int.Parse(Console.ReadLine());
        if (poeni <= 3)
            polozili++;

        Console.WriteLine("Test je polozilo {0} kandidata", polozili);
    }
}
