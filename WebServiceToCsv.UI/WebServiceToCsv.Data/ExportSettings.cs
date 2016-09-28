using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using WebServiceToCsv.Contracts;

namespace WebServiceToCsv.Data
{
	[ActiveRecord] 
	public class ExportSettings : ActiveRecordLinqBase<ExportSettings>, IExportSettings
	{
		#region Implementation of IExportSettings
		[PrimaryKey(PrimaryKeyType.Identity)]
		public int ExportId { get; set; }
		[Property]
		[Required(ErrorMessage = "Export For is Required")]    
		public string ExportFor { get; set; }
		[Property]
		[Required(ErrorMessage = "FieldSeperator is Required to generate export csv")] 
		public string FieldSeperator { get; set; }
		[Property]
		[Required(ErrorMessage = "FieldQualifier is Required to generate export csv")] 
		public string FieldQualifier { get; set; }
		[Property]
		public string Decimal { get; set; }
		[Property]
		public string Currency { get; set; }
		#endregion
	}
}
