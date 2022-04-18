using System;
using LogicaNegocio;
class TestClass
{
    static float temperaturaCelsius;
    static float temperaturaKelvin;
    static void Main(string [] args)
    {
        temperaturaCelsius = 30;
        temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);
        MostrarTemperaturas();
    }

    static void MostrarTemperaturas()
    {
        Console.WriteLine($"La temperatura Celsius es {temperaturaCelsius} ");
        Console.WriteLine($"La temperatura en Kelvin es {temperaturaKelvin} ");

    }
}