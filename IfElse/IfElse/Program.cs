// See https://aka.ms/new-console-template for more information


Console.Write("Anna ikäsi:");
int ikä = int.Parse(Console.ReadLine());
if (ikä < 15)
{
    Console.Write("Saat ajaa polkupyörää");
}
else if (ikä < 18)
{
    Console.Write("Saat ajaa mopoa");
}
else
{
    Console.Write("Saat ajaa autoa");
}