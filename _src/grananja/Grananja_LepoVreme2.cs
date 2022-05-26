using System;

class Program
{
    static void Main()
    {
        bool biloLepoVreme = false;

        int tempBeograd = int.Parse(Console.ReadLine());
        int tempNoviSad = int.Parse(Console.ReadLine());
        int tempNis = int.Parse(Console.ReadLine());

        if (tempBeograd >= 20 && tempBeograd <= 27)
        {
            Console.WriteLine("Beograd: {0}", tempBeograd);
            biloLepoVreme = true;
        }
        if (!biloLepoVreme && tempNoviSad >= 20 && tempNoviSad <= 27)
        {
            Console.WriteLine("Novi Sad: {0}", tempNoviSad);
            biloLepoVreme = true;
        }
        if (!biloLepoVreme && tempNis >= 20 && tempNis <= 27)
        {
            Console.WriteLine("Nis: {0}", tempNis);
            biloLepoVreme = true;
        }

        if (!biloLepoVreme)
            Console.WriteLine("Nije bilo lepo vreme.");
    }
}
