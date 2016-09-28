using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;
using System.Web.Mvc;
using As24WebServicesTest.As24;
using As24WebServicesTest.As24Lookup;

namespace As24WebServicesTest.Controllers
{
    public class As24CarInfoController : Controller
    {
        private static GetLookupDataResponse LookupResponse = null;
        // GET: As24CarInfo
        public ActionResult Index(string vehicleId)
        {
            vehicleId = string.IsNullOrWhiteSpace(vehicleId) ? "280592137" : vehicleId;

            var arResponse = GetResponse(vehicleId);
            var lookupResponse = GetLookup();

            var model = new VehicleInfoModel();
            model.Title = lookupResponse.stx3_idpool.elements.Where(x => x.id == arResponse.vehicle.brand_id.ToString() && x.name == "brand").FirstOrDefault().text;

            var subTitle = arResponse.vehicle.owners_offer_key + " " + arResponse.vehicle.version;

            if (string.IsNullOrWhiteSpace(subTitle))
            {
                subTitle = lookupResponse.stx3_idpool.elements.Where(x => x.id == arResponse.vehicle.model_id.ToString() && x.name == "model").FirstOrDefault().text;
            }

            var customer_type_id = arResponse.vehicle.previous_owner.owner.FirstOrDefault().x_code.customer_type_id;
            model.CustomerType = lookupResponse.stx3_idpool.elements.Where(x => x.id == customer_type_id && x.name == "customer_type").FirstOrDefault().text;


            model.Title += " " + subTitle;
            model.SmallImage = arResponse.root_paths.images_small + arResponse.vehicle.media.images[0].uri;
            model.LargeImage = arResponse.root_paths.images_big + arResponse.vehicle.media.images[0].uri;

            model.KiloWatt = arResponse.vehicle.kilowatt.ToString();
            model.Kilometers = arResponse.vehicle.mileage.ToString();
            model.FirstRegistration = arResponse.vehicle.initial_registration.ToShortDateString();

            return View(model);
        }

        private GetLookupDataResponse GetLookup()
        {
            if (LookupResponse != null) return LookupResponse;
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = 65536*50;

            binding.SendTimeout = TimeSpan.FromSeconds(25);

            binding.Security.Mode = BasicHttpSecurityMode.Transport;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            EndpointAddress address = new EndpointAddress("https://api.autoscout24.com/AS24_WS_Lookup");

            var factory =
                         new ChannelFactory<ILookup>(binding, address);

            var credentialBehaviour = factory.Endpoint.Behaviors.Find<ClientCredentials>();
            credentialBehaviour.UserName.UserName = @"CarHistory";
            credentialBehaviour.UserName.Password = @"6N#seJ-";

            var proxy = factory.CreateChannel();


            var request = new GetLookupDataRequest()
            {
                profile_id = "CPCMS_DE",
                culture_id = "de-DE",
                revision = 3,
                vehicle_type_id = "C",
            };

            var response = proxy.GetLookupData(request);
            return response;
        }

        private GetArticleDetailsResponse GetResponse(string vehicleId)
        {
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
                //vehicle_id = "282705606",
                vehicle_id = vehicleId,
            };

            var response = proxy.GetArticleDetails(request);
            return response;
        }
    }

    public class VehicleInfoModel
    {
        public string Title { get; set; }
        public string Kilometers { get; set; }
        public string FirstRegistration { get; set; }
        public string KiloWatt { get; set; }
        public string SmallImage{ get; set; }
        public string LargeImage { get; set; }
        public string CustomerType { get; set; }
    }
}