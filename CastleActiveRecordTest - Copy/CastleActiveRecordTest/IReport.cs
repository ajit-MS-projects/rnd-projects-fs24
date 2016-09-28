using System;
using Castle.ActiveRecord;

namespace CastleActiveRecordTest
{
	public interface IReport
	{
		[PrimaryKey]
		int Id { get; set; }

		[Property]
		int AdvertiserId { get; set; }

		[Property]
		DateTime Date { get; set; }

		[Property]
		int Hour { get; set; }

		[Property]
		long AdImpressions { get; set; }

		[Property]
		long Clicks { get; set; }

		[Property]
		double ClickRate { get; set; }

		[Property]
		long Leads { get; set; }

		[Property]
		long LeadRate { get; set; }

		[Property]
		long PostViewLeads { get; set; }

		[Property]
		long Sales { get; set; }

		[Property]
		double SalesRate { get; set; }

		[Property]
		long PostViewSales { get; set; }

		[Property]
		long SalesValue { get; set; }

		[Property]
		long TotalAffiliateCommission { get; set; }

		void Save();
		void SaveAndFlush();
		object SaveCopy();
		object SaveCopyAndFlush();
		void Create();
		void CreateAndFlush();
		void Update();
		void UpdateAndFlush();
		void Delete();
		void DeleteAndFlush();
		void Refresh();
		string ToString();
	}
}