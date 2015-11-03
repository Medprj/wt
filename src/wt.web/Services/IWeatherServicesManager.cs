namespace wt.web.Services
{
    public interface IWeatherServicesManager
    {
        IWeatherInfo CreateWeatherServices(string service);
    }
}