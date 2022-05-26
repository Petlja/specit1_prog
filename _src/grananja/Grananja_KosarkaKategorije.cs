using System;

class Program
{
    static void Main()
    {
        int godine = int.Parse(Console.ReadLine());
        if (godine <= 10)
            Console.WriteLine("Bez kategorije");
        else if (godine <= 12)
             Console.WriteLine("Mladji pioniri");
        else if (godine <= 14)
            Console.WriteLine("Pioniri");
        else if (godine <= 16)
            Console.WriteLine("Kadeti");
        else if (godine <= 18)
            Console.WriteLine("Juniori");
        else
            Console.WriteLine("Seniori");
    }
}
