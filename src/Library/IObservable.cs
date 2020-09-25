namespace Observer
{
    public interface IObservable
    {
        void Subscribe(TemperatureReporter observer);
        void Unsubscribe(TemperatureReporter observer);
        void GetTemperature();
         
    }
}