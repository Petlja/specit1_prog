using System;
using System.Collections.Generic;

namespace KapacitetListe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            int prethodniKapacitet = a.Capacity;
            Console.WriteLine(
                "Na pocetku lista ima {0} elemenata, a kapacitet je {1}.",
                a.Count, 
                a.Capacity);
                
            while (a.Count < 1000)
            {
                a.Add(5);
                if (a.Capacity != prethodniKapacitet)
                {
                    Console.WriteLine(
                        "Dodavanjem {0}-og elementa kapacitet se povecao na {1}.", 
                        a.Count, 
                        a.Capacity);
                        
                    prethodniKapacitet = a.Capacity;
                }                
            }
        }
    }
}
