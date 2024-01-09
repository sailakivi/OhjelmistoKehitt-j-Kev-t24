using System;

class Ohjelma
{
    static void Main()
    {
        int luku1 = 8;
        int luku2 = 5;

        LaskeJaTulostaPeruslaskutoimitukset(luku1, luku2);
    }

    static void LaskeJaTulostaPeruslaskutoimitukset(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {Summa(a, b)}");
        Console.WriteLine($"{a} - {b} = {Erotus(a, b)}");
        Console.WriteLine($"{a} * {b} = {Tulo(a, b)}");

        Console.WriteLine($"{a} / {b} = {Osamaara(a, b)}");
    }

    static int Summa(int a, int b)
    {
        return a + b;
    }

    static int Erotus(int a, int b)
    {
        return a - b;
    }

    static int Tulo(int a, int b)
    {
        return a * b;
    }

    static double Osamaara(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Jakaja ei voi olla nolla.");
            return 0;
        }

        return (double)a / b;
    }
}
