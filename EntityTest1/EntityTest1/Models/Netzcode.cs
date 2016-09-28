using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityTest1.Models
{
	public class Netzcode
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int NetzcodeID { get; set; }
		public virtual List<Land> LaenderZuordnung { get; set; }
	}
}