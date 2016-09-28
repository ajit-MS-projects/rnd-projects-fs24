using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using S24S.Solr.Api.Http;
using System.Net.Http;

namespace Ajit.DetectMyIp.Http
{
    /// <summary>
    /// Basic implementation to read/write jason syntax to .net objects
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public class HttpJson<T> : IHttpJson<T>
    {

        private long responseSize;


	    private static int requestTimeout;

	    private static TimeSpan requestTimeoutTimeSpan;

	    static HttpJson()
	    {
			requestTimeout = 2000;
			requestTimeoutTimeSpan = new TimeSpan(0,0,0,0,requestTimeout);
	    }


        public long ResponseSize { get { return responseSize; } }
        /// <summary>
        /// Gets the object from json stream.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="userAgent">The user agaent.</param>
        /// <returns></returns>
        public T GetObjectFromJsonUrl(String url, String userAgent)
        {
            try
            {
	            return GetObjectFromJsonString(GetResponseUsingUsingHttpWebRequest(userAgent, url, false));

                //responseSize = String.IsNullOrEmpty(responseString) ? 0 : responseString.Length;
                //return GetObjectFromJsonString(responseString);
            }
            catch (WebException ex)
            {
                throw ParseWebException(ex, url);
            }
        }

		private WebClient client = new WebClient();
	    public T GetObjectFromJsonUrlEx(String url)
	    {
		    try
		    {
			    using (Stream s = client.OpenRead(url))
			    {
				    using (StreamReader sr = new StreamReader(s))
				    {
					    using (JsonReader reader = new JsonTextReader(sr))
					    {
						    JsonSerializer serializer = new JsonSerializer();

						    // read the json from a stream
						    // json size doesn't matter because only a small piece is read at a time from the HTTP request
						    return serializer.Deserialize<T>(reader);
					    }
				    }
			    }
		    }
			catch (WebException ex)
			{
				throw ParseWebException(ex, url);
			}
	    }


		//public string GetStringFromJsonUrl(String url, String userAgent)
		//{
		//	try
		//	{
		//		string responseString = (string) GetResponseUsingUsingHttpWebRequest(userAgent, url, false);

		//		responseSize = String.IsNullOrEmpty(responseString) ? 0 : responseString.Length;
		//		return responseString;
		//	}
		//	catch (WebException ex)
		//	{
		//		throw ParseWebException(ex, url);
		//	}
		//}

        /// <summary>
        /// Gets the response using using .nets HttpWebRequest class.
        /// </summary>
        /// <param name="userAgent">The userAgent http header.</param>
        /// <param name="url">The URL.</param>
        /// <param name="keepAlive">if set to <c>true</c> connections are set to keep alive else not.</param>
        /// <returns></returns>
        private static T GetResponseUsingUsingHttpWebRequestPost(string userAgent, string url, bool keepAlive)
        {
            HttpWebRequest oRequest = null;
            String retVal = string.Empty;
			string[] postData = url.Split('?');

            try
            {
				oRequest = (HttpWebRequest)WebRequest.Create(postData[0]);
                oRequest.Method = "GET";
                oRequest.KeepAlive = keepAlive;
                oRequest.Timeout = requestTimeout;
				oRequest.ContentType = "application/x-www-form-urlencoded";
                if (!String.IsNullOrEmpty(userAgent))
                {
	                oRequest.UserAgent = userAgent;
                }

				byte[] postBytes = new UTF8Encoding().GetBytes(postData[1]);
	            using (var requestStream = oRequest.GetRequestStream())
	            {
		            requestStream.Write(postBytes, 0, postBytes.Length);
	            }

	            using (var oResponse = oRequest.GetResponse() as HttpWebResponse)
	            {
		            if (oResponse != null)
		            {
			            using (var reader = new StreamReader(oResponse.GetResponseStream()))
			            {
							using (JsonReader jsonReader = new JsonTextReader(reader))
							{
								var serializer = new JsonSerializer();
								return serializer.Deserialize<T>(jsonReader);
							}
				            //retVal = reader.ReadToEnd();
			            }
		            }
	            }
            }
            catch (WebException ex)
            {
                if (oRequest != null && ex.Status == WebExceptionStatus.Timeout)
                {
                    oRequest.ServicePoint.ConnectionLeaseTimeout = 0;//set tp 0 so that this connection closed immediatly in pool
                }
                if (oRequest != null)
                {
                    oRequest.Abort();
                    oRequest = null;
                }
                throw;
            }
			return default(T);
        }

		private static string GetResponseUsingUsingHttpWebRequest(string userAgent, string url, bool keepAlive)
		{
			HttpWebRequest oRequest = null;
			HttpWebResponse oResponse = null;
			StreamReader reader = null;
			String retVal = string.Empty;

			try
			{
				oRequest = (HttpWebRequest)WebRequest.Create(url);
				oRequest.Method = "GET";
				oRequest.KeepAlive = keepAlive;
				oRequest.Timeout = requestTimeout;
				if (!String.IsNullOrEmpty(userAgent))
				{
					oRequest.UserAgent = userAgent;
				}

				oResponse = oRequest.GetResponse() as HttpWebResponse;
				if (oResponse != null)
				{
					reader = new StreamReader(oResponse.GetResponseStream());
					retVal = reader.ReadToEnd();
				}
			}
			catch (WebException ex)
			{
				if (oRequest != null && ex.Status == WebExceptionStatus.Timeout)
				{
					oRequest.ServicePoint.ConnectionLeaseTimeout = 0;//set tp 0 so that this connection closed immediatly in pool
				}
				if (oRequest != null)
				{
					oRequest.Abort();
					oRequest = null;
				}
				throw;
			}
			finally
			{
				if (reader != null)
				{
					reader.Close();
					reader.Dispose();
				}
				if (oResponse != null)
				{
					oResponse.Close();
				}
			}
			return retVal;
		}
		/// <summary>
		/// Gets the response using using .nets HttpWebRequest class.
		/// </summary>
		/// <param name="userAgent">The userAgent http header.</param>
		/// <param name="url">The URL.</param>
		/// <param name="keepAlive">if set to <c>true</c> connections are set to keep alive else not.</param>
		/// <returns></returns>
		private static string GetResponseUsingUsingHttpWebRequestEx(string url)
		{

			using (var client = new HttpClient())
			{
				client.Timeout = requestTimeoutTimeSpan;
				return client.GetStringAsync(url).Result;
			}
		}


        /// <summary>
        /// Gets the object from json string.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns></returns>
        public T GetObjectFromJsonString(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Gets the object from json stream.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public T GetObjectFromJsonUrl(String url)
        {
	        //return this.GetObjectFromJsonUrlEx(url);
			return GetObjectFromJsonUrl(url, "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36");
        }

	    /// <summary>
	    /// Parses the web exception to get actual web exception
	    /// </summary>
	    /// <param name="ex">The ex.</param>
	    /// <param name="url"></param>
	    /// <returns></returns>
	    private static Exception ParseWebException(WebException ex, string url)
        {
            string responseText = string.Empty;
            try
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {

                    using (Stream responseStream = ((HttpWebResponse)ex.Response).GetResponseStream())
                    {
                        using (StreamReader streamReader = new StreamReader(responseStream))
                        {
                            responseText = streamReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw ex;//if an error in parsin throw original exception
            }

            return new Exception(ex + " :: " + responseText + " :: " + url, ex);
        }
        /// <summary>
        /// Writes the object to json string.
        /// </summary>
        /// <param name="sourceObject">The source object.</param>
        /// <returns></returns>
        public String WriteObjectToJsonString(T sourceObject)
        {
            return JsonConvert.SerializeObject(sourceObject);
        }

        /// <summary>
        /// Writes the object in json format to a text file.
        /// </summary>
        /// <param name="sourceObject">The source object.</param>
        /// <param name="fileUri">The file URI. e.g. d:\data\jsonObjects.txt</param>
        public void WriteObjectToJsonFileStream(T sourceObject, String fileUri)
        {
            JsonSerializer serializer;

            try
            {
                serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(fileUri))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, sourceObject);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                serializer = null;
            }
        }
    }
}