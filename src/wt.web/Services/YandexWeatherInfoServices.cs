namespace wt.web.Services
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Xml.Linq;
    using Helpers;
    using Models;

    public class YandexWeatherInfoServices : IWeatherInfo
    {
        private const float mmHg = 0.75006375541921f; //1 hPa = 0.75006375541921 mmHg
        private const string WeatherUrl = "https://export.yandex.ru/weather-ng/forecasts/{0}.xml";
        private const string CitiesUrl = "https://pogoda.yandex.ru/static/cities.xml";

        public WeatherInfoViewModal GetInfo(string city)
        {
            var cityId = GetCityIdByName(city);
            if (cityId == 0)
                return new WeatherInfoViewModal {City = city};

            var webRequest = WebRequest.Create(string.Format(WeatherUrl, cityId));
            webRequest.Method = "GET";
            var response = webRequest.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                var yandexViewModel = ParseHelper.FromXml<forecast>(stream);

                return new WeatherInfoViewModal
                {
                    City = city,
                    Pressure = (int) Math.Round((yandexViewModel.fact.mslp_pressure.Value)*mmHg, 0),
                    Humidity = yandexViewModel.fact.humidity,
                    Temperature = yandexViewModel.fact.temperature.Value,
                    Wind = yandexViewModel.fact.wind_speed,
                    WindDirection = WindDirectionHelper.GetDirection(yandexViewModel.fact.wind_direction),
                    Description = yandexViewModel.fact.weather_type
                };
            }
        }

        private static int GetCityIdByName(string cityName)
        {
            var doc = XDocument.Load(CitiesUrl);

            var country = doc.Root?.Elements()
                .FirstOrDefault(x => x.Elements().Any(c => c.Value == cityName));

            var city = country?.Elements()
                .FirstOrDefault(x => x.Value == cityName);

            if (city == null) return 0;

            var cityIdString = city
                .Attribute("id")
                .Value;

            int cityId;
            int.TryParse(cityIdString, out cityId);
            return cityId;
        }
    }
}