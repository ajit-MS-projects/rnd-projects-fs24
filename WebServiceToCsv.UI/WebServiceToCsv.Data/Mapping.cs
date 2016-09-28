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
	public class Mapping : ActiveRecordLinqBase<Mapping>, IMapping
	{
		#region Implementation of IMapping

		[PrimaryKey(PrimaryKeyType.Identity)]
		public int Id { get; set; }
		[Property]
		[Required(ErrorMessage = "SourceProperty is Required to generate export csv")] 
		public string SourceProperty { get; set; }
		[Property]
		[Required(ErrorMessage = "DestinationField is Required to generate export csv")] 
		public string DestinationField { get; set; }
		[Property]
		[Required(ErrorMessage = "ExportId is Required to generate export csv")] 
		public int ExportId { get; set; }

		#endregion
	}
}
