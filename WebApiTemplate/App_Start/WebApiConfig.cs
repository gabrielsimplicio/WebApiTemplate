using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Web.Http;

namespace WebApiTemplate
{
    public class WebApiConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            var jsonSerializerSettings = config.Formatters.JsonFormatter.SerializerSettings;

            // Remove unix epoch date handling, in favor of ISO
            jsonSerializerSettings.Converters.Add(new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fff" });

            // Remove nulls from payload and save bytes
            jsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;

            // Make json output camelCase
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Remove xml this will make json the default and your life easier (unless you really need to support xml)
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "text/xml"));
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml"));

            // Attribute routing
            config.MapHttpAttributeRoutes();
        }
    }
}