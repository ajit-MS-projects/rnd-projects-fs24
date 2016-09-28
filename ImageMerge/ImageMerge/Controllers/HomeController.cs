using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageMerge.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
		public FileResult GetMergedImage()
		{
#region images
			string[] images = new string[]
			                  	{
									"http://static.sparacuda.de/file/getimage?fileId=504f22d93997431a189fae6e",
									"http://static.sparacuda.de/file/getimage?fileId=504f230f3997431a189fae74",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7193",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7193",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7193",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7193",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7112",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7188",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7110",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7192",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=1472",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7093",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7110",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7192",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=1472",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7193",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7112",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7188",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7110",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7192",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=1472",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7093",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7093",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7192",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=1472",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7093",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7110",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7192",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=1472",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7193",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7112",
			                  		"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7188",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7110",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7192",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=1472",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7093",
									"http://static.sparacuda.de/file/getimagebyportaluserid?portalUserId=7093",
			                  	};
#endregion
			Bitmap finalImage = CombineBitmap(images, 10, 3);


			return base.File(ImageUtility.ImageToByte(Image.FromHbitmap(finalImage.GetHbitmap())), "image/jpeg");
		}

		public static System.Drawing.Bitmap CombineBitmap(string[] files, int maxColumns, int maxRows)
		{
			//read all images into memory
			List<System.Drawing.Bitmap> images = new List<System.Drawing.Bitmap>();
			System.Drawing.Bitmap finalImage = null;

			try
			{
				int width = 0;
				int height = 0;
				int columns = 0;

				foreach (string image in files)
				{
					//create a Bitmap from the file and add it to the list
					System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ImageUtility.DownloadImage(image, "ie"));//,50,50);

					//if (columns < maxColumns)
					//    width += bitmap.Width;
					//height = bitmap.Height > height ? bitmap.Height : height;
					

					images.Add(bitmap);
					columns++;
				}

				width = 50 * maxColumns;
				height = 50 * maxRows;
				//create a bitmap to hold the combined image
				finalImage = new System.Drawing.Bitmap(width, height);


				columns = 0;
				//get a graphics object from the image so we can draw on it
				using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage))
				{
					//set background color
					g.Clear(System.Drawing.Color.Gray);

					//go through each image and draw it on the final image
					int xOffset = 0;
					int yOffset = 0;
					foreach (System.Drawing.Bitmap image in images)
					{
						g.DrawImage(image, new System.Drawing.Rectangle(xOffset + (50 - image.Width) / 2, yOffset + (50 - image.Height) / 2, image.Width, image.Height));
						xOffset += 50;// image.Width;
						if (columns > maxColumns)
						{
							xOffset = 0;
							yOffset += 50;
							columns = 0;
						}
						columns++;
					}
				}
				

				return finalImage;
			}
			catch (Exception ex)
			{
				if (finalImage != null)
					finalImage.Dispose();

				throw ex;
			}
			finally
			{
				//clean up memory
				foreach (System.Drawing.Bitmap image in images)
				{
					image.Dispose();
				}
			}
		}
    }
}
