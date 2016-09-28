using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;
using System.Web.Mvc;
using As24WebServicesTest.As24;

namespace As24WebServicesTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult As24Search()
        {
            var request = new FindArticlesRequest()
            {
                profile_id = "CPCMS_DE",
                culture_id = "de-DE",
                revision = 1,
                vehicle_search_parameters = new SearchParameters()
                {
                    address = new ZipSearch()
                    {
                        countries = new Countries() { "D" }
                    }
                }
            };

            As24.ArticleSearchClient client = new ArticleSearchClient();
            var response = client.FindArticles(request);
            var vehicles = response.vehicles;

            return View(vehicles);
        }
        public ActionResult As24Search0()
        {
            //BasicHttpBinding myBinding = new BasicHttpBinding();
            //myBinding.Security.Mode = BasicHttpSecurityMode.Message;
            //myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            var request = new GetArticleDetailsRequest()
            {
                profile_id = "CPCMS_DE",
                culture_id = "de-DE",
                revision = 3,
                vehicle_id = "229760122",
            };

            ClientCredentials loginCredentials = new ClientCredentials();
            loginCredentials.UserName.UserName = "CarHistory";
            loginCredentials.UserName.Password = "6N#seJ-";


            As24.ArticleSearchClient client = new ArticleSearchClient();

            //client.ClientCredentials.UserName.UserName = "CarHistory";
            //client.ClientCredentials.UserName.Password = "6N#seJ-";
            client.ChannelFactory.Endpoint.Behaviors.RemoveAll<ClientCredentials>();
            client.ChannelFactory.Endpoint.Behaviors.Add(loginCredentials); //add required ones

            var response = client.GetArticleDetails(request);
            var vehicle = response.vehicle;
            
            return View(vehicle);
        }
        //229760122
        public ActionResult As24Search2()
        {

            WebHttpBinding myBinding = new WebHttpBinding();
            myBinding.Security.Mode = WebHttpSecurityMode.None;
            myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            var request = new GetArticleDetailsRequest()
            {
                profile_id = "CPCMS_DE",
                culture_id = "de-DE",
                revision = 3,
                vehicle_id = "229760122",
            };

            EndpointAddress ea = new EndpointAddress("http://api.autoscout24.com/AS24_WS_Search");
            

            As24.ArticleSearchClient client = new ArticleSearchClient(myBinding, ea);
            //As24.ArticleSearchClient client = new ArticleSearchClient("BasicHttpBinding_IArticleSearch");
            client.ClientCredentials.UserName.UserName = "CarHistory";
            client.ClientCredentials.UserName.Password = "6N#seJ-";


            var response = client.GetArticleDetails(request);
            var vehicles = response.vehicle;

            return View(vehicles);
        }


        public ActionResult As24Search3()
        {
            WebHttpBinding myBinding = new WebHttpBinding();
            myBinding.Security.Mode = WebHttpSecurityMode.None;
            myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            var request = new GetArticleDetailsRequest()
            {
                profile_id = "CPCMS_DE",
                culture_id = "de-DE",
                revision = 3,
                vehicle_id = "229760122",
            };

            EndpointAddress ea = new EndpointAddress("http://api.autoscout24.com/AS24_WS_Search");


            As24.ArticleSearchClient client = new ArticleSearchClient(myBinding, ea);
            //As24.ArticleSearchClient client = new ArticleSearchClient("BasicHttpBinding_IArticleSearch");
            client.ClientCredentials.UserName.UserName = "CarHistory";
            client.ClientCredentials.UserName.Password = "6N#seJ-";
            client.Open();


            var response = client.GetArticleDetails(request);
            var vehicles = response.vehicle;

            return View(vehicles);
        }
    }
}