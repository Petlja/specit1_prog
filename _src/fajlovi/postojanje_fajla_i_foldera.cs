using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite putanju: ");
        string putanja = Console.ReadLine();

        if (File.Exists(putanja)) Console.WriteLine("Postoji fajl {0}.", putanja);
        else Console.WriteLine("Ne postoji fajl {0}.", putanja);

        if (Directory.Exists(putanja)) Console.WriteLine("Postoji folder {0}.", putanja);
        else Console.WriteLine("Ne postoji folder {0}.", putanja);
    }
}