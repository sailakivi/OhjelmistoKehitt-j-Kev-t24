using System;
class Ohjelma
{
    static void Main()
    {
        int tulos = Yhteenlasku(3, 5);
        Console.WriteLine("Tulos: " + tulos);
    }

    static int Yhteenlasku(int luku1, int luku2)
    {
        return luku1 + luku2;
    }
}

