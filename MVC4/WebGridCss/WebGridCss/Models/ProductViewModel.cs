using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGridCss.Models
{
	public class ProductViewModel
	{
		public long Id { get; set; }
		public string Title { get; set; }
		public string Desc { get; set; }
		public double Price { get; set; }
	}
}