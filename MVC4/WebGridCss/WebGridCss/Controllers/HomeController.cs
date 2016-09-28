using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGridCss.Models;

namespace WebGridCss.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
			List<ProductViewModel> list = new List<ProductViewModel>();
        	list.Add(new ProductViewModel() {Id = 1, Title = "Sony Tv", Desc = "Sony bl bl desc", Price = 1658});
			list.Add(new ProductViewModel() { Id = 2, Title = "LG Tv", Desc = "Sony bl bl desc", Price = 1346 });
			list.Add(new ProductViewModel() { Id = 3, Title = "Samsung Tv", Desc = "Samsung bl bl desc", Price = 4367 });
			list.Add(new ProductViewModel() { Id = 4, Title = "Sharp Tv", Desc = "Sharp bl bl desc", Price = 2345 });
			return View(list);
        }

    }
}
