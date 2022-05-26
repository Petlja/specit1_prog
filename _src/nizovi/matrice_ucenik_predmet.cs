using System;
namespace UcenikPredmet
{
    class Program
    {
        static void Main(string[] args)
        {
            // ucitavanje podataka
            string[] s = Console.ReadLine().Split();
            int v = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            int[,] ocene = new int[v, k];
            for (int i = 0; i < v; i++)
            {
                s = Console.ReadLine().Split();
                for (int j = 0; j < k; j++)
                    ocene[i, j] = int.Parse(s[j]);
            }

            // odredjivanje vrste sa najvecim zbirom
            int maxZbirVrste = int.MinValue;
            int iMaxVrste = 0;
            for (int i = 0; i < v; i++)
            {
                int zbirVrste = 0;
                for (int j = 0; j < k; j++)
                    zbirVrste += ocene[i, j];
                if (maxZbirVrste < zbirVrste)
                {
                    maxZbirVrste = zbirVrste;
                    iMaxVrste = i;
                }
            }

            // odredjivanje kolone sa najmanjim zbirom
            int minZbirKolone = int.MaxValue;
            int iMinKolone = 0;
            for (int j = 0; j < k; j++)
            {
                int zbirKolone = 0;
                for (int i = 0; i < v; i++)
                    zbirKolone += ocene[i, j];
                if (minZbirKolone > zbirKolone)
                {
                    minZbirKolone = zbirKolone;
                    iMinKolone = j;
                }
            }

            Console.WriteLine("{0} {1}", iMaxVrste, iMinKolone);
        }
    }
}
