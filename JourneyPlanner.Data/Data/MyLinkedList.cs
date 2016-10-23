using System;
using System.Collections;
using System.Collections.Generic;

namespace JourneyPlanner
{
	public class MyLinkedList
	{
		public MyLinkedList() {
			_head = new Node();
				_current = _head;
		}
		private Node _head;
		private Node _current;//This will have latest node
		public int Count;
	}
}
