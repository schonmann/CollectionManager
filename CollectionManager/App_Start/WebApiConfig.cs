using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CollectionManager
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var corsAttr = new EnableCorsAttribute(ConfigurationManager.AppSettings.Get("ClientAddress"), "*", "*");
            config.EnableCors(corsAttr);
        }
    }
}
