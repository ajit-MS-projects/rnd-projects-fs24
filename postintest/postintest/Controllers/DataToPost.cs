using System;
using System.Collections.Generic;

namespace postintest.Controllers
{
	public class RenditeData
	{
		public Guid UniqueId { get; set; }
		public List<string> ShortDateString { get; set; }
		public List<decimal?> StaatsanleihenEuro { get; set; }
		public List<decimal?> UnternehmensanleihenEuro { get; set; }
		public List<decimal?> AktienIndustrielaender { get; set; }
		public List<decimal?> AktienEntwicklungslaender { get; set; }
		public List<decimal?> Rohstoffe { get; set; }
		public List<decimal?> Dax { get; set; }
		public List<decimal?> Rex { get; set; }
		public List<decimal?> PortfolioSich { get; set; }
		public List<decimal?> PortfolioKons { get; set; }
		public List<decimal?> PortfolioRisk { get; set; }
		public List<decimal?> PortfolioProg { get; set; }
		public List<decimal?> PortfolioSpek { get; set; }
		public MdDynamicYieldsData MdDynamicYields { get; set; }
	}
}