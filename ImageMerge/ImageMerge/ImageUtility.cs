using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace ImageMerge
{
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
				System.IO.Stream webStream = GetImageStream(url, userAgent);

				if (webStream != null) tmpImage = System.Drawing.Image.FromStream(webStream);

				if (webStream != null)
				{
					webStream.Close();
					webStream.Dispose();
				}

			}
			catch (Exception exception)
			{
				return null;
			}

			return tmpImage;
		}

		/// <summary>
		/// Gets an OPEN stream for given image url.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="userAgent">The user agent.</param>
		/// <returns></returns>
		public static Stream GetImageStream(string url, string userAgent)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			request.AllowWriteStreamBuffering = true;

			request.UserAgent = userAgent;
			request.Accept = "text/html, application/xhtml+xml, */*";
			request.Headers.Add("Request", "GET HTTP/1.1");

			request.Timeout = 2000;

			System.Net.WebResponse webResponse = request.GetResponse();

			Stream imgStream = webResponse.GetResponseStream();

			return imgStream;
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

		public static byte[] ImageToByte(Image img)
		{
			ImageConverter converter = new ImageConverter();
			return (byte[])converter.ConvertTo(img, typeof(byte[]));
		}
	}
}