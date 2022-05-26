using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Ispisi(IEnumerable<string> spisak)
    {
        foreach (string ime in spisak)
        {
            Console.WriteLine(ime);
        }
        Console.WriteLine("Pritisnite Enter za nastavak");
        string pauza = Console.ReadLine();
    }

    static void Main()
    {
        Console.WriteLine("Unesite putanju: ");
        string putanja = Console.ReadLine();

        Console.WriteLine("Folderi");
        Ispisi(Directory.EnumerateDirectories(putanja, "*.*", SearchOption.AllDirectories));

        Console.WriteLine("Fajlovi");
        Ispisi(Directory.EnumerateFiles(putanja, "*.*", SearchOption.AllDirectories));

        Console.WriteLine("Sve zajedno");
        Ispisi(Directory.EnumerateFileSystemEntries(putanja, "*.*", SearchOption.AllDirectories));
    }
}
