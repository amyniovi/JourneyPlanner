using System;
using System.Collections.Generic;
namespace JourneyPlanner
{
	public class Node
	{
		public Station Station;
		public bool isVisited;
		public List<Link> Links;
		public Station Next;

	}
}
