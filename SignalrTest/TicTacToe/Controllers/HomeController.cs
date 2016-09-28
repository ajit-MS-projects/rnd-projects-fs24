using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace TicTacToe.Controllers
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

        public ActionResult Tic(string gameId)
        {
            return View();
        }
        public ActionResult PlayerSelection()
        {
            var games = TicHub.GetAvaialbleHosts();

            return View(games);
        }
        //public string GameOptions(string gameId)
        //{
        //    var requestParams = HttpContext.Request.QueryString;
        //    if (HttpContext.Request.HttpMethod.ToLower() == "post")
        //    {
        //        requestParams = HttpContext.Request.Form;
        //    }
        //    var param = requestParams.Cast<object>().ToDictionary(query => query.ToString(), query => requestParams[query.ToString()]);

        //    var jsonSerializerSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

        //    return JsonConvert.SerializeObject(param, Formatting.Indented, jsonSerializerSettings);
        //}
    }
    public class GameOptions
    {
        public string GameId { get; set; }
    }
}