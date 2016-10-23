using System;
using System.Collections.Generic;
namespace JourneyPlanner
{
	public class Node
	{
		public Station Station;
		public bool isVisited;
		public List<Node> Connected = new List<Node>();
	//	public Node Next;

	}
}
