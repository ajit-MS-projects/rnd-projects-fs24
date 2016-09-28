using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Misc
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
{
	if(e.Row.RowType==DataControlRowType.DataRow)
	{
		DataRow dr = (DataRow)e.Row.DataItem;// or MyObject obj = (MyObject)e.Row.DataItem;
		if(dr["id"].ToString() == "1")
		{
			e.Row.CssClass = "redBackground";//or e.Row.Style.Add("background-color", "green");
		}
		else
		{
			e.Row.CssClass = "greenBackground";//or e.Row.Style.Add("background-color", "green");
		}
	}
}
	}
}
