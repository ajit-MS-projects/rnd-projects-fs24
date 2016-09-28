using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using Mvc4WebApi.Controllers;
using Mvc4WebApi.Helpers;
using Mvc4WebApi.Models;

namespace Mvc4WebApi
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			ConfigureApi(GlobalConfiguration.Configuration);
			Database.SetInitializer(new BookInitializer());
		}
		void ConfigureApi(HttpConfiguration config)
		{
			var unity = new UnityContainer();
			unity.RegisterType<BooksController>();
			unity.RegisterType<IBookRepository, BookRepository>(
				new HierarchicalLifetimeManager());
			config.DependencyResolver = new IoCContainer(unity);
		}
	}
}