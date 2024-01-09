using System;
class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä nimesi: ");
        string käyttäjänNimi = Console.ReadLine();

        TervehdysViesti(käyttäjänNimi);
    }

    static void TervehdysViesti(string nimi)
    {
        Console.WriteLine($"Hei {nimi}!");
    }
}
