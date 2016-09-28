using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using HtmlAgilityPack;

namespace ReadMetaTags
{
	/// <summary>
	/// Provides utility methods to parse html and extract related information
	/// Note: if images are not found in meta information they are in detected images collection of IMetaInformation
	/// </summary>
	public static class HtmlParser
	{
		private const string SparacudabotUserAgent = "Sparacudabot/1.0 (+http://www.sparacuda.de/ueber-sparacuda)";
		//private const string SparacudabotUserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)";
		private static readonly int MaxImagesToDetectForUserTip = 50;
		private static readonly int MinimumWidthForDetectedImages = 50;
		private static readonly int MinimumHeightForDetectedImages = 50;
		private static string BaseUrl = string.Empty;

		/// <summary>
		/// Gets the meta tag information.
		/// Extracts data from open graph and geo meta tags
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns></returns>
		public static IMetaInformation GetMetaInformation(string url)
		{
			HttpContext.Current.Response.Write("<h2>URL: <a href='" + url + "'>" + url + "</a></h2><br>");
			IMetaInformation meta = null;
			try
			{
				meta = new MetaInformation();
				TextReader textReader = new StringReader(GetHtml(url));
				HtmlDocument doc = new HtmlDocument();
				doc.Load(textReader);

				var uri = new Uri(url);
				BaseUrl = uri.GetLeftPart(UriPartial.Authority);

				GetPageTitle(meta, doc); 

				GetLinkTagInformation(meta, doc); //get image info from link tag e.g. groupon.de

				GetMetaTagInformation(meta, doc); //read standard info from meta tags

				GetOpenGraphMataTagInformation(meta, doc); //read open graph info from meta tags

				if (string.IsNullOrWhiteSpace(meta.OgImage))
				{// if still no image parse html for image tags and get image
					//GetImageFromImageTags(meta, doc);
					DownloadAndDetectImageFromImageTags(meta, doc);
				}

			}
			catch (Exception ex)
			{
				throw;
			}

			return meta;
		}
		#region Parse html for meta information
		/// <summary>
		/// Gets the page title.
		/// </summary>
		/// <param name="meta">The meta.</param>
		/// <param name="doc">The doc.</param>
		private static void GetPageTitle(IMetaInformation meta, HtmlDocument doc)
		{
			if (doc.DocumentNode.SelectNodes("//title") != null)
			{
				meta.PageTitle = doc.DocumentNode.SelectNodes("//title")[0].InnerHtml;
			}
		}
		/// <summary>
		/// Gets the link tag information.
		/// </summary>
		/// <param name="meta">The meta.</param>
		/// <param name="doc">The doc.</param>
		private static void GetLinkTagInformation(IMetaInformation meta, HtmlDocument doc)
		{
			if (doc.DocumentNode.SelectNodes("//link[@rel]") != null)
			{
				foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//link[@rel]"))
				{
					if (node.Attributes["rel"] != null && node.Attributes["href"] != null)
					{
						switch (node.Attributes["rel"].Value.ToLower())
						{
							case "image_src":
								meta.OgImage = node.Attributes["href"].Value;
								break;
						}
					}
				}
			}
		}

		/// <summary>
		/// Gets the open graph mata tag information.
		/// </summary>
		/// <param name="meta">The meta.</param>
		/// <param name="doc">The doc.</param>
		private static void GetOpenGraphMataTagInformation(IMetaInformation meta, HtmlDocument doc)
		{
			if (doc.DocumentNode.SelectNodes("//meta[@property]") != null)
			{
				foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//meta[@property]"))
				{
					if (node.Attributes["property"] != null && node.Attributes["content"] != null)
					{
						switch (node.Attributes["property"].Value.ToLower())
						{
							case "og:title":
								meta.OgTitle = node.Attributes["content"].Value;
								break;
							case "og:type":
								meta.OgType = node.Attributes["content"].Value;
								break;
							case "og:image":
								meta.OgImage = node.Attributes["content"].Value;
								break;
							case "og:url":
								meta.OgUrl = node.Attributes["content"].Value;
								break;
							case "og:description":
								meta.OgDescription = node.Attributes["content"].Value;
								break;
							case "og:site_name":
								meta.OgSiteName = node.Attributes["content"].Value;
								break;
						}
					}
				}
			}
		}

		/// <summary>
		/// Gets the meta tag information.
		/// </summary>
		/// <param name="meta">The meta.</param>
		/// <param name="doc">The doc.</param>
		private static void GetMetaTagInformation(IMetaInformation meta, HtmlDocument doc)
		{
			if (doc.DocumentNode.SelectNodes("//meta[@name]") != null)
			{
				foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//meta[@name]"))
				{
					switch (node.Attributes["name"].Value.ToLower())
					{
						case "geo.region":
							meta.GeoRegion = node.Attributes["content"].Value;
							break;
						case "geo.placename":
							meta.GeoPlaceName = node.Attributes["content"].Value;
							break;
						case "geo.position":
							meta.GeoPosition = node.Attributes["content"].Value;
							break;
						case "icbm":
							meta.Icbm = node.Attributes["content"].Value;
							break;
						case "title":
							meta.OgTitle = node.Attributes["content"].Value;
							break;
						case "keywords":
							meta.Keywords = node.Attributes["content"].Value;
							break;
						case "description":
							meta.OgDescription = node.Attributes["content"].Value;
							break;
					}
				}
			}
		}

		/// <summary>
		/// Downloads the images and detects main images from image tags based on their actual width and height.
		/// </summary>
		/// <param name="meta">The meta.</param>
		/// <param name="doc">The doc.</param>
		private static void DownloadAndDetectImageFromImageTags(IMetaInformation meta, HtmlDocument doc)
		{
			if (doc.DocumentNode.SelectNodes("//img[@src]") != null)
			{
				int i = 0;
				int largestWidth = 0;
				LimitedQueue<IDetectedImage> imageQueue = new LimitedQueue<IDetectedImage>(MaxImagesToDetectForUserTip);

				foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//img[@src]"))
				{
					i++;
					if (node.Attributes["src"] != null)
					{
						int tmpWidth = 0;
						int tmpHeight = 0;

						var imgUrl = CheckForRelativeImageUrl(node.Attributes["src"].Value);

						System.Drawing.Image objImage = ImageUtility.DownloadImage(imgUrl, SparacudabotUserAgent);
						if (objImage != null)
						{
							if (ImageUtility.IsTransparentPalette(objImage.Palette) || objImage.Width <= MinimumWidthForDetectedImages || objImage.Height <= MinimumHeightForDetectedImages) continue;
							imageQueue.Enqueue(new DetectedImage() { ImageUrl = imgUrl, Width = objImage.Width, Height = objImage.Height });
							objImage.Dispose();
						}
						//if ((largestWidth == 0 || tmpWidth > largestWidth) && (tmpHeight > 0 && tmpWidth / tmpHeight <= 2))//if imageheight is too high(>50% of width) discard
						//{
						//    largestWidth = tmpWidth;
						//    imageQueue.Enqueue(imgUrl);
						//}
					}

					if (imageQueue.Count >= MaxImagesToDetectForUserTip) break;
				}
				
				meta.DetectedImages = imageQueue.OrderBy(x => x,new MyComparer()).ToList();
			}
		}

		public class MyComparer : IComparer<Object>
		{
			public int Compare(Object aa, Object bb)
			{
				DetectedImage a = (DetectedImage) aa;
				DetectedImage b = (DetectedImage)bb;
				double ratioA = 1.0 - (double)Math.Min(a.Width, a.Height) / Math.Max(a.Width, a.Height) -(double) a.Width/99999999999d;
				double ratioB = 1.0 - (double)Math.Min(b.Width, b.Height) / Math.Max(b.Width, b.Height) -(double) b.Width/99999999999d;
				if (ratioA > ratioB)
					return 1;
				if (ratioA < ratioB)
					return -1;
				else
					return 0;
			}
		}

