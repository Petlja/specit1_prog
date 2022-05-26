using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int poc = 1; poc <= n; poc++)
        {
            for (int kraj = poc; kraj <= n; kraj++)
            {
                for (int i = poc; i <= kraj; i++)
                {
                    Console.Write(i);
                    if (i < kraj) Console.Write(' ');
                }
                if (kraj < n) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
