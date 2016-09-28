using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace virtualPathUtilityTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            String pathstring = Context.Request.FilePath.ToString();
            //pathstring = "images/sv003.jpg";
            sb.Append("Current file path = " + pathstring + "<br />");
            sb.Append("File name = " + VirtualPathUtility.GetFileName(pathstring).ToString() + "<br />");
            sb.Append("File extension = " + VirtualPathUtility.GetExtension(pathstring).ToString() + "<br />");
            sb.Append("Directory = " + VirtualPathUtility.GetDirectory(pathstring).ToString() + "<br />");
            Response.Write(sb.ToString());

            StringBuilder sb2 = new StringBuilder();
            String pathstring1 = Context.Request.CurrentExecutionFilePath.ToString();
            pathstring1 = "/images/sv003.jpg";
            sb2.Append("Current Executing File Path = " + pathstring1.ToString() + "<br />");
            sb2.Append("Is Absolute = " + VirtualPathUtility.IsAbsolute(pathstring1).ToString() + "<br />");
            sb2.Append("Is AppRelative = " + VirtualPathUtility.IsAppRelative(pathstring1).ToString() + "<br />");
            sb2.Append("Make AppRelative = " + VirtualPathUtility.ToAbsolute(pathstring1).ToString() + "<br />");
            Response.Write(sb2.ToString());
        }
    }
}
