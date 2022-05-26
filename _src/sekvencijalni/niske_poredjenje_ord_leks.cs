class Program
{
    static void Main(string[] args)
    {
        // "sr-SP-Latn" за латиницу, "sr-SP-Cyrl" за ћирилицу
        CultureInfo.CurrentCulture = new CultureInfo("sr-SP-Cyrl", false);
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        string[] tekstovi = Console.ReadLine().Split();
        string tekst1 = tekstovi[0];
        string tekst2 = tekstovi[1];

        Console.WriteLine("{0} {1} {2}",
            String.Compare(tekst1, tekst2, StringComparison.Ordinal),
            String.Compare(tekst1, tekst2),
            String.Compare(tekst1, tekst2, true));
    }
}
