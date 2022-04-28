class Temperature
{
    static FahrenheitToCelsius(var temperatureFahrenheit)
    {
        var temperatureCelsius = (temperatureFahrenheit - 32) / 1.8;
        return temperatureCelsius;

    }
}