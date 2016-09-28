using System.Web;
using System.Web.Mvc;

namespace Mvc4Test1
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());

			filters.Add(new System.Web.Mvc.AuthorizeAttribute());
		}
	}
}