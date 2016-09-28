using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WebServiceToCsv.Contracts;
using WebServiceToCsv.Contracts.Services;
using WebServiceToCsv.Data;
using WebServiceToCsv.Services;
using WebServiceToCsv.UI.Models;

namespace WebServiceToCsv.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
        	ViewBag.BaseExportUrl = ConfigurationManager.AppSettings.Get("BaseExportUrl");
			ITyresExportService tyresExport = new TyresExportService();
        	var exportSettings = tyresExport.GetExportSettings();
            return View(exportSettings);
        }
		public ActionResult AddNewExportSetting()
		{
			ITyresExportService tyresExport = new TyresExportService();
			IExportSettings settings = tyresExport.GetDefaultExportSettings();
			
			return View(settings);
		}

		public ActionResult EditExportSetting(int exportId)
    	{
			ITyresExportService tyresExport = new TyresExportService();

			IExportSettings exportSetting = tyresExport.GetExportSetting(exportId);

    		return View(exportSetting);
    	}

		[HttpPost]
		public ActionResult EditExportSetting(ExportSettings exportSetting)
		{
			ITyresExportService tyresExport = new TyresExportService();
			tyresExport.SaveExportSettings(exportSetting);

			return View(exportSetting);
		}

		public ActionResult DetailsExportSetting(int exportId)
		{
			ITyresExportService tyresExport = new TyresExportService();
			MappingsAndSavedRequests mappingsAndSavedRequests = new MappingsAndSavedRequests();

			mappingsAndSavedRequests.ExportSettings = tyresExport.GetExportSetting(exportId);

			mappingsAndSavedRequests.Mappings = tyresExport.GetMappings(exportId);

			mappingsAndSavedRequests.SavedRequests = tyresExport.GetSavedTyreRequests(exportId);

			return View(mappingsAndSavedRequests);
		}

		public ActionResult Export(int exportId=0)
		{
			ITyresExportService tyresExport = new TyresExportService();
			tyresExport.ExportCsv(exportId);

			return View();
		}

		public ActionResult DeleteExistingDbAndCreateNewSchema(string password, int createNewSchema = 0)
		{
			if (createNewSchema == 1 && password == "DAC90ABA3673468BA86B7F6D39BFFA24")
			{
				IDataService dataService = new DataService();
				dataService.CreateDbSchema();
				ViewBag.message = "New db schema generated.";
			}
			else
				ViewBag.message = "CreateNewSchema must be set to 1 and password must macth.";
			return View();
		}

		#region mapping
		public ActionResult AddNewMapping(int exportId)
		{
			ITyresExportService tyresExport = new TyresExportService();
			List<IMapping> mappings = tyresExport.GetDefaultMappings(exportId);

			return View(mappings);
		}

    	public ActionResult EditMapping(int id)
    	{
    		ITyresExportService tyresExport = new TyresExportService();
			IMapping mapping = tyresExport.GetMapping(id);

			return View(mapping);
    	}
		[HttpPost]
		public ActionResult EditMapping(Mapping mapping)
		{
			ITyresExportService tyresExport = new TyresExportService();
			tyresExport.SaveMapping(mapping);

			return View();
		}
		#endregion
    }
}
