using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductContracts.Models;
using ProductContracts.Services;

namespace MvcMef.Controllers
{
    public class HomeController : Controller
    {
		protected IProductService ProductService { get; set; }

		[ImportingConstructor]
		public HomeController(IProductService productService)
		{
			ProductService = productService;
		}

        public ActionResult Index()
        {
        	IProduct prod  = ProductService.GetProduct(1);
        	ViewBag.ProdTitle = prod.Title;

			return View();
        }
    }
}
