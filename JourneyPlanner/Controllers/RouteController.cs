using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JourneyPlanner.Data;

namespace JourneyPlanner
{
	[RoutePrefix("api/routes")]
	public class RouteController : BaseApiController
	{
		public RouteController(IJourneyPlannerRepository repo) : base(repo) { }

		[Route("")]
		public IHttpActionResult Get(String Start, String Destination, String Via = null, String Excluding = null)
		{
			var results = "stay where you are";

			return Ok(results);
		}
	}
}
