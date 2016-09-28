using System.Collections.Generic;

namespace EntityTest1.Models
{
	public class NetzcodeViewModel
	{
		public int NetzcodeID { get; set; }
		public virtual List<Land> LaenderZuordnung { get; set; }
	}
}