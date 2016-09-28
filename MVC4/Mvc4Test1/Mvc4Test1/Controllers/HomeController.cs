using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using Mvc4Test1.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Mvc4Test1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
		[AllowAnonymous]
        public ActionResult Index()
        {
			CourseModel course = new CourseModel() //{ Name = "c#" + DateTime.Now, StartDate = DateTime.Now };
			{ CreateDate = DateTime.Now.AddDays(21), Name = "c#" + DateTime.Now, StartDate = DateTime.Now.AddDays(21) };
			return View(course);
        }

		public ActionResult Edit(int id=1)
		{
			CourseModel course1 = new CourseModel() { CreateDate = DateTime.Now.AddDays(21), Name = "Saving", StartDate = DateTime.Now.AddDays(21) };
			return View(course1);
		}
		[HttpPost]
		public ActionResult Edit(CourseModel course)
		{
			CourseModel course1 = new CourseModel() { CreateDate = DateTime.Now.AddDays(21), Name = "Saved...!", StartDate = DateTime.Now.AddDays(21) };
			return View("Edit", course1);
		}
		public ContentResult JsonIndex()
		{
			var obj = new Mytest();
			return  Content(JsonConvert.SerializeObject(obj) , "application/json");
		}
		public ContentResult XmlIndex()
		{
			var obj = new Mytest();
			return this.Content(SerializeToString(obj), "text/xml");
		}

		private static string SerializeToString(object obj)
		{
			XmlSerializer serializer = new XmlSerializer(obj.GetType());

			using (StringWriter writer = new StringWriter())
			{
				serializer.Serialize(writer, obj);

				return writer.ToString();
			}
		}
		public class Mytest
		{
			public int Id = 1;
			public string Name = "Munich";
			[JsonConverter(typeof(StringEnumConverter))]
			public TestEnum MyEnum=TestEnum.Second;
		}
		public enum TestEnum
		{
			First,
			Second,
			Third
		}
    }
}
