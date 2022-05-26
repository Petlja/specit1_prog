// test primalnosti - druga verzija
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool prost;
        if (n == 1) prost = false;
        else if (n == 2) prost = true;
        else
        {
            prost = true;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
        }

        Console.WriteLine(prost ? "DA" : "NE");
    }
}