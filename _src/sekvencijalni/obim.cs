using System;

class ObimKruga {
  static void Main() {
    double r, Obim;
    
    Console.WriteLine("Unesi poluprecnik kruga");
    r = double.Parse(Console.ReadLine());
    Obim = 2 * r * Math.PI;
    Console.WriteLine("Obim kruga je {0}", Obim);
  }
}
