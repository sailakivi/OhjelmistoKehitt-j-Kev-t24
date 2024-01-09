using System;
class Ohjelma
{
    static void Main()
    {
        double celsius = 10;
        double fahrenheit = CelsiusToFahrenheit(celsius);

        Console.WriteLine($"{celsius} Celsius-astetta on {fahrenheit} Fahrenheit-astetta.");
    }
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 1.8) + 32;
    }
}
