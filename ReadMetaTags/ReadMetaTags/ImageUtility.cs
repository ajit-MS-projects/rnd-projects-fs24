using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace ReadMetaTags
{
	/// <summary>
	/// Class that provides generic functions related to image processing
	/// </summary>
	public static class ImageUtility
	{
		/// <summary>
		/// Function that downloads images from a web urls
		/// </summary>
		/// <param name="url">URL address to download image</param>
		/// <param name="userAgent">The user agent.</param>
		/// <returns>
		/// Image
		/// </returns>
		public static System.Drawing.Image DownloadImage(string url, string userAgent)
		{
			System.Drawing.Image tmpImage = null;

			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

				request.AllowWriteStreamBuffering = true;

				request.UserAgent = userAgent;
				request.Accept = "text/html, application/xhtml+xml, */*";
				request.Headers.Add("Request", "GET HTTP/1.1");

				request.Timeout = 4000;

				System.Net.WebResponse webResponse = request.GetResponse();

				System.IO.Stream webStream = webResponse.GetResponseStream();

				if (webStream != null) tmpImage = System.Drawing.Image.FromStream(webStream);

				webResponse.Close();
				webResponse.Close();
			}
			catch (Exception exception)
			{
				return null;
			}

			return tmpImage;
		}

		/// <summary>
		/// Determines whether the image is a transparent image
		/// </summary>
		/// <param name="palette">The palette.</param>
		/// <returns>
		///   <c>true</c> if [is transparent palette] [the specified palette]; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsTransparentPalette(System.Drawing.Imaging.ColorPalette palette)
		{
			if (palette.Flags != 1)
				return false;

			int total_colors = palette.Entries.GetLength(0);
			for (int i = 0; i < total_colors - 1; i++)
			{
				if (palette.Entries[i].A != 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}