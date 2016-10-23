using System;
using System.Collections.Generic;

namespace JourneyPlanner.Data
{
	public interface IJourneyPlannerRepository
	{
		 List<Node> Get();
	}
}
