// See https://aka.ms/new-console-template for more information

Console.Write("Anna luku1: ");
string luku1 = Console.ReadLine();
int x = Int32.Parse(luku1);

Console.Write("Anna luku2: ");
string luku2 = Console.ReadLine();
int y = Int32.Parse(luku2);

x = x / y;

Console.WriteLine("x = " + x);


