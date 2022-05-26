using System;

class Program
{
    static void Main()
    {
        DateTime dt = DateTime.Today;
        switch (dt.DayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Danas je ponedeljak.");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Danas je utorak.");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Danas je sreda.");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Danas je cetvrtak.");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Danas je petak.");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Danas je subota.");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Danas je nedelja.");
                break;
        }
    }
}
