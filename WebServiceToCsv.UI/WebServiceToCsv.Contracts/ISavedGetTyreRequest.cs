using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceToCsv.Contracts
{
	public interface ISavedGetTyreRequest
	{
		int Id { get; set; }
		string ImageHeight { get; set; }
		string ImageWidth { get; set; }
		string ManufacturerName { get; set; }
		string SearchString { get; set; }
		string MinAvailability { get; set; }
		string OrderValue { get; set; }
		string OwnStock { get; set; }
		string PriceList { get; set; }
		string DealerToken { get; set; }
		int ExportId { get; set; }
	}


}
