using System;

class Program
{
    static void Main()
    {
        int tempBeograd = int.Parse(Console.ReadLine());
        int tempNoviSad = int.Parse(Console.ReadLine());
        int tempNis = int.Parse(Console.ReadLine());

        if (tempBeograd >= 20 && tempBeograd <= 27)
            Console.WriteLine("Beograd: {0}", tempBeograd);
        else if (tempNoviSad >= 20 && tempNoviSad <= 27)
            Console.WriteLine("Novi Sad: {0}", tempNoviSad);
        else if (tempNis >= 20 && tempNis <= 27)
            Console.WriteLine("Nis: {0}", tempNis);
        else
            Console.WriteLine("Nije bilo lepo vreme.");
    }
}
