// See https://aka.ms/new-console-template for more information


Console.Write("Anna ikäsi:");
int ika = int.Parse(Console.ReadLine());
if (ika < 15)
{
    Console.Write("Saat ajaa polkupyörää");
}
else if (ika < 18)
{
    Console.Write("Saat ajaa mopoa");
}
else
{
    Console.Write("Saat ajaa autoa");
}