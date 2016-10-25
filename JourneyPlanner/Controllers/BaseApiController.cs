using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JourneyPlanner.Data;

namespace JourneyPlanner
{
	[HeaderAllowOriginAttribute]
	public abstract class BaseApiController : ApiController
	{
		IJourneyPlannerRepository _repo;
		ModelFactory _modelFactory;

		public BaseApiController(IJourneyPlannerRepository repo)
		{
			_repo = repo;
		}

		protected ModelFactory TheModelFactory { 
		
			get {
				if (_modelFactory == null)
					return new ModelFactory(this.Request);
				return _modelFactory;
			}
		
		}

		protected IJourneyPlannerRepository Repo { 
		
			get {return _repo; }
		
		}
	}
}
