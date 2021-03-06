﻿using System;
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

		//http://127.0.0.1:8080/api/routes/start/destination
		[Route("{start}/{destination}")]
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
		private static Node _startNode = null;
		private static Node _finishNode = null;
		private static List<Node> _invalidNodes = new List<Node>();
		private static List<Node> _happyPathLame = new List<Node>();


		public static List<Node> GetHappyPath(List<Node> graph, string start, string destination, string via = null, string excluding = null)
		{
			
			var head = graph.First(n => n.Station.Name == start);
			var finish = graph.First(n => n.Station.Name == destination);

			_startNode = head;
			_finishNode = finish;
			TraversePath(head, finish);
			//_happyPath.AddRange(_happyPathLame);
			foreach (var node in _invalidNodes)
			{
				_happyPath.Remove(node);
			}
			return _happyPath;

		}

		private static bool TraversePath(Node current, Node finish)
		{


			if (current == finish)
			{
				current.isVisited = true;
				_happyPath.Add(current);
				//return true;
			}
			else if (current.Connected.Count == 1)
			{
				_invalidNodes.Add(current);
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

			_happyPath.Add(current);

			return false;

		}


	}





}
