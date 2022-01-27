using System;

namespace WeatherStationLib
{
    public class StatisticDisplay :  IDisplayElement
    {
        private double minTemp = 200.0;
        private double maxTemp = 0.0;
        private double sumOfTemp = 0.0;
        private int numberOfReadings = 0;
        private WeatherData data;

        /// <summary>
        /// Construct StatisticDisplay object using specified weahterData object and subscribe to that object for data changes
        /// </summary>
        /// <param name="data"></param>
        // public StatisticDisplay(WeatherData data)
        // {
        //     this.data = data;
        //     data.registerObserver(this);
        // }

        // public void update()
        // {
        //     double temp = data.Temperature;
        //     sumOfTemp += temp;
        //     numberOfReadings++;
        //     if (minTemp > temp) minTemp = temp;
        //     if (maxTemp < temp) maxTemp = temp;
        //     display();
        // }

        public void display()
        {
            Console.WriteLine($"Avg / Max / Min temperature: {0} / {1} / {2}.",
            arg0: sumOfTemp / (double)numberOfReadings,
            arg1: maxTemp,
            arg2: minTemp);
        }
    }
}