using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FS24.WebServices.Interface.Api.Response;

namespace CmsSearchClient.Models
{
	public class SearchResponseModel
	{
		public SearchResponse SearchResponse { get; set; }
		public string SearchTerm { get; set; }
	}
}