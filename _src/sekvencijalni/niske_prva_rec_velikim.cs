using System;

class Program
{
    static void Main()
    {
        string recenica = Console.ReadLine();
        int pozPrvogRazmaka = recenica.IndexOf(' ');
        string prvaRec = recenica.Substring(0, pozPrvogRazmaka);
        string ostatakRecenice = recenica.Substring(pozPrvogRazmaka + 1);
        Console.WriteLine(prvaRec.ToUpper() + " " + ostatakRecenice);
    }
}
