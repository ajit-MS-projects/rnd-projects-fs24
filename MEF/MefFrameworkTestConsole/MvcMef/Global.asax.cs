using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MefContrib.Hosting.Conventions;
using MefContrib.Web.Mvc;

namespace MvcMef
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			Compose();
			AreaRegistration.RegisterAllAreas();

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);
		
		}

		private void Compose1()
		{
			var catalog = new DirectoryCatalog("bin", "*ProductBusiness*.dll");
			var container = new CompositionContainer(catalog);
			container.ComposeParts(this);
		}
		private void Compose()
		{
			//var catalog = new AggregateCatalog(
			//   new DirectoryCatalog("bin"),
			//   new ConventionCatalog(new MvcApplicationRegistry()));

			//var dependencyResolver = new CompositionDependencyResolver(catalog);
			//DependencyResolver.SetResolver(dependencyResolver);

			//var container = new CompositionContainer(catalog);
			//container.ComposeParts(this);
		}
	}
}