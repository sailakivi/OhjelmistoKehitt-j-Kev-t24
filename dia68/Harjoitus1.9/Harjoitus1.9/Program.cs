using System;
class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä jaettava luku: ");
        int jaettava = Convert.ToInt32(Console.ReadLine());

        Console.Write("Syötä jakaja: ");
        int jakaja = Convert.ToInt32(Console.ReadLine());

        int jakojäännös = LaskeJaPalautaJakojäännös(jaettava, jakaja);

        Console.WriteLine($"Jakojäännös luvuista {jaettava} ja {jakaja} on {jakojäännös}.");
    }
    static int LaskeJaPalautaJakojäännös(int jaettava, int jakaja)
    {
        return jaettava % jakaja;
    }
}

