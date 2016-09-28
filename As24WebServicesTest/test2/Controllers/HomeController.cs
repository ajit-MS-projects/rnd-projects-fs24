using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test2.com.autoscout24.api;

namespace test2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var request = new GetArticleDetailsRequest()
            {
                profile_id = "CPCMS_DE",
                culture_id = "de-DE",
                revision = 3,
                vehicle_id = "229760122",
            };
            var x = new com.autoscout24.api.ArticleSearchFacade();
            x.UseDefaultCredentials = false;
            
       
            NetworkCredential netCredential = new NetworkCredential("Basic", "6N#seJ-");
            Uri uri = new Uri("http://api.autoscout24.com/AS24_WS_Search");
            ICredentials credentials = netCredential.GetCredential(uri, "Basic");
            x.Credentials = credentials;

            
            x.GetArticleDetails(request);
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}