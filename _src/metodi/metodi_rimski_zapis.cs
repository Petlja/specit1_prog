using System;
using System.Text;

class Program
{
    static string CifraURimski(int c, char simbol1, char simbol5, char simbol10)
    {
        if (c < 4) return new String(simbol1, c); // simbol1 ponovljen c puta
        else if (c == 4) return simbol1.ToString() + simbol5.ToString();
        else if (c < 9) return simbol5.ToString() + new String(simbol1, c-5);
        else /* 9 */ return simbol1.ToString() + simbol10.ToString();
    }

    static string BrojURimski(int n)
    {
        // Cifra jedinica
        string rezultat = CifraURimski(n % 10, 'I', 'V', 'X');
        n /= 10; // uklanjamo cifru jedinica
        if (n == 0) // ako nema vise cifara vracamo rezultat
            return rezultat;

        // Cifra desetica
        rezultat = CifraURimski(n % 10, 'X', 'L', 'C') + rezultat;
        n /= 10; // uklanjamo cifru desetica
        if (n == 0) // ako nema vise cifara vracamo rezultat
            return rezultat;

        // Cifra stotina
        rezultat = CifraURimski(n % 10, 'C', 'D', 'M') + rezultat;
        n /= 10; // uklanjamo cifru stotina
        if (n == 0) // ako nema vise cifara vracamo rezultat
            return rezultat;

        // dodajemo hiljade na pocetak rezultata i vracamo ga
        return new String('M', n) + rezultat;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(BrojURimski(n));
    }
}
