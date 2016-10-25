using System;
using System.Web.Http.Filters;

namespace JourneyPlanner
{
	
	public class HeaderAllowOriginAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			actionExecutedContext.Response.Content.Headers.Add("Access-Control-Allow-Origin", "*");
			//http://127.0.0.1:8888
			//actionExecutedContext.Response.Content.Headers.Add("Content-Type", "text/javascript");
			//actionExecutedContext.Response.Content.Headers.Add("Access-Control-Allow-Methods","PUT, GET, POST, DELETE, OPTIONS");
			//actionExecutedContext.Response.Content.Headers.Add("Access-Control-Allow-Headers", "origin, access-control-allow-methods, content-type, access-control-allow-origin, access-control-allow-headers");
			//responseHeaders.Add("Access-Control-Max-Age", "1800");

		}

	}
}
