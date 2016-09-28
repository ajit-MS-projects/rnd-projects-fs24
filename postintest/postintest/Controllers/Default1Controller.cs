using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using Newtonsoft.Json;

namespace postintest.Controllers
{
    public class Default1Controller : ApiController
    {
	    [System.Web.Http.HttpPost]
		public void UpdatePortfolioData(RenditeData renditeData)
	    {
			const string jsVariable = "var {0} = {1}";
			const string fileVariablePlaceHolder = "[[{0}]]";

			var xx = renditeData.UniqueId;

			var fileText = " [[ShortDateString]] [[StaatsanleihenEuro]] [[UnternehmensanleihenEuro]] [[AktienIndustrielaender]] [[AktienEntwicklungslaender]] [[Rohstoffe]] [[Dax]] [[Rex]] [[PortfolioSich]] [[PortfolioKons]] [[PortfolioRisk]] [[PortfolioProg]] [[PortfolioSpek]] [[ShortTypeAppr]] [[IntervalMonths]] [[IsSavingsPlan]] [[Yield]] ";

			fileText = CreateFileText(renditeData, jsVariable, fileText, fileVariablePlaceHolder);

		    var ff = fileText;
	    }
		private static string CreateFileText(object renditeData, string jsVariable, string fileText, string fileVariablePlaceHolder)
		{
			PropertyInfo[] propInfos = renditeData.GetType().GetProperties();
			foreach (var prop in propInfos)
			{
				if (prop.PropertyType.GetInterface("IEnumerable") != null)
				{
					var jsonValue = JsonConvert.SerializeObject(prop.GetValue(renditeData, null));
					var formattedVariable = string.Format(jsVariable, prop.Name, jsonValue);
					fileText = fileText.Replace(string.Format(fileVariablePlaceHolder, prop.Name), formattedVariable);
				}
				else if (prop.PropertyType.IsClass)
				{
					fileText = CreateFileText(prop.GetValue(renditeData, null), jsVariable, fileText, fileVariablePlaceHolder);
				}
			}
			return fileText;
		}
    }
}
