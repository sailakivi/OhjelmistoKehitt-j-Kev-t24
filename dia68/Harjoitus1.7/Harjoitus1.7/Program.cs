using System;
class Ohjelma
{
    static void Main()
    {
        Console.Write("Syötä Celsius-asteet: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = CelsiusToFahrenheit(celsius);

        Console.WriteLine($"{celsius} Celsius-astetta on {fahrenheit} Fahrenheit-astetta.");
    }
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 1.8) + 32;
    }
}
