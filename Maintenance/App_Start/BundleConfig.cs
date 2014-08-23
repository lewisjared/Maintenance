﻿using System.Web;
using System.Web.Optimization;

namespace Maintenance
{
	public class BundleConfig
	{
		// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

			bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap.css",
				"~/Content/bootstrap-theme.css", "~/Content/bootstrap-slider.css"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js",
				"~/Scripts/bootstrap-slider.js"));

			bundles.Add(new ScriptBundle("~/bundles/chart").Include("~/Scripts/Chart.js"));

			//BundleTable.EnableOptimizations = true;
		}
	}
}