namespace wt.web.Services
{
    using System;

    public class WeatherServicesManager : IWeatherServicesManager
    {
        public IWeatherInfo CreateWeatherServices(string service)
        {
            switch (service)
            {
                case "Yandex":
                    return new YandexWeatherInfoServices();

                case "OpenWeatherMap":
                    return new OpenWeatherMapService();

                default:
                    throw new ArgumentException("An invalid service name: " + service);
            }
        }
    }
}