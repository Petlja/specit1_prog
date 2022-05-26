using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MenjanjeStringa
{
    class Program
    {
        static string Ponovi(string sekvenca, int brPonavljanja)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < brPonavljanja; i++)
                sb.Append(sekvenca);
            return sb.ToString();
        }

        static TimeSpan Test(int nacin, out string s)
        {
            string svaSlovaICifre = 
                "abcdefghijklmnopqrstuvwxyz"
                + "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                + "0123456789";

            int N = 10000;
            s = Ponovi(svaSlovaICifre, N);
            Stopwatch t = new Stopwatch();
            t.Start();

            switch (nacin)
            {
                case 1:
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in s)
                        sb.Append(char.IsLetterOrDigit(c) ? '_' : c);
                    s = sb.ToString();
                    break;
                case 2:
                    char[] a = s.ToArray();
                    for (int i = 0; i < a.Length; i++)
                        if (char.IsLetterOrDigit(a[i]))
                            a[i] = '_';
                    s = new string(a);
                    break;
                case 3:
                    foreach (char slovo in svaSlovaICifre)
                        s = s.Replace(slovo, '_');
                    break;
                case 4:
                    string s1 = "";
                    foreach (char c in s)
                        s1 += char.IsLetterOrDigit(c) ? '_' : c;
                    s = s1;
                    break;
            }

            t.Stop();
            return t.Elapsed;

        }
        static void Main(string[] args)
        {
            string s = "";
            Console.WriteLine("StringBuilder:                      " + Test(1, out s));
            Console.WriteLine("Konverzija u niz i iz niza:         " + Test(2, out s));
            Console.WriteLine("Primena Replace slovo po slovo:     " + Test(3, out s));
            Console.WriteLine("Nadovezivanje karaktera na string:  " + Test(4, out s));
        }
    }
}
