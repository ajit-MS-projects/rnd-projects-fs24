using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Microsoft.Web.Mvc
{
    // in Global.asax.cs Application_Start you can insert these into the ViewEngine chain like so:
    //
    // ViewEngines.Engines.Insert(0, new MobileCapableRazorViewEngine());
    //
    // or
    //
    // ViewEngines.Engines.Insert(0, new MobileCapableRazorViewEngine("iPhone")
    // {
    //     ContextCondition = (ctx => ctx.Request.UserAgent.IndexOf(
    //         "iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
    // });

    public class MobileCapableRazorViewEngine : RazorViewEngine
    {

		public MobileCapableRazorViewEngine()
			: base()
        {
        }


        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName,
                                                  string masterName, bool useCache)
		{
			string overrideViewName = MobileDetectionUtility.IsMobileVersion()
										  ? viewName + ".mobile"
										  : viewName;
			ViewEngineResult result = NewFindView(controllerContext, overrideViewName, masterName, useCache, false);

			// If we're looking for a Mobile view and couldn't find it try again without modifying the viewname
			if (overrideViewName.Contains(".mobile") && (result == null || result.View == null))
			{
				result = NewFindView(controllerContext, viewName, masterName, useCache, false);
			}
			return result;
		}

        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
		{
			 string overridePartialViewName = MobileDetectionUtility.IsMobileVersion()
										  ? partialViewName + ".mobile"
										  : partialViewName;
		   ViewEngineResult result = NewFindView(controllerContext, overridePartialViewName, null, useCache, true);
			// If we're looking for a Mobile partial view and couldn't find it try again without modifying the partialviewname
			if (overridePartialViewName.Contains(".mobile") && (result == null || result.View == null))
			{
				result = NewFindView(controllerContext, partialViewName, null, useCache, true);
			}
			return result;
		}


        private ViewEngineResult NewFindView(ControllerContext controllerContext, string viewName, string masterName,
                                             bool useCache, bool isPartialView)
        {
			//if (!ContextCondition(controllerContext.HttpContext))
			//{
			//    return new ViewEngineResult(new string[] { }); // we found nothing and we pretend we looked nowhere
			//}

            // Get the name of the controller from the path
            string controller = controllerContext.RouteData.Values["controller"].ToString();
            string area = "";
            try
            {
                area = controllerContext.RouteData.DataTokens["area"].ToString();
            }
            catch
            {
            }

            // Apply the view modifier
			//var newViewName = string.Format("{0}.{1}", viewName, ViewModifier);

            // Create the key for caching purposes          
            string keyPath = Path.Combine(area, controller, viewName);

            string cacheLocation = ViewLocationCache.GetViewLocation(controllerContext.HttpContext, keyPath);

            // Try the cache          
            if (useCache)
            {
                //If using the cache, check to see if the location is cached.                              
                if (!string.IsNullOrWhiteSpace(cacheLocation))
                {
                    if (isPartialView)
                    {
                        return new ViewEngineResult(CreatePartialView(controllerContext, cacheLocation), this);
                    }
                    else
                    {
                        return new ViewEngineResult(CreateView(controllerContext, cacheLocation, masterName), this);
                    }
                }
            }
            string[] locationFormats = string.IsNullOrEmpty(area) ? ViewLocationFormats : AreaViewLocationFormats;

            // for each of the paths defined, format the string and see if that path exists. When found, cache it.          
            foreach (string rootPath in locationFormats)
            {
                string currentPath = string.IsNullOrEmpty(area)
                                            ? string.Format(rootPath, viewName, controller)
                                            : string.Format(rootPath, viewName, controller, area);

                if (FileExists(controllerContext, currentPath))
                {
                    ViewLocationCache.InsertViewLocation(controllerContext.HttpContext, keyPath, currentPath);

                    if (isPartialView)
                    {
                        return new ViewEngineResult(CreatePartialView(controllerContext, currentPath), this);
                    }
                    else
                    {
                        return new ViewEngineResult(CreateView(controllerContext, currentPath, masterName), this);
                    }
                }
            }
            return new ViewEngineResult(new string[] { }); // we found nothing and we pretend we looked nowhere
        }
    }
}