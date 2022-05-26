using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int pozPrvogPlusa = s.IndexOf('+');
        int pozDrugogPlusa = s.IndexOf('+', pozPrvogPlusa + 1);
        int pozJednako = s.IndexOf('=');
        int duzinaPrvogBroja = pozPrvogPlusa;
        int duzinaDrugogBroja = pozDrugogPlusa - pozPrvogPlusa - 1;
        int duzinaTrecegBroja = pozJednako - pozDrugogPlusa - 1;
        int a = int.Parse(s.Substring(0, duzinaPrvogBroja));
        int b = int.Parse(s.Substring(pozPrvogPlusa + 1, duzinaDrugogBroja));
        int c = int.Parse(s.Substring(pozDrugogPlusa + 1, duzinaTrecegBroja));
        Console.WriteLine(a + b + c);
    }
}
