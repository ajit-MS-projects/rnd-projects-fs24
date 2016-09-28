using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceToCsv.Contracts
{
	public interface IExportSettings
	{
		int ExportId { get; set; }
		string ExportFor { get; set; }
		string FieldSeperator{ get; set; }
		string FieldQualifier { get; set; }
		string Decimal { get; set; }
		string Currency { get; set; }
	}

	
}
