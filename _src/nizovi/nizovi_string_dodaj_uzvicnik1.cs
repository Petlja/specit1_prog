using System;

namespace Test
{
    class Program
    {
        // ovo ne radi
        static void DodajUzvicnik(string str) { str += '!'; }

        static void Main(string[] args)
        {
            string s = "Zdravo";
            DodajUzvicnik(s);
            Console.WriteLine(s);
        }
    }
}
