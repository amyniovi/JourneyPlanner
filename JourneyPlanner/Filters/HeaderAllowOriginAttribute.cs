using System;
using System.Web.Http.Filters;

namespace JourneyPlanner
{
	public class HeaderAllowOriginAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
		{
			actionExecutedContext.Response.Content.Headers.Add("Access-Control-Allow-Origin", "*");
		}

	}
}
