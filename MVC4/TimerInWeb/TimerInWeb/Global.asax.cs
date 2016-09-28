using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using TimerInWeb.Controllers;

namespace TimerInWeb
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801
	public class MvcApplication : System.Web.HttpApplication
	{
		private static CacheItemRemovedCallback OnCacheRemove = null;
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			AddTask("DoStuff", 60);
		}


		private void AddTask(string name, int seconds)
		{
			OnCacheRemove = new CacheItemRemovedCallback(CacheItemRemoved);
			HttpRuntime.Cache.Insert(name, seconds, null,
				DateTime.Now.AddSeconds(seconds), Cache.NoSlidingExpiration,
				CacheItemPriority.NotRemovable, OnCacheRemove);
		}

		public void CacheItemRemoved(string k, object v, CacheItemRemovedReason r)
		{
			HomeController.date = DateTime.Now.ToString();
			// do stuff here if it matches our taskname, like WebRequest
			// re-add our task so it recurs
			AddTask(k, Convert.ToInt32(v));
		}
	}
}