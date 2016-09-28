using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationTest.Models
{
	public class UserTipViewModel
	{
		public long Id { get; set; }
		[Required]
		public string Title { get; set; }

		[DataType(DataType.Date)]
		[UIHint("DateTime")]
		public DateTime ValidTo { get; set; }
	}
}