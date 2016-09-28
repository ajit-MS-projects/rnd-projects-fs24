using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MvcMobileCapable.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

		public JsonResult JsonTest()
		{
			var obj = new {Name = "Ajit", Company = "Scout24 Services Gmbh"};
			return Json(obj, JsonRequestBehavior.AllowGet);
		}

    }
}
