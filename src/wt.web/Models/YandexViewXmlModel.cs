// ReSharper disable InconsistentNaming

namespace wt.web.Models
{
    using System;
    using System.ComponentModel;
    using System.Xml.Serialization;

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    [XmlRoot(Namespace = "http://weather.yandex.ru/forecast", IsNullable = false)]
    public class forecast
    {
        private forecastFact factField;

        private string cityField;

        private string countryField;

        private int regionField;

        private int idField;

        private string sourceField;

        private string country_idField;

        private string linkField;

        private string part_idField;

        private string exactnameField;

        private string partField;

        private string slugField;

        public forecastFact fact
        {
            get { return factField; }
            set { factField = value; }
        }

        [XmlAttribute]
        public string city
        {
            get { return cityField; }
            set { cityField = value; }
        }

        [XmlAttribute]
        public string country
        {
            get { return countryField; }
            set { countryField = value; }
        }

        [XmlAttribute]
        public int region
        {
            get { return regionField; }
            set { regionField = value; }
        }

        [XmlAttribute]
        public int id
        {
            get { return idField; }
            set { idField = value; }
        }

        [XmlAttribute]
        public string source
        {
            get { return sourceField; }
            set { sourceField = value; }
        }

        [XmlAttribute]
        public string country_id
        {
            get { return country_idField; }
            set { country_idField = value; }
        }

        [XmlAttribute]
        public string link
        {
            get { return linkField; }
            set { linkField = value; }
        }

        [XmlAttribute]
        public string part_id
        {
            get { return part_idField; }
            set { part_idField = value; }
        }

        [XmlAttribute]
        public string exactname
        {
            get { return exactnameField; }
            set { exactnameField = value; }
        }

        [XmlAttribute]
        public string part
        {
            get { return partField; }
            set { partField = value; }
        }

        [XmlAttribute]
        public string slug
        {
            get { return slugField; }
            set { slugField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFact
    {
        private forecastFactStation[] stationField;

        private DateTime observation_timeField;

        private DateTime uptimeField;

        private forecastFactTemperature temperatureField;

        private forecastFactWeather_condition weather_conditionField;

        private forecastFactImage imageField;

        private forecastFactImagev2 imagev2Field;

        private forecastFactImagev3 imagev3Field;

        private string weather_typeField;

        private string wind_directionField;

        private decimal wind_speedField;

        private float humidityField;

        private forecastFactPressure pressureField;

        private forecastFactMslp_pressure mslp_pressureField;

        private string daytimeField;

        private forecastFactSeason seasonField;

        private string ipad_imageField;

        [XmlElement("station")]
        public forecastFactStation[] station
        {
            get { return stationField; }
            set { stationField = value; }
        }

        public DateTime observation_time
        {
            get { return observation_timeField; }
            set { observation_timeField = value; }
        }

        public DateTime uptime
        {
            get { return uptimeField; }
            set { uptimeField = value; }
        }

        public forecastFactTemperature temperature
        {
            get { return temperatureField; }
            set { temperatureField = value; }
        }

        public forecastFactWeather_condition weather_condition
        {
            get { return weather_conditionField; }
            set { weather_conditionField = value; }
        }

        public forecastFactImage image
        {
            get { return imageField; }
            set { imageField = value; }
        }

        [XmlElement("image-v2")]
        public forecastFactImagev2 imagev2
        {
            get { return imagev2Field; }
            set { imagev2Field = value; }
        }

        [XmlElement("image-v3")]
        public forecastFactImagev3 imagev3
        {
            get { return imagev3Field; }
            set { imagev3Field = value; }
        }

        public string weather_type
        {
            get { return weather_typeField; }
            set { weather_typeField = value; }
        }

        public string wind_direction
        {
            get { return wind_directionField; }
            set { wind_directionField = value; }
        }

        public decimal wind_speed
        {
            get { return wind_speedField; }
            set { wind_speedField = value; }
        }

        public float humidity
        {
            get { return humidityField; }
            set { humidityField = value; }
        }

        public forecastFactPressure pressure
        {
            get { return pressureField; }
            set { pressureField = value; }
        }

        public forecastFactMslp_pressure mslp_pressure
        {
            get { return mslp_pressureField; }
            set { mslp_pressureField = value; }
        }

        public string daytime
        {
            get { return daytimeField; }
            set { daytimeField = value; }
        }

        public forecastFactSeason season
        {
            get { return seasonField; }
            set { seasonField = value; }
        }

        public string ipad_image
        {
            get { return ipad_imageField; }
            set { ipad_imageField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactStation
    {
        private string langField;

        private float distanceField;

        private string valueField;

        [XmlAttribute]
        public string lang
        {
            get { return langField; }
            set { langField = value; }
        }

        [XmlAttribute]
        public float distance
        {
            get { return distanceField; }
            set { distanceField = value; }
        }

        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactTemperature
    {
        private string colorField;

        private string plateField;

        private float valueField;

        [XmlAttribute]
        public string color
        {
            get { return colorField; }
            set { colorField = value; }
        }

        [XmlAttribute]
        public string plate
        {
            get { return plateField; }
            set { plateField = value; }
        }

        [XmlText]
        public float Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactWeather_condition
    {
        private string codeField;

        [XmlAttribute]
        public string code
        {
            get { return codeField; }
            set { codeField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactImage
    {
        private string typeField;

        private string valueField;

        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactImagev2
    {
        private string colorField;

        private string typeField;

        private string valueField;

        [XmlAttribute]
        public string color
        {
            get { return colorField; }
            set { colorField = value; }
        }

        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactImagev3
    {
        private string typeField;

        private string valueField;

        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactPressure
    {
        private string unitsField;

        private float valueField;

        [XmlAttribute]
        public string units
        {
            get { return unitsField; }
            set { unitsField = value; }
        }

        [XmlText]
        public float Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactMslp_pressure
    {
        private string unitsField;

        private float valueField;

        [XmlAttribute]
        public string units
        {
            get { return unitsField; }
            set { unitsField = value; }
        }

        [XmlText]
        public float Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://weather.yandex.ru/forecast")]
    public class forecastFactSeason
    {
        private string typeField;

        private string valueField;

        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }
}