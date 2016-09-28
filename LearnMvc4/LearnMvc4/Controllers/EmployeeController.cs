using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMvc4.Models;
using MvcSiteMapProvider;

namespace LearnMvc4.Controllers
{
    public class EmployeeController : Controller
    {
		List<Employee> el = new List<Employee>();
	    public EmployeeController()
	    {
		    Employee e = new Employee();
		    e.Id = 1;
		    e.Name = "Ajit";
		    e.Department = "Dev";
		    e.Designation = Designations.Developer;
		    e.Salary = 23461;
		    el.Add(e);
		    e = new Employee();
		    e.Id = 2;
		    e.Name = "Sachin";
		    e.Department = "Clerk";
		    e.Designation = Designations.Contract;
		    e.Salary = 9999;
		    el.Add(e);
		    e = new Employee();
		    e.Id = 3;
		    e.Name = "Vinit";
		    e.Department = "Tester";
		    e.Designation = Designations.Fest;
		    e.Salary = 78543;
		    el.Add(e);
	    }

		
	    public ActionResult Index()
        {
            return View(el);
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id)
        {
	        var xx = el.Where(x => x.Id == id).FirstOrDefault();
	        return View(xx);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id)
        {
			var xx = el.FirstOrDefault(x => x.Id == id);
	        ViewBag.xxx = "lll oooo ppp";
			ViewData.Add("uu",22);
			return View(xx);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            try
            {
				var e = el.FirstOrDefault(x => x.Id == emp.Id);
	            e.Salary = emp.Salary;
				e.Name = emp.Name;
				e.Department = emp.Department;
				e.Designation = emp.Designation;

				return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
