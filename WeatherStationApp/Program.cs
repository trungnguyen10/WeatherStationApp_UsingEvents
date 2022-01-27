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
            StatisticDisplay statisticDisplay = new StatisticDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay();
            data.MeasurementsChanged += currentDisplay.update;
            data.MeasurementsChanged += statisticDisplay.update;
            data.MeasurementsChanged += forecastDisplay.update;
            data.MeasurementsChanged += heatIndexDisplay.update;

            Console.WriteLine("First reading:");
            data.setMeasurements(80, 65, 30.4);
            Console.WriteLine();
            Console.WriteLine("Second reading:");
            data.setMeasurements(82, 70, 29.2);
            Console.WriteLine();
            Console.WriteLine("Third reading:");
            data.setMeasurements(78, 90, 29.2);
        }
    }
}
