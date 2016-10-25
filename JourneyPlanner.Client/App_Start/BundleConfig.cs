using System;
using System.Web.Optimization;

namespace JourneyPlanner.Client
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{

			bundles.Add(new ScriptBundle("~/bundles/JourneyPlanner")
				
				
				.Include("~/Scripts/app.js")

			            .IncludeDirectory("~/Scripts/Services", "*.js")
			            .IncludeDirectory("~/Scripts/Controllers", "*.js")
			            .Include("~/Scripts/bootstrap.min.js")
			            .Include("~/Scripts/jquery-1.9.1.min.js")
					   );
		}
	}
}
