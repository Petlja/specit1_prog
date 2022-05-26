using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var culture = new System.Globalization.CultureInfo("sr-Cyrl-CS"); // "sr-Latn-CS" za latinicu
        string day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
        Console.WriteLine("Данас је {0}", day);
    }
}
