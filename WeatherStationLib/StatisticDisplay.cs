using System;

namespace WeatherStationLib
{
    public class StatisticDisplay : IObserver, IDisplayElement
    {
        private double minTemp = 200.0;
        private double maxTemp = 0.0;
        private double sumOfTemp = 0.0;
        private int numberOfReadings = 0;

        public void update(object sender, MeasurementsChangedEventsArgs e)
        {
            double temp = e.newData.Temperature;
            sumOfTemp += temp;
            numberOfReadings++;
            if (minTemp > temp) minTemp = temp;
            if (maxTemp < temp) maxTemp = temp;
            display();
        }

        public void display()
        {
            Console.WriteLine("Avg / Max / Min temperature: {0} / {1} / {2}.",
            arg0: sumOfTemp / (double)numberOfReadings,
            arg1: maxTemp,
            arg2: minTemp);
        }
    }
}