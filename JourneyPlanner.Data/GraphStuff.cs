using System;
using System.Linq;
using System.Collections.Generic;

namespace Graph
{
	class Node
	{
		private bool _isVisited;

		public int Value;
		public List<Node> Connected = new List<Node>();
		public bool IsVisited
		{
			get { return _isVisited; }
			set
			{
				//Console.WriteLine($"{Value} has been visited."); 
				_isVisited = value;
			}
		}
	}

	static class Generator
	{
		public static List<Node> GetAllNodes()
		{
			Node nodeOne = new Node { Value = 1 };
			Node nodeTwo = new Node { Value = 2 };
			Node nodeThree = new Node { Value = 3 };
			Node nodeFour = new Node { Value = 4 };
			Node nodeFive = new Node { Value = 5 };
			Node nodeSix = new Node { Value = 6 };
			Node nodeSeven = new Node { Value = 7 };
			Node nodeEight = new Node { Value = 8 };
			Node nodeNine = new Node { Value = 9 };
			Node nodeTen = new Node { Value = 10 };
			Node nodeEleven = new Node { Value = 11 };

			nodeOne.Connected.Add(nodeTwo);
			nodeOne.Connected.Add(nodeThree);
			nodeOne.Connected.Add(nodeFour);

			nodeTwo.Connected.Add(nodeFive);
			nodeTwo.Connected.Add(nodeOne);

			nodeFive.Connected.Add(nodeSeven);
			nodeFive.Connected.Add(nodeTwo);

			nodeSeven.Connected.Add(nodeNine);
			nodeSeven.Connected.Add(nodeFive);

			nodeNine.Connected.Add(nodeSeven);
			nodeNine.Connected.Add(nodeTen);

			nodeTen.Connected.Add(nodeNine);
			nodeTen.Connected.Add(nodeEight);
			nodeTen.Connected.Add(nodeEleven);

			nodeEleven.Connected.Add(nodeTen);

			nodeEight.Connected.Add(nodeTen);
			nodeEight.Connected.Add(nodeSix);

			nodeSix.Connected.Add(nodeEight);
			nodeSix.Connected.Add(nodeThree);

			nodeThree.Connected.Add(nodeOne);
			nodeThree.Connected.Add(nodeSix);

			return new List<Node>(new[] { nodeOne, nodeTwo, nodeThree, nodeFour, nodeFive, nodeSix, nodeSeven, nodeEight, nodeNine, nodeTen, nodeEleven });

		}
	}

	class GraphMe
	{
		public List<Node> HappyPath = new List<Node>();

		public List<Node> GetPath(int start, int dest)
		{
			var graph = Generator.GetAllNodes();

			var head = graph.First(n => n.Value == start);
			var destination = graph.First(n => n.Value == dest);
			MarkNode(head, destination);

			return new List<Node>(new[] { head });
		}

		public bool MarkNode(Node iterator, Node stop)
		{
			//Console.WriteLine($"Push onto the stack {iterator.Value}");

			if (iterator == stop)
			{
				//Console.WriteLine($"1: Pop from the stack {iterator.Value}");
				HappyPath.Add(iterator);
				return true;
			}

			iterator.IsVisited = true;
			foreach (var node in iterator.Connected)
			{
				if (node.IsVisited == false)
				{
					if (MarkNode(node, stop))
					{
						//Console.WriteLine($"2: Pop from the stack {iterator.Value}");
						HappyPath.Add(iterator);
						return true;
					}
				}

			}

			//Console.WriteLine($"3: Pop from the stack {iterator.Value}");
			return false;

		}

	}

	class MainClass
	{

		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var main = new GraphMe();

			main.GetPath(1, 11);

			main.HappyPath.ForEach(p => Console.WriteLine(p.Value));
		}

	}
}
