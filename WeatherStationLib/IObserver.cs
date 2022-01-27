namespace WeatherStationLib
{
    public interface IObserver
    {
        void update(object sender, MeasurementsChangedEventsArgs e);
    }
}