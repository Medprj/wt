namespace wt.web.Services
{
    using System;
    using System.Configuration;
    using System.Net;
    using Helpers;
    using Models;

    public class OpenWeatherMapService : IWeatherInfo
    {
        private const float mmHg = 0.75006375541921f; //1 hPa = 0.75006375541921 mmHg

        private const string WeatherUrl =
            "http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&lang=ru&units=metric";

        private readonly string _appid;

        public OpenWeatherMapService()
        {
            _appid = ConfigurationManager.AppSettings["openweathermap"];
        }

        public WeatherInfoViewModal GetInfo(string city)
        {
            var webRequest = WebRequest.Create(string.Format(WeatherUrl, city, _appid));
            webRequest.Method = "GET";
            var response = webRequest.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                var openWeatherMapJsonViewModel = ParseHelper.FromJson<Rootobject>(stream);

                return new WeatherInfoViewModal
                {
                    City = city,
                    Pressure = (int) Math.Round((openWeatherMapJsonViewModel.main.pressure)*mmHg, 0),
                    Humidity = openWeatherMapJsonViewModel.main.humidity,
                    Temperature = (float) Math.Round(openWeatherMapJsonViewModel.main.temp, 1),
                    Wind = openWeatherMapJsonViewModel.wind.speed,
                    WindDirection = WindDirectionHelper.GetDirection(openWeatherMapJsonViewModel.wind.deg),
                    Description = openWeatherMapJsonViewModel.weather[0].description
                };
            }
        }
    }
}