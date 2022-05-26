using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string recenica = "Онижи, црнокоси човек рече: \"У реду\" и оде.";
        string deo_a = recenica.Split(':')[0];
        string deo_b = deo_a.Split(',')[1];
        Console.WriteLine(deo_b);
    }
}
