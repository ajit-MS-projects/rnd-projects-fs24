using System.Collections.Generic;
using FS24.Http.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmbeddedSolrTest.Tests
{

	[TestClass]
	public class UniteTest2
	{

		[TestMethod]
		public void GetObjectFromXmlUrl()
		{
			var Json = new HttpJson<RootObject>(); //http://www.w3schools.com/xml/note.xml
			RootObject retVal = Json.GetObjectFromXmlUrlUsingGet("http://www.w3schools.com/xml/cd_catalog.xml", "/CATALOG");

			Assert.IsNotNull(retVal);
		}

		[TestMethod]
		public void GetJsonString_FromXmlUrl()
		{
			var Json = new HttpJson<RootObject>(); //http://www.w3schools.com/xml/note.xml
			string retVal = Json.GetJsonFromXmlUrlUsingGet("http://www.w3schools.com/xml/cd_catalog.xml", "/CATALOG");

			Assert.IsNotNull(retVal);
		}
	}

	public class CD
	{
		public string TITLE { get; set; }
		public string ARTIST { get; set; }
		public string COUNTRY { get; set; }
		public string COMPANY { get; set; }
		public string PRICE { get; set; }
		public string YEAR { get; set; }
	}

	public class CATALOG
	{
		public List<CD> CD { get; set; }
	}

	public class RootObject
	{
		public CATALOG CATALOG { get; set; }
	}
}
