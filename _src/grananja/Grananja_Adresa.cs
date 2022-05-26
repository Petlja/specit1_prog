using System;

class Program
{
    static void Main()
    {
        int ulaz = int.Parse(Console.ReadLine());
        if (ulaz % 2 == 1)
        {
            // A: 1-73, B: 75-129, C: 131-225, D: 227-299
            if (ulaz < 74)
                Console.WriteLine("A");
            else if (ulaz < 130)
                Console.WriteLine("B");
            else if (ulaz < 226)
                Console.WriteLine("C");
            else
                Console.WriteLine("D");
        }
        else
        {
            // E: 2-58, F: 60-144, G: 146-216, H: 218-280
            if (ulaz < 59)
                Console.WriteLine("E");
            else if (ulaz < 145)
                Console.WriteLine("F");
            else if (ulaz < 217)
                Console.WriteLine("G");
            else
                Console.WriteLine("H");
        }
    }
}
