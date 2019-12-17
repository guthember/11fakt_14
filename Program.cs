using System;

namespace atvalto
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Kérek egy egész számot: ");
      int szam = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Kérek egy számrendszert (9-ig): ");
      int rendszer = Convert.ToInt32(Console.ReadLine());

      string binaris = "";

      while (szam != 0)
      {
        int maradek = szam % rendszer;
        binaris = maradek.ToString() + binaris;
        szam = szam / rendszer;
      }

      Console.WriteLine(binaris);
      Console.ReadKey();
    }
  }
}
