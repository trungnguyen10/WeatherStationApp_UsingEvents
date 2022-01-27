using System;

namespace WeatherStationLib
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double temp;
        private double humidity;

        // Implement interfaces methods
        public void update(object sender, MeasurementsChangedEventsArgs e)
        {
                temp = e.newData.Temperature;
                humidity = e.newData.Humidity;
                display();
        }

        public void display()
        {
            Console.WriteLine($"Current conditions: {temp} F degrees and {humidity} % humidity");
        }
    }
}