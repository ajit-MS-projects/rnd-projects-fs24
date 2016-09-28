using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMvc4.Models;

namespace LearnMvc4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
		public ActionResult About()
		{
			return View();
		}

		[HttpPost]
		public ActionResult ShowProduct(Employee model)
		{
			model.Name += " added via backend";
			//return Json(model);
			//return Content("any text");
			return PartialView(model);
		}

    }
}
