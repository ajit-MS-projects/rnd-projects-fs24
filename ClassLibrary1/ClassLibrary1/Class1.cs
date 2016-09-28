using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class FinanceFactory
    {
	    public abstract Leads GetLeads();
		public abstract void SanitizeLeads(Leads leads);
    }
	public class AffiliateFactory:FinanceFactory
	{
		public override Leads GetLeads()
		{
			throw new NotImplementedException();
		}

		public override void SanitizeLeads(Leads leads)
		{
			throw new NotImplementedException();
		}
	}
	public class FinanzendeFactory : FinanceFactory
	{
		public override Leads GetLeads()
		{
			Leads leads= new FinanzendeLeads().GetLeads();
		}

		public override void SanitizeLeads(Leads leads)
		{
			throw new NotImplementedException();
		}
	}
	public abstract class Leads
	{
		public List<Leads> Leads1;
		public Leads()
		{
			Leads1=new List<Leads>();
		}

		public int LeadId { get; set; }
		public string Url{ get; set; }
		public abstract void GetLeads();
	}
	public class AffiliateLeads: Leads
	{
		public override void GetLeads()
		{
			GetAffiliteLeads();
		}

		private void GetAffiliteLeads()
		{
			throw new NotImplementedException();
		}
	}
	public class FinanzendeLeads : Leads
	{
		public override void GetLeads()
		{
			GetFinanzendeLeads();
		}

		private void GetFinanzendeLeads()
		{
			throw new NotImplementedException();
		}
	}
}
