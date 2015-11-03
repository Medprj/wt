namespace wt.web.Services
{
    using Models;

    public interface IWeatherInfo
    {
        WeatherInfoViewModal GetInfo(string city);
    }
}