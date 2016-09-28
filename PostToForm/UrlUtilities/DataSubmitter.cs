using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace UrlUtilities
{
	public class DataSubmitter
	{
		//http://stackoverflow.com/questions/14702902/post-form-data-using-httpwebrequest
		public void PostToForm<T>() where T:class 
		{
			
		}
		public void SubmitJsonToUrl<T>(T objectToPost, string url, SubmitMethod method) where T:class
		{
			var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(objectToPost);

			var req = (HttpWebRequest)WebRequest.Create(url);
			req.KeepAlive = false;
			req.UserAgent = "Sparacuda";
			req.Method = "POST";
			req.ContentType = "application/x-www-form-urlencoded";

			byte[] data = Encoding.ASCII.GetBytes(jsonString);
			req.ContentLength = data.Length;
			using (var input = req.GetRequestStream())
			{
				input.Write(data, 0, data.Length);
				input.Flush();
				input.Close();
			}

		}

	}
	public enum SubmitMethod
	{
		Get,
		Post
	}
}
