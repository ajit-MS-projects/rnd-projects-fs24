using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceToCsv.Contracts;
using WebServiceToCsv.Data;

namespace WebServiceToCsv.UI.Models
{
	public class MappingsAndSavedRequests
	{
		public IExportSettings ExportSettings { get; set; }
		public List<IMapping> Mappings { get; set; }
		public List<ISavedGetTyreRequest> SavedRequests { get; set; }
	}
}