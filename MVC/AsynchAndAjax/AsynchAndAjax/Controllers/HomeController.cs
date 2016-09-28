using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsynchAndAjax.Models;
using Microsoft.Web.Mvc;

namespace AsynchAndAjax.Controllers
{
    public class HomeController : Controller
    {
		
        public ActionResult Index()
        {
        	String s = "id=1,Title=2";
			//MvcSerializer  ser = new MvcSerializer();

			//ProductViewModel m = (ProductViewModel)ser.Deserialize(s, SerializationMode.Signed);
            return View();
        }


		[HttpPost]
		public ActionResult ShowProduct(ProductViewModel model)
		{
			model.Title += " added via backend";
			//return Json(model);
			//return Content("any text");
			return PartialView(model);
		}


		[AjaxOnly]
		[HttpPost]
		public ActionResult ShowProductJson(ProductViewModel model)
		{
			model.Title += " added via json backend";
			return Json(model);
		}


		[HttpPost]
		public ActionResult ShowProductForm(ProductViewModel model)
		{
			model.Title += " added via backend";
			//return Json(model);
			//return Content("any text");
			return View(model);
		}
    }
}
