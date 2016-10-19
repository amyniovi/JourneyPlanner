using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;


namespace JourneyPlanner
{
	public class ModelFactory
	{
		private UrlHelper _urlHelper;

		public ModelFactory(HttpRequestMessage request)
		{
			_urlHelper = new UrlHelper(request);
		}

		public RouteModel Create(List<Link> StationLinks)
		{

			return new RouteModel {
			
			};
		
		}
	}
}
