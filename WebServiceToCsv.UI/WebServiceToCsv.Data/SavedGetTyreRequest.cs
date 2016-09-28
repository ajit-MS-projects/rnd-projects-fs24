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
	public class SavedGetTyreRequest : ActiveRecordLinqBase<SavedGetTyreRequest>, ISavedGetTyreRequest
	{
		#region Implementation of ISavedGetTyreRequests

		[PrimaryKey(PrimaryKeyType.Identity)]
		public int Id { get; set; }
		[Property]
		public string ImageHeight { get; set; }
		[Property]
		public string ImageWidth { get; set; }
		[Property]
		[Display(Name = "ManufacturerName: Der optionale Parameter manufacturerName schränkt die Suche auf bestimmte Hersteller ein. Z.B.: MICHELIN")]
		public string ManufacturerName { get; set; }
		[Property]
		[Required(ErrorMessage = "searchString muss der gewünschteMatchcode des Reifens stehen, also z. B. 1956515.")] 
		public string SearchString { get; set; }
		[Property]
		public string MinAvailability { get; set; }
		[Property]
		public string OrderValue { get; set; }
		[Property]
		public string OwnStock { get; set; }
		[Property]
		public string PriceList { get; set; }
		[Property]
		public string DealerToken { get; set; }
		[Property]
		[Required(ErrorMessage = "ExportId is Required to generate export csv")] 
		public int ExportId { get; set; }
		#endregion
	}
}
