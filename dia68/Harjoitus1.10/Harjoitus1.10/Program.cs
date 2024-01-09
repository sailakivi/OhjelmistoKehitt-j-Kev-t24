using System;
class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä kokonaisluku välillä 1-10: ");
        int luku = Convert.ToInt32(Console.ReadLine());

        if (luku >= 1 && luku <= 10)
        {
            TulostaKertotaulu(luku);
        }
        else
        {
            Console.WriteLine("Syötä kelvollinen luku välillä 1-10.");
        }
    }
    static void TulostaKertotaulu(int luku)
    {
        Console.WriteLine($"Kertotaulu luvulle {luku}:");

        for (int i = 1; i <= 10; i++)
        {
            int tulos = luku * i;
            Console.WriteLine($"{luku} x {i} = {tulos}");
        }
    }
}

