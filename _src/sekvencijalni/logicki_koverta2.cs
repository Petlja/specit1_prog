class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesite visinu i sirinu papira: ");
        int visinaPapira = int.Parse(Console.ReadLine());
        int sirinaPapira = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite visinu i sirinu koverte: ");
        int visinaKoverte = int.Parse(Console.ReadLine());
        int sirinaKoverte = int.Parse(Console.ReadLine());

        Console.WriteLine(
            ((visinaPapira < visinaKoverte) && (sirinaPapira < sirinaKoverte))
            || ((visinaPapira < sirinaKoverte) && (sirinaPapira < visinaKoverte))
            );
    }
}
