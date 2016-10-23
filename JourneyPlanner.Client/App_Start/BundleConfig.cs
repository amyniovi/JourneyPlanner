using System;
using System.Web.Optimization;

namespace JourneyPlanner.Client
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles) {

			bundles.Add(new ScriptBundle("~/bundles/JourneyPlanner")
						.IncludeDirectory("~/Scripts/Controllers","*.js")
						.Include("~/Scripts/app.js")
			           );
		}
	}
}
