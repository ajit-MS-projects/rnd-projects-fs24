using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using CmsSearchClient.Models;
using FS24.WebServices.Interface.Api;
using FS24.WebServices.Interface.Api.Request;
using FS24.WebServices.Interface.Api.Response;
using Filter = FS24.WebServices.Interface.Api.Request.Filter;

namespace CmsSearchClient.Controllers
{
    public class SearchResultsViewerController : Controller
    {
		public ActionResult Search(string searchTerm, FacetFilterModel facetFilterModel)
		{
			var target = new CmsSearchInterface();
			var request = new SearchRequest()
			{
				SearchText = searchTerm,
				Page = 1,
				PageSize = 10,
				Filters = new List<Filter>()
			};
			if (facetFilterModel != null)
			{
				request.Filters.Add(new Filter() { FilterField = facetFilterModel.FacetField, FilterValue = facetFilterModel.FacetValue });
			}

			SearchResponse actual = target.Search(request);

			return View(new SearchResponseModel(){ SearchResponse = actual,SearchTerm = searchTerm});
		}

	   public JsonResult AutocompleteSearch(string term)
		{
			var target = new CmsSearchInterface();
			AutoCompleteResponse actual = target.Autocomplete(term);

			return Json(actual.AutoCompleteSuggestions, JsonRequestBehavior.AllowGet);
		}
    }
}
