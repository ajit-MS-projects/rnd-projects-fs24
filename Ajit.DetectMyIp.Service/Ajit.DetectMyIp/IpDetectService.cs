using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ajit.DetectMyIp.Http;

namespace Ajit.DetectMyIp
{
	public class IpDetectService
	{
		public static string GetMyIp()
		{
			var objJsonAccess = new HttpJson<GeoIpModel>();
			GeoIpModel response = objJsonAccess.GetObjectFromJsonUrl("http://freegeoip.net/json/");
			
			return response.ip;
		}
	}
}
