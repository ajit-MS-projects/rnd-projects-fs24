using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GoogleFake.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
	        var x=  Request.Url.Query;
			return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "Bad Gateway");
            return View();
        }

    }
}
