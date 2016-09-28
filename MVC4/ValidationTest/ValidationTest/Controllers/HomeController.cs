using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationTest.Models;

namespace ValidationTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
        	var tip = new UserTipViewModel() {Id = 1, Title = "test t", ValidTo = DateTime.Now};
			return View(tip);
        }
		public ActionResult Create()
		{
			var tip = new UserTipViewModel();
			return View();
		}

		[HttpPost]
		public ActionResult Create(UserTipViewModel tip)
		{
			return View("Index", tip);
		}
    }
}
