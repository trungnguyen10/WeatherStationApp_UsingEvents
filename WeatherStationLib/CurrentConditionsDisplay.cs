using System;

namespace WeatherStationLib
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double temp;
        private double humidity;
        // private WeatherData data;

        /// <summary>
        /// Construct the display object using the specified weatherData object, and subscribe that object for data changes.
        /// </summary>
        /// <param name="weatherData">The WeatherData object to which the display subscribe</param>
        // public CurrentConditionsDisplay(WeatherData weatherData)
        // {
        //     this.data = weatherData;
        //     data.registerObserver(this);
        // }



        // Implement interfaces methods
        public void update(object sender, MeasurementsChangedEventsArgs e)
        {
            if (temp != e.newData.Temperature && humidity != e.newData.Humidity)
            {
                temp = e.newData.Temperature;
                humidity = e.newData.Humidity;
                display();
            }
        }

        public void display()
        {
            Console.WriteLine($"Current conditions: {temp} F degrees and {humidity} % humidity");
        }
    }
}