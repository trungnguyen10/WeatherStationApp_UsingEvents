using WeatherStationLib;
using System;

namespace WeatherStationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            data.MeasurementsChanged += currentDisplay.update;
            // StatisticDisplay statisticDisplay = new StatisticDisplay(data);
            // ForecastDisplay forecastDisplay = new ForecastDisplay(data);
            // HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(data);

            Console.WriteLine("First reading:");
            data.Temperature = 80;
            data.Humidity = 65;
            data.Pressure = 30.4;
            
            Console.WriteLine();

            Console.WriteLine("Second reading:");
            data.Temperature = 82;
            data.Humidity = 70;
            data.Pressure = 29.2;
            
            Console.WriteLine();

            Console.WriteLine("Third reading:");
            data.Temperature = 78;
            data.Humidity = 90;
            data.Pressure = 29.2;
        }
    }
}
