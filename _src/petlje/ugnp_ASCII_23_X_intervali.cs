using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int brTacakaSaStrane = 0, brTacakaSredina = n - 2;
        for (int red = 1; red <= n; red++)
        {
            for (int i = 0; i < brTacakaSaStrane; i++) Console.Write('.');
            Console.Write('*');
            for (int i = 0; i < brTacakaSredina; i++) Console.Write('.');
            Console.Write('*');
            for (int i = 0; i < brTacakaSaStrane; i++) Console.Write('.');
            Console.WriteLine();
            if (red < n / 2)
            {
                brTacakaSaStrane++;
                brTacakaSredina -= 2;
            }
            else if (red > n / 2)
            {
                brTacakaSaStrane--;
                brTacakaSredina += 2;
            }
        }
    }
}
