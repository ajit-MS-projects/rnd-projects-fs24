﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcActiveRecordDbGenerator.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

		/// <summary>
		/// Indexes this instance.
		/// </summary>
		/// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

    }
}
