using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc4RoutingTests
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

		

			routes.MapRoute(
				"DefaultView",
				"{controller}/view/{id}",
				new {controller = "Home", action = "Tview", id = UrlParameter.Optional}
				);

			routes.MapRoute(
				"xxview",
				"xxview",
				new {controller = "Home", action = "Tview", id = UrlParameter.Optional}
				);

			routes.MapRoute(
				"admin", // Route name
				"Admin", // URL with parameters
				new {controller = "Home", action = "Index"} // Parameter defaults
				);

			routes.MapRoute(
			name: "Default",
			url: "{controller}/{action}/{id}",
			defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}