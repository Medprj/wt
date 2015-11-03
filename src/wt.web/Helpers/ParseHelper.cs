namespace wt.web.Helpers
{
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Xml.Serialization;

    public class ParseHelper
    {
        public static T FromXml<T>(Stream stream) where T : class
        {
            var xml = new XmlSerializer(typeof(T));
            return xml.Deserialize(stream) as T;
        }

        public static T FromJson<T>(Stream stream) where T : class
        {
            var js = new DataContractJsonSerializer(typeof(T));
            return js.ReadObject(stream) as T;
        }
    }
}