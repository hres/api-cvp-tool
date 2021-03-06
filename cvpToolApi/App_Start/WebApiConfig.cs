﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Converters;

namespace cvpToolApi
{
    public static class WebApiConfig
    {
        public const string DEFAULT_ROUTE_NAME = "MyDefaultRoute";
        public static readonly string UriPathExtensionKey = "ext";
        public static void Register(HttpConfiguration config)
        {
            // config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "ApiMultiParamPathExtension ID",
                routeTemplate: "api/{controller}/{id}/{no}/{drugname}.{ext}",
                defaults: new { id = RouteParameter.Optional, ext = RouteParameter.Optional });
            
            config.Routes.MapHttpRoute(
                name: "Api UriPathExtension ID",
                routeTemplate: "api/{controller}/{id}.{ext}",
                defaults: new { id = RouteParameter.Optional, ext = RouteParameter.Optional });
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));
            config.Formatters.JsonFormatter.SupportedEncodings.Add(Encoding.GetEncoding("utf-8"));
            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd" });
            config.Formatters.XmlFormatter.MediaTypeMappings.Add(new QueryStringMapping("type", "xml", new MediaTypeHeaderValue("application/xml")));


            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();

            // To disable tracing in your application, please comment out or remove the following line of code
            // For more information, refer to: http://www.asp.net/web-api
            config.EnableSystemDiagnosticsTracing();
        }
    }
}
