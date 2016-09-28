using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReadMetaTags
{
	public partial class Business : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			IMetaInformation  meta = HtmlParser.GetMetaInformation("http://www.sparacuda.de/25-eur-tankgutschein-fuer-1850-eur-kaufen-08031126");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.gillette.com/de/de/promotions/Gillette-coupons.aspx");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("https://www.krombacher.de/vielspass/kronkorken/index.php");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://shop.freundin.de/");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("https://shop.kicker.de/kicker/kickerabo?artikel=7994");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.wohnen-und-garten.de/Shopping/Schn%C3%A4ppchen-Ecke/1667241-2375292.html");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://shop.eltern.de/elternfamily-abo/eltern-family-probeabo-fur-mich.html");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.colgate.de/app/Colgate/DE/Palmolive/Products/ShowerGel/Promotion.cvsp");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.conrad.de/ce/de/content/technik_tipps/technik_tipps?WT.ac=Homepage_TV_VERBINDEN");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.globetrotter.de/de/service/kundenkarte/index.php");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.gourmondo.de/g/cms/versandkostenflatrates.jsf");
			WriteProperties(meta);
			Response.Write("<br><h2>Some more concrete examples</h2><br>");

			meta = HtmlParser.GetMetaInformation(
			        "http://www.amazon.de/gp/product/B003DTLUYK/ref=s9_cartx_gw_d99_g263_ir02?pf_rd_m=A3JWKAKR8XB7XF&pf_rd_s=center-7&pf_rd_r=1BY33XWB7JV104NVF1J2&pf_rd_t=101&pf_rd_p=463772813&pf_rd_i=301128");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.lucky-bike.de/.cms/Raleigh_Dover_XXL/246-1-4111");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.redcoon.de/B268404-Scott-XSE-60-Phuket_Anlage-mit-DVD");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.sparacuda.de");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://www.groupon.de/deals/online-deal/Allyouneed/7659955");
			WriteProperties(meta);
			meta = HtmlParser.GetMetaInformation("http://dailydeal.de/gutscheine/kassel/gutschein-shopping-ballon4you-260612");
			WriteProperties(meta);
		}

		private void WriteProperties(IMetaInformation meta)
		{
			if (!string.IsNullOrWhiteSpace(meta.OgImage))
				Response.Write("<img src='" + meta.OgImage + "'/>");
			foreach (PropertyInfo prop in typeof(MetaInformation).GetProperties())
			{
				if (prop.Name != "DetectedImages")
				Response.Write(prop.Name + " : " + prop.GetValue(meta, null) + "<br>");
			}
			Response.Write("<b>DetectedImages</b>");
			foreach (var img in meta.DetectedImages)
			{
				Response.Write("<img src='" + img.ImageUrl + "'/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
			}
			Response.Write("<br><hr/><br>");
			Response.Flush();

		}
	}
}