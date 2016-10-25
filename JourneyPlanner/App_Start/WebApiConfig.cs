using System.Web.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;
using System.Linq;
using WebApiContrib.Formatting.Jsonp;

namespace JourneyPlanner
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			// Web API routes
			config.MapHttpAttributeRoutes();

			/*config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);*/

			//TestThis
			var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().FirstOrDefault();
			jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

			config.Formatters.Insert(0, new JsonpMediaTypeFormatter(new JsonMediaTypeFormatter()));

			config.Filters.Add(new HeaderAllowOriginAttribute());
		}
	}
}
