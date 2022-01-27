using System;
using System.Collections.Generic;

namespace WeatherStationLib
{
    public class WeatherData
    {
        // fields
        private double temperature;
        private double humidity;
        private double pressure;


        // Properties
        private List<IObserver> observers = new List<IObserver>();
        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; OnMeasurementsChanged(new MeasurementsChangedEventsArgs(this)); }
        }
        public double Humidity
        {
            get { return humidity; }
            set { humidity = value; OnMeasurementsChanged(new MeasurementsChangedEventsArgs(this)); }
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; OnMeasurementsChanged(new MeasurementsChangedEventsArgs(this)); }
        }

        // create a event member
        public event EventHandler<MeasurementsChangedEventsArgs> MeasurementsChanged;

        // fire the event
        public void OnMeasurementsChanged(MeasurementsChangedEventsArgs e)
        {
            if (MeasurementsChanged != null) MeasurementsChanged(this, e);
        }

        // public void measurementsChanged()
        // {
        //     ((ISubject)this).notifyObservers();
        // }

        // public void setMeasurements(double temperature, double humidity, double pressure)
        // {
        //     Temperature = temperature;
        //     Humidity = humidity;
        //     Pressure = pressure;
        //     measurementsChanged();
        // }

    }
}