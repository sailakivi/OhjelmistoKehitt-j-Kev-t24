using System;
class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä ensimmäinen luku: ");
        double luku1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Syötä toinen luku: ");
        double luku2 = Convert.ToDouble(Console.ReadLine());

        LaskeJaTulostaPeruslaskutoimitukset(luku1, luku2);
    }
    static void LaskeJaTulostaPeruslaskutoimitukset(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {Summa(a, b)}");
        Console.WriteLine($"{a} - {b} = {Erotus(a, b)}");
        Console.WriteLine($"{a} * {b} = {Tulo(a, b)}");

        Console.WriteLine($"{a} / {b} = {Osamaara(a, b)}");
    }
    static double Summa(double a, double b)
    {
        return a + b;
    }
    static double Erotus(double a, double b)
    {
        return a - b;
    }
    static double Tulo(double a, double b)
    {
        return a * b;
    }
    static double Osamaara(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Jakaja ei voi olla nolla.");
            return 0;
        }
        return a / b;
    }
}

