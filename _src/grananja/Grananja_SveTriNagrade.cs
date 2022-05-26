using System;

class Program
{
    static void Main()
    {
        int pocetak, kraj;
        pocetak = int.Parse(Console.ReadLine());
        kraj = int.Parse(Console.ReadLine());
        int najveciPocetak = pocetak, najmanjiKraj = kraj;

        pocetak = int.Parse(Console.ReadLine());
        kraj = int.Parse(Console.ReadLine());
        najveciPocetak = Math.Max(najveciPocetak, pocetak);
        najmanjiKraj = Math.Min(najmanjiKraj, kraj);

        pocetak = int.Parse(Console.ReadLine());
        kraj = int.Parse(Console.ReadLine());
        najveciPocetak = Math.Max(najveciPocetak, pocetak);
        najmanjiKraj = Math.Min(najmanjiKraj, kraj);

        if (najmanjiKraj >= najveciPocetak)
            Console.WriteLine(najmanjiKraj + 1 - najveciPocetak);
        else
            Console.WriteLine(0);
    }
}
