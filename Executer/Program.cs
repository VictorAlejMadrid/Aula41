using TemperatureDLL;

internal class Program
{
    private static void Main(string[] args)
    {
        const double temperature = 64.0;

        Console.WriteLine(TemperatureConverter.FahrenheitToKelvin(temperature));
        Console.WriteLine(TemperatureConverter.FahrenheitToCelsius(temperature));
        Console.WriteLine(TemperatureConverter.KelvinToFahrenheit(temperature));
        Console.WriteLine(TemperatureConverter.KelvinToCelsius(temperature));
        Console.WriteLine(TemperatureConverter.CelsiusToKelvin(temperature));
        Console.WriteLine(TemperatureConverter.CelsiusToFahrenheit(temperature));
    }
}