using System;

namespace WeatherStationLib
{
    public class ForecastDisplay : IDisplayElement
    {
        private double currentPressure = 29.92;
        private double previousPressure;
        private WeatherData data;

        // public ForecastDisplay(WeatherData data)
        // {
        //     this.data = data;
        //     data.registerObserver(this);
        // }

        // public void update()
        // {
        //     previousPressure = currentPressure;
        //     currentPressure = data.Pressure;
        //     display();
        // }

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