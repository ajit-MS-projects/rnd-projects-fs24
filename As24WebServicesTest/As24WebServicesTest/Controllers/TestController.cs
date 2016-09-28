using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Web;
using System.Web.Mvc;
using As24WebServicesTest.As24;

namespace As24WebServicesTest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(string vehicleId)
        {
            vehicleId = string.IsNullOrWhiteSpace(vehicleId) ? "283422011" : vehicleId;
            BasicHttpBinding binding = new BasicHttpBinding();

            binding.SendTimeout = TimeSpan.FromSeconds(25);

            binding.Security.Mode = BasicHttpSecurityMode.Transport;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            EndpointAddress address = new EndpointAddress("https://api.autoscout24.com/AS24_WS_Search");

            var factory =
                         new ChannelFactory<IArticleSearch>(binding, address);

            var credentialBehaviour = factory.Endpoint.Behaviors.Find<ClientCredentials>();
            credentialBehaviour.UserName.UserName = @"CarHistory";
            credentialBehaviour.UserName.Password = @"6N#seJ-";

            var proxy = factory.CreateChannel();

            
            var request = new GetArticleDetailsRequest()
            {
                profile_id = "CPCMS_DE",
                culture_id = "de-DE",
                revision = 3,
                //vehicle_id = "285753713",// "282705606",
                vehicle_id =vehicleId// "283422011",// "282705606",
            };

            var response= proxy.GetArticleDetails(request);
            return View(response);
        }

       
    }
}