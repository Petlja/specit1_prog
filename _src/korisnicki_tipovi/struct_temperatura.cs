using System;

class Program
{
    struct Temperatura
    {
        private double t;
        public double C // Celzijus (Celsius)
        {
            get { return t; }
            set { t = value; }
        }
        public double F // Farenhajt (Fahrenheit)
        {
            get { return t * 1.8 + 32; }
            set { t = (value - 32) * 5 / 9; }
        }
        public double K // Kelvin (Kelvin)
        {
            get { return t + 273.15; }
            set { t = value - 273.15; }
        }
        public double R // Reomir (Réaumur)
        {
            get { return t * 0.8; }
            set { t = value * 1.25; }
        }
    };

    public static void Main()
    {
        Temperatura kljucanjeVode = new Temperatura(), paljenjePapira = new Temperatura();
        kljucanjeVode.C = 100; // temperatura kljucanja vode
        paljenjePapira.F = 451; // temperatura paljenja papira
        Console.WriteLine("Voda kljuca na {0:F2}°C = {1:F2}°F = {2:F2}K", 
            kljucanjeVode.C, kljucanjeVode.F, kljucanjeVode.K);

        Console.WriteLine("Papir se pali na {0:F2}°C = {1:F2}°F = {2:F2}K",
            paljenjePapira.C, paljenjePapira.F, paljenjePapira.K);

        Console.WriteLine("Razlika ovih temperatura je {0:F2}°C, ili {1:F2}°F, ili {2:F2}K",
            paljenjePapira.C - kljucanjeVode.C, 
            paljenjePapira.F - kljucanjeVode.F, 
            paljenjePapira.K - kljucanjeVode.K);
    }
}
