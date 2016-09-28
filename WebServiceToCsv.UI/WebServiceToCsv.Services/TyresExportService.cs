using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using WebServiceToCsv.Contracts;
using WebServiceToCsv.Contracts.Services;
using WebServiceToCsv.Data;
using WebServiceToCsv.Services.TyreShopping;

namespace WebServiceToCsv.Services
{
	public class TyresExportService : ITyresExportService
	{
		#region Implementation of ITyresExportService
		#region mapping
		public IMapping GetMapping(int id)
		{
			return Mapping.Queryable.FirstOrDefault(mapping => mapping.ExportId == id);
		}

		public List<IMapping> GetMappings()
		{
			return Mapping.Queryable.ToList<IMapping>();
		}

		public List<IMapping> GetMappings(int exportId)
		{
			List<IMapping> retVal = Mapping.Queryable.Where(mapping => mapping.ExportId == exportId).ToList<IMapping>();
			if(retVal.Count==0)
			{
				retVal = GetDefaultMappings(exportId);
				foreach (Mapping mapping in retVal)
				{
					mapping.Save();
				}
			}

			return retVal;
		}

		public void SaveMapping(IMapping mapping)
		{
			((Mapping)mapping).Save();
		}
		#endregion
		#region saved requests
		public ISavedGetTyreRequest GetSavedTyreRequest(int id)
		{
			return SavedGetTyreRequest.Queryable.FirstOrDefault(savedGetTyreRequest => savedGetTyreRequest.ExportId == id);
		}

		public List<ISavedGetTyreRequest> GetSavedTyreRequests()
		{
			return SavedGetTyreRequest.Queryable.ToList<ISavedGetTyreRequest>();
		}
		public List<ISavedGetTyreRequest> GetSavedTyreRequests(int exportId)
		{
			return SavedGetTyreRequest.Queryable.Where(savedGetTyreRequest => savedGetTyreRequest.ExportId == exportId).ToList<ISavedGetTyreRequest>();
		}
		public void SaveTyreRequest(ISavedGetTyreRequest getTyreRequest)
		{
			((SavedGetTyreRequest)getTyreRequest).Save();
		}
		#endregion
		#region ExportSetting
		public IExportSettings GetExportSetting(int id)
		{
			return ExportSettings.Queryable.FirstOrDefault(setting => setting.ExportId == id);
		}
		
		public List<IExportSettings> GetExportSettings()
		{
			return ExportSettings.Queryable.ToList<IExportSettings>();
		}

		public void SaveExportSettings(IExportSettings exportSetting)
		{
			((ExportSettings)exportSetting).Save();
		}
		#endregion
		#region export to csv
		public void ExportCsv(int exportId)
		{
			HttpResponse resp = System.Web.HttpContext.Current.Response;
			string attachment = "attachment; filename=MyCsvLol.csv";
			resp.Clear();
			resp.ClearHeaders();
			resp.ClearContent();
			resp.AddHeader("content-disposition", attachment);
			resp.ContentType = "text/csv";
			resp.AddHeader("Pragma", "public");

			IExportSettings settings = null;// ExportSettings.Queryable.FirstOrDefault(setting => setting.ExportId == exportId);
			if (settings == null)
			{
				settings = GetDefaultExportSettings();
			}

			List<IMapping> mappings = new List<IMapping>(); //Mapping.Queryable.Where(mapping => mapping.ExportId == exportId).ToList<IMapping>();
			if (mappings.Count == 0)
			{
				mappings = GetDefaultMappings(exportId);
			}
			List<ISavedGetTyreRequest> savedSearches = new List<ISavedGetTyreRequest>(); //SavedGetTyreRequest.Queryable.Where(savedSearch => savedSearch.ExportId == exportId).ToList<ISavedGetTyreRequest>();
			if (savedSearches.Count == 0)
			{
				savedSearches = new List<ISavedGetTyreRequest>();
				savedSearches.Add(new SavedGetTyreRequest() { ExportId = exportId, SearchString = "a", ManufacturerName = "MICHELIN" });
			}

			resp.Write(GetExportCsvHeader(settings, mappings));

			TransformDataLineIntoCsv(settings, mappings, savedSearches);
			
			//HttpContext.Current.Response.End();
		}

		public IExportSettings GetDefaultExportSettings()
		{
			ExportSettings settings;
			settings = new ExportSettings();
			settings.Currency = "Eur";
			settings.Decimal = ",";
			settings.FieldQualifier = "'";
			settings.FieldSeperator = ",";
			return settings;
		}

		public List<IMapping> GetDefaultMappings(int exportId)
		{
			List<IMapping> mappings;
			mappings = new List<IMapping>();
			PropertyInfo[] tyreListProps = typeof (tyreList).GetProperties();
			foreach (var tyreListProp in tyreListProps)
			{
				mappings.Add(new Mapping()
				             	{DestinationField = tyreListProp.Name, SourceProperty = tyreListProp.Name, ExportId = exportId});
			}
			return mappings;
		}

		private void TransformDataLineIntoCsv(IExportSettings settings, List<IMapping> mappings, List<ISavedGetTyreRequest> savedSearches)
		{
			TyreShoppingWebServicePortTypeClient tyreShoppingWebService = new TyreShoppingWebServicePortTypeClient();
			//TyreShoppingWebService tyreShoppingWebService = new TyreShoppingWebService();
			//securityToken token = tyreShoppingWebService.authenticate(new authenticate() { userId = "748580712", password = "5iHpfXTn" });

			securityToken token = tyreShoppingWebService.authenticate(new authenticateRequest(new authenticate() { userId = "748580712", password = "5iHpfXTn" }) ).securityToken;


			foreach (var savedGetTyreRequest in savedSearches)
			{
				getTyresRequest getTyresRequest = new getTyresRequest(new getTyres
				{
					token = token.token,
					imageHeight = null, //savedGetTyreRequest.ImageHeight,
					imageWidth = null, //savedGetTyreRequest.ImageWidth,
					manufacturer = savedGetTyreRequest.ManufacturerName,
					searchString = savedGetTyreRequest.SearchString,
					minAvailability = null, //savedGetTyreRequest.MinAvailability,
					dealerToken = null, // savedGetTyreRequest.DealerToken,
					priceList = null, // savedGetTyreRequest.PriceList,
					order = null, //savedGetTyreRequest.OrderValue,
					ownStock = null, //savedGetTyreRequest.OwnStock
				});
				                           	
				tyreList[] tyres = tyreShoppingWebService.getTyres(getTyresRequest).getTyresResponse1;

				foreach (var tyreList in tyres)
				{
					String line = string.Empty;
					foreach (var mapping in mappings)
					{
						object objfield = typeof (tyreList).GetProperty(mapping.SourceProperty).GetValue(tyreList, null);
						string field = string.Empty;
						if(objfield != null)
							field = objfield.ToString().Replace(Environment.NewLine, "");

						line += settings.FieldQualifier + field + settings.FieldQualifier + settings.FieldSeperator;
					}
					line += Environment.NewLine;
					HttpContext.Current.Response.Write(line);
				}
			}
		}

		private string GetExportCsvHeader(IExportSettings settings, List<IMapping> mappings)
		{
			StringBuilder retVal = new StringBuilder();

			foreach (var mapping in mappings)
			{
				retVal.Append(mapping.DestinationField + settings.FieldSeperator);
			}
			retVal.Append(Environment.NewLine);
			return retVal.ToString();
		}
		#endregion

		#endregion
	}
}
