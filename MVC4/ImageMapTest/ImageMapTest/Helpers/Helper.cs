using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ImageMapTest.Helpers
{
	public static class MyHelpers
	{
		public static MvcHtmlString Image(this HtmlHelper helper, string id, string url, string alternateText)
		{
			return Image(helper, id, url, alternateText, null);
		}

		public static MvcHtmlString Image(this HtmlHelper helper, string id, string url, string alternateText, int border)
		{
			return Image(helper, id, null, url, -1, -1, 0, String.Empty, alternateText, null);
		}

		public static MvcHtmlString Image(this HtmlHelper helper, string id, string url, string alternateText, object htmlAttributes)
		{
			return Image(helper, id, null, url, -1, -1, -1, null, alternateText, htmlAttributes);
		}

		public static MvcHtmlString Image(
			this HtmlHelper helper,
			string id,
			string name,
			string url,
			int width,
			int height,
			int borderWidth,
			string usemap,
			string alternateText,
			object htmlAttributes
			)
		{
			// Instantiate a UrlHelper   
			var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);

			// Create tag builder  
			var builder = new TagBuilder("img");

			// Create valid id  
			builder.GenerateId(id);

			// Add attributes  
			builder.MergeAttribute("src", urlHelper.Content(url));

			if (alternateText != null)
				builder.MergeAttribute("alt", alternateText);

			if (name != null)
				builder.MergeAttribute("name", name);

			if (width > -1)
				builder.MergeAttribute("width", width.ToString());

			if (height > -1)
				builder.MergeAttribute("height", height.ToString());

			if (borderWidth > -1)
				builder.MergeAttribute("style", String.Format("border: {0};", borderWidth));

			if (!String.IsNullOrEmpty(usemap))
				builder.MergeAttribute("usemap", usemap);

			builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

			// Render tag  
			return new MvcHtmlString(builder.ToString(TagRenderMode.SelfClosing));
		}
	}
}