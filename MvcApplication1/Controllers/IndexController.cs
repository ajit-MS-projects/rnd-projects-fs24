using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrystalDecisions.Shared;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/

		public ActionResult Index()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
		/*	ExportOptions crExportOptions = new ExportOptions();
			DiskFileDestinationOptions crDiskFileDestinationOptions = new DiskFileDestinationOptions();
			HTMLFormatOptions HTML40Formatopts = new HTMLFormatOptions();
			var crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			crReportDocument.Load(@"D:\ajit\rnd\MvcApplication1\Reports\CrystalReport2.rpt");

			List<Tracking> data = new List<Tracking>();
			data.Add(new Tracking() {AdvertiserId = 1});
			data.Add(new Tracking() { AdvertiserId = 2 });
			data.Add(new Tracking() { AdvertiserId = 3 });
			data.Add(new Tracking() { AdvertiserId = 1 });
			data.Add(new Tracking() { AdvertiserId = 2 });
			data.Add(new Tracking() { AdvertiserId = 3 });
			data.Add(new Tracking() { AdvertiserId = 1 });
			data.Add(new Tracking() { AdvertiserId = 2 });
			data.Add(new Tracking() { AdvertiserId = 3 });
			data.Add(new Tracking() { AdvertiserId = 1 });
			data.Add(new Tracking() { AdvertiserId = 2 });
			data.Add(new Tracking() { AdvertiserId = 3 });
			data.Add(new Tracking() { AdvertiserId = 1 });
			data.Add(new Tracking() { AdvertiserId = 2 });
			data.Add(new Tracking() { AdvertiserId = 3 });
			data.Add(new Tracking() { AdvertiserId = 1 });
			data.Add(new Tracking() { AdvertiserId = 2 });
			data.Add(new Tracking() { AdvertiserId = 6 });

			crReportDocument.SetDataSource(data);

			crDiskFileDestinationOptions = new DiskFileDestinationOptions();
			crExportOptions = crReportDocument.ExportOptions;

			crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
			crExportOptions.ExportFormatType = ExportFormatType.HTML40;

			HTML40Formatopts.HTMLBaseFolderName = @"d:\Temp\HTML app";
			HTML40Formatopts.HTMLFileName = "HTML40.html";
			HTML40Formatopts.HTMLEnableSeparatedPages = true;
			HTML40Formatopts.HTMLHasPageNavigator = true;
			HTML40Formatopts.FirstPageNumber = 1;
			HTML40Formatopts.LastPageNumber = 2;
			HTML40Formatopts.UsePageRange = true;

			crExportOptions.FormatOptions = HTML40Formatopts;
			
			crReportDocument.Export();*/

			return View();
		}

    }
}
