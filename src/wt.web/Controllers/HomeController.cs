namespace wt.web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;
    using Services;

    public class HomeController : Controller
    {
        private readonly IWeatherServicesManager _weatherServicesManager;

        public HomeController()
        {
            _weatherServicesManager = new WeatherServicesManager();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetWeatherInfo(WeatherInfoRequest weatherInfoRequest)
        {
            var weatherInfoViewModal = new List<WeatherInfoViewModal>();

            if (weatherInfoRequest.Cities == null || weatherInfoRequest.Services == null ||
                weatherInfoRequest.Cities.Length == 0 || weatherInfoRequest.Services.Length == 0)
                return Json(weatherInfoViewModal, JsonRequestBehavior.AllowGet);

            foreach (var service in weatherInfoRequest.Services)
            {
                var weatherService = _weatherServicesManager.CreateWeatherServices(service);
                foreach (var city in weatherInfoRequest.Cities)
                {
                    var weatherInfoViewModel = weatherService.GetInfo(city);
                    weatherInfoViewModel.Service = service;
                    weatherInfoViewModal.Add(weatherInfoViewModel);
                }
            }

            var viewModal = weatherInfoViewModal.GroupBy(x => x.Service)
                .Select(service => new
                {
                    Service = service.Key,
                    Cities = service.Select(x => new
                    {
                        x.Temperature,
                        x.Humidity,
                        x.Pressure,
                        x.City,
                        x.Wind,
                        x.WindDirection,
                        x.Description
                    })
                        .GroupBy(x => x.City)
                        .Select(x => new
                        {
                            City = x.Key,
                            Info = x.Select(info => new
                            {
                                info.Humidity,
                                info.Pressure,
                                info.Temperature,
                                info.Wind,
                                info.WindDirection,
                                info.Description
                            })
                                .FirstOrDefault()
                        })
                });

            return Json(viewModal, JsonRequestBehavior.AllowGet);
        }
    }
}