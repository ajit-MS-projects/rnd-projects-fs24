using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class GridTestController : Controller
    {
        //
        // GET: /GridTest/

        public ActionResult Index()
        {
			List<EmpViewModel> lst = new List<EmpViewModel>();
        	lst.Add(new EmpViewModel() {Id = 1, Name="Abc", Salary = 2132.55});
			lst.Add(new EmpViewModel() { Id = 2, Name = "Abc2", Salary = 32.55 });
			lst.Add(new EmpViewModel() { Id = 3, Name = "Abc3", Salary = 56.55 });

			Kendo.Mvc.UI.Fluent.GridBuilder<T> 

            return View(lst);
        }
		public class EmpViewModel
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public double Salary { get; set; }

		}
    }
}
