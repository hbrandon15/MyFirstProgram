using System;


namespace MyUtilities
{
    class WeatherUtilities
    {
        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (float)(temperatureFahrenheit - 32 / 1.8f);
        }

        static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return (float)(temperatureCelsius * 1.8f + 32);
        }

        // the higher the index, the lower the confort. 
        static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            // probably not a very reliable formula:
            return (temperatureFahrenheit + humidityPercent) / 4;
        }

        static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }
}