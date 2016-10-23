using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;
using JourneyPlanner.Data;
using System.Linq;

namespace JourneyPlanner
{
	[RoutePrefix("api/routes")]
	public class RouteController : BaseApiController
	{
		public RouteController(IJourneyPlannerRepository repo) : base(repo) { }

		//http://127.0.0.1:8080/api/routes?start=dkd&destination=jfoi
		[Route("")]
		public IHttpActionResult Get(String start, String destination, String via = null, String excluding = null)
		{

			var results = new List<string>();
			//get via
			//get excl


			var graph = Repo.Get();
			var happyPath = RouteProviderService.GetHappyPath(graph, start, destination);
			//RouteModel.Create(List<Route>)
			happyPath.ForEach(node => results.Add(node.Station.Name));
			return Ok(results);
		}

	}

	public static class RouteProviderService
	{
		private static List<Node> _happyPath = new List<Node>();


		public static List<Node> GetHappyPath(List<Node> graph, string start, string destination, string via = null, string excluding = null)
		{

			var head = graph.First(n => n.Station.Name == start);
			var finish = graph.First(n => n.Station.Name == destination);

			TraversePath(head, finish);
			return _happyPath;

		}

		private static bool TraversePath(Node current, Node finish)
		{


			var happyPath = new List<Node>();


			if (current == finish)
			{
				current.isVisited = true;
				happyPath.Add(current);
				return true;
			}

			//if (!current.Connected.Any())
			//	return false;

			current.isVisited = true;
			foreach (var node in current.Connected)
			{
				if (!node.isVisited)
				{
					if (TraversePath(node, finish))
					{

						_happyPath.Add(current);
						return true;
					}
				}

			}
			return false;

		}

	}





}
