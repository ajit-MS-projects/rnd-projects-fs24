using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace TimerInWeb.Controllers
{
    public class HomeController : Controller
    {
    	public static string date = null;

        public ActionResult Index()
        {
			ViewBag.myDate = date?? "nothing in date";
            return View();
        }
	
    }
}
