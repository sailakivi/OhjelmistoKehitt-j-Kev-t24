using System;
class Ohjelma
{
    static void Main()
    {
        int luku1 = 5;
        int luku2 = 2;

        int jakojäännös = LaskeJaPalautaJakojäännös(luku1, luku2);

        Console.WriteLine($"Jakojäännös luvuista {luku1} ja {luku2} on {jakojäännös}.");
    }
    static int LaskeJaPalautaJakojäännös(int jaettava, int jakaja)
    {
        return jaettava % jakaja;
    }
}
