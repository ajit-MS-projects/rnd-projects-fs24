using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceToCsv.Contracts
{
	public interface IMapping
	{
		int Id { get; set; }
		string SourceProperty { get; set; }
		string DestinationField { get; set; }
		int ExportId { get; set; }
	}

	
}
