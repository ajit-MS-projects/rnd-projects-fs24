using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityTest1.Filters;
using EntityTest1.Models;

namespace EntityTest1.Controllers
{
	[InitializeSimpleMembership]
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			NetzcodeLandViewModel model = new NetzcodeLandViewModel();

			using (var context = new DataContext())
			{
				var dbNetzcodes = context.Netzcodes.ToList();
				model.Netzcodes = new List<NetzcodeViewModel>();
				foreach (var dbNetzcode in dbNetzcodes)
				{
					var viewModel = new NetzcodeViewModel
					                	{
					                		LaenderZuordnung = dbNetzcode.LaenderZuordnung, 
											NetzcodeID = dbNetzcode.NetzcodeID
					                	};
					model.Netzcodes.Add(viewModel);
				}
				

				model.Lands = context.Lands.ToList();
			}
			return View(model);
			
		}
		public ActionResult AddLand(string land)
		{
			using (var context = new DataContext())
			{
				Land l = new Land() { Name = land };
				
				context.Lands.Add(l);

				context.SaveChanges();
			}

			return RedirectToAction("Index");
		}

		public ActionResult AddNetzcode(List<string> lands)
		{
			using (var context = new DataContext())
			{
				
				
				Netzcode n = new Netzcode() { LaenderZuordnung = new List<Land>() };

				foreach (var land in lands)
				{
					var l = context.Lands.Find(int.Parse(land));
					var ll = new Land() {Id = l.Id, Name = l.Name, Netzcodes = l.Netzcodes};
					//context.Entry(ll).State = System.Data.EntityState.Unchanged;
					//context.Entry(ll).CurrentValues.SetValues(ll);
					//context.Lands.Attach(ll);
					n.LaenderZuordnung.Add(l);
				}
				
				context.Netzcodes.Add(n);

				context.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}