		private static string CheckForRelativeImageUrl(String imageUrl)
		{
			if (!string.IsNullOrWhiteSpace(imageUrl) && !imageUrl.ToLower().StartsWith("http"))
			{
				imageUrl = BaseUrl + imageUrl;
			}
			return imageUrl;
		}

		/// <summary>
		/// Gets the image from image tags and detects main image based on width/height info provided in image tag.
		/// </summary>
		/// <param name="meta">The meta.</param>
		/// <param name="doc">The doc.</param>
		private static void GetImageFromImageTags(IMetaInformation meta, HtmlDocument doc)
		{
			if (doc.DocumentNode.SelectNodes("//img[@src]") != null)
			{
				int i = 0;
				int largestWidth = 0;
				LimitedQueue<string> imageQueue = new LimitedQueue<string>(MaxImagesToDetectForUserTip);

				foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//img[@src]"))
				{
					i++;
					if (node.Attributes["src"] != null)
					{
						int tmpWidth = 0;
						int tmpHeight = 0;

						if (node.Attributes["width"] != null && int.TryParse(node.Attributes["width"].Value, out tmpWidth) &&
							tmpWidth > 20 &&//image must be atleast 20 pixel wide
							node.Attributes["height"] != null && int.TryParse(node.Attributes["height"].Value, out tmpHeight))
						{

							//if ((largestWidth == 0 || tmpWidth > largestWidth) && (tmpHeight > 0 && tmpWidth / tmpHeight <= 2))//if imageQueue is too high(>50% of width) discard
							{
								largestWidth = tmpWidth;
								meta.OgImage = node.Attributes["src"].Value;
							}
						}
					}

					if (imageQueue.Count >= MaxImagesToDetectForUserTip) break;
				}

				if (!String.IsNullOrWhiteSpace(meta.OgImage))
				{//check that the final image selected is not a transparent one

					meta.OgImage = CheckForRelativeImageUrl(meta.OgImage);

					System.Drawing.Image objImage = ImageUtility.DownloadImage(meta.OgImage, SparacudabotUserAgent);
					if (objImage != null)//todo if null then also set the ogimage to null
					{
						if (ImageUtility.IsTransparentPalette(objImage.Palette)) meta.OgImage = null;
						objImage.Dispose();
					}
				}
			}
		}
		#endregion
		#region Get HTML

		/// <summary>
		/// Gets the HTML from a given url.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns></returns>
		private static string GetHtml(string url)
		{
			string returnHtml = string.Empty;
			if (IsValidUrl(url))
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				request.Timeout = 4000;
				request.Credentials = CredentialCache.DefaultCredentials;
				request.UserAgent = SparacudabotUserAgent;
				request.Accept = "text/html, application/xhtml+xml, */*";
				request.Headers.Add("Request", "GET HTTP/1.1");

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				using (Stream dataStream = response.GetResponseStream())
				{
					if (dataStream != null)
						using (StreamReader reader = new StreamReader(dataStream))
						{
							returnHtml = reader.ReadToEnd();
						}
				}
				response.Close();
			}

			return returnHtml;
		}

		/// <summary>
		/// Determines whether the specified URL is valid by making a head request to url
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns>
		///   <c>true</c> if [is valid URL] [the specified URL]; otherwise, <c>false</c>.
		/// </returns>
		private static bool IsValidUrl(string url)
		{
			try
			{
				WebRequest request = WebRequest.Create(url);
				request.Timeout = 4000;
				request.Method = "HEAD";
				request.Credentials = CredentialCache.DefaultCredentials;
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				response.Close();
			}
			catch (WebException ex)
			{
				if (ex.Response != null)
				{
					HttpStatusCode returnedStatus = ((HttpWebResponse)ex.Response).StatusCode;
					if (returnedStatus != HttpStatusCode.MethodNotAllowed && returnedStatus != HttpStatusCode.Forbidden &&
						returnedStatus != HttpStatusCode.NotAcceptable) //Head is not allowed so try Get any way
						return false;
				}
				else
					return false;//if any other exception  url is not valid do not try get
			}

			return true;
		}

		#endregion
	}
}