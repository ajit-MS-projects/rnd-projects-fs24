using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ajit.DetectMyIp
{
	internal class GeoIpModel
	{
		public string ip { get; set; }
		public string country_code { get; set; }
		public string country_name { get; set; }
		public string region_code { get; set; }
		public string region_name { get; set; }
		public string city { get; set; }
		public string zipcode { get; set; }
		public int latitude { get; set; }
		public int longitude { get; set; }
		public string metro_code { get; set; }
		public string areacode { get; set; }
	}
}