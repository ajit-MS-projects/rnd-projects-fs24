using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Rotativa;
using Rotativa.Options;

namespace Charting.Controllers
{
    //http://www.asp.net/web-pages/overview/data/7-displaying-data-in-a-chart    ms tutorial on avrious charts
    //http://stackoverflow.com/questions/1324597/how-to-render-an-asp-net-mvc-view-in-pdf-format //just referance on how to create a pdf from action controller
    //http://stackoverflow.com/questions/12098276/asp-mvc-4-0-chart-control-rendering-image-properly   place image in controller
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Chart()
        {
            return View();
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        public ActionResult Index2()
        {
            Response.ContentType = "application/pdf";
            return View();
        }

        
        public ActionResult PrintIndex()
        {
            return new ActionAsPdf("Index", null)
            {
                FileName = "Test.pdf",
                PageSize = Size.A4,
                CustomSwitches = "--no-stop-slow-scripts --javascript-delay 1000 "

            };
        }
        public ActionResult PrintUrl()
        {
            //return new UrlAsPdf("http://www.whatismyscreenresolution.com/");
            var a =  new UrlAsPdf("http://www.highcharts.com/demo/line-basic");
            a.CustomSwitches = "--no-stop-slow-scripts --javascript-delay 1000 ";

            return a;
            return new ActionAsPdf("Index", null)
            {
                FileName = "Test.pdf",
                PageSize = Size.A4,
                CustomSwitches = "--no-stop-slow-scripts --javascript-delay 1000 "

            };
        }
        public ActionResult TestViewWithModel(string id)
        {
            var model = new  { DocTitle = id, DocContent = "This is a test" };
            return new ViewAsPdf();
        }

        public FileResult DataChart()
        {
            Chart newChart = new Chart(width: 200, height: 200)
                .AddTitle("My cool pie chart from controller")
                .AddSeries(
                    name: "Employee", chartType: "Pie",
                    xValue: new[] {"Peter", "Andrew", "Julie", "Mary", "Dave"},
                    yValues: new[] {"2", "6", "4", "5", "3"});
            var returnVal = new MemoryStream(newChart.GetBytes());
            return File(returnVal , @"image/png");
        }
    }
}