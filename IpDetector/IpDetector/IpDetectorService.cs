using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;

namespace IpDetector
{
	public partial class IpDetectorService : ServiceBase
	{
		public IpDetectorService()
		{
			InitializeComponent();
		}

		private string userAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:12.0) Gecko/20100101 Firefox/12.0 ";
		private string url = "http://automation.whatismyip.com/n09230945.asp";
		protected override void OnStart(string[] args)
		{
			string ip = GetIp();
			send mail
		}

		protected override void OnStop()
		{
		}

		private string GetIp()
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			request.UserAgent = userAgent;
			request.Accept = "text/html, application/xhtml+xml, */*";
			request.Headers.Add("Request", "GET HTTP/1.1");

			request.Timeout = 2000;

			System.Net.WebResponse webResponse = request.GetResponse();

			Stream dataStream = webResponse.GetResponseStream();

			StreamReader reader = new StreamReader(dataStream);
			string responseFromServer = reader.ReadToEnd();

			return responseFromServer;
		}
	}
}
