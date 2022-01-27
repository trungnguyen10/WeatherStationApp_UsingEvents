using System;

namespace WeatherStationLib
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double currentPressure = 29.92;
        private double previousPressure;

        public void update(Object sender, MeasurementsChangedEventsArgs e)
        {
            previousPressure = currentPressure;
            currentPressure = e.newData.Pressure;
            display();
        }

        public void display()
        {
            if (currentPressure > previousPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == previousPressure)
                Console.WriteLine("More of the same!");
            else
                Console.WriteLine("Watch out for cooler, rainy weather!");
        }
    }
}