using System;
class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä ensimmäinen luku: ");
        double luku1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Syötä toinen luku: ");
        double luku2 = Convert.ToDouble(Console.ReadLine());

        double tulos = Yhteenlasku(luku1, luku2);

        Console.WriteLine($"Summa: {tulos}");
    }
    static double Yhteenlasku(double a, double b)
    {
        return a + b;
    }
}
