using System;

namespace WeatherStationLib
{
    public class MeasurementsChangedEventsArgs : EventArgs
    {
        public readonly WeatherData newData;

        public MeasurementsChangedEventsArgs(WeatherData data)
        {
            newData = data;
        }
    }

}