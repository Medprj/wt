namespace wt.web.Models
{
    public class WeatherInfoViewModal
    {
        public string Service { get; set; }
        public string City { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public int Pressure { get; set; }
        public string Description { get; set; }
        public decimal Wind { get; set; }
        public string WindDirection { get; set; }
    }
}