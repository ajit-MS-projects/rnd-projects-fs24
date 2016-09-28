using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ImageMapTest.Helpers
{
	public class ImageMap
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public ImageMapHotSpot[] Shapes { get; set; }
		public static HtmlHelper Helper { get; set; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("<map id='{1}' name='{0}'>", Name, ID);
			foreach (ImageMapHotSpot shape in Shapes)
			{
				sb.Append(shape.ToString());
			}
			sb.Append("</map>");

			return sb.ToString();
		}
	}

	public abstract class ImageMapHotSpot
	{
		public string Title { get; set; }
		public string AlternateText { get; set; }
		public string Action { get; set; }
		public string Controller { get; set; }
	}

	public class RectangleHotSpot : ImageMapHotSpot
	{
		public Point TopLeft { get; set; }
		public Point BottomRight { get; set; }

		public override string ToString()
		{
			var urlHelper = new UrlHelper(ImageMap.Helper.ViewContext.RequestContext);
			var url = urlHelper.Action(Action, Controller);

			return String.Format("<area shape='rect' coords='{0},{1},{2},{3}' href='{4}' alt='{5}' title='{6}'>",
			                      TopLeft.X, TopLeft.Y, BottomRight.X, BottomRight.Y, url, AlternateText,Title);
		}
	}

	public class CircleHotSpot : ImageMapHotSpot
	{
		public Point Center { get; set; }
		public int Radius { get; set; }

		public override string ToString()
		{
			var urlHelper = new UrlHelper(ImageMap.Helper.ViewContext.RequestContext);
			var url = urlHelper.Action(Action, Controller,new{id=112});

			return String.Format("<area shape='rect' coords='{0},{1},{2}' href='{3}' alt='{4}' title='{5}'>",
								  Center.X, Center.Y, Radius, url, AlternateText,Title);
		}
	}

	public class PolygonHotSpot : ImageMapHotSpot
	{
		public Point[] Coordinates { get; set; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			var urlHelper = new UrlHelper(ImageMap.Helper.ViewContext.RequestContext);
			var url = urlHelper.Action(Action, Controller);

			StringBuilder cords = new StringBuilder();

			for (int i = 0; i < Coordinates.Length; i++)
			{
				if (i > 0)
					sb.Append(",");

				cords.AppendFormat("{0},{1}", Coordinates[i].X, Coordinates[i].Y);
			}

			return String.Format("<area shape='rect' coords='{0}' href='{1}' alt='{2}' title='{3}'>",
								  cords.ToString(), url, AlternateText,Title);
		}
	}

	public static class ImageMapHelper
	{
		public static MvcHtmlString ActionLink(this HtmlHelper helper, ImageMap map)
		{
			ImageMap.Helper = helper;
			return new MvcHtmlString(map.ToString());
		}
	}
}