using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc4Test1.Models
{
	public class CourseModel
	{
		[DataType(DataType.DateTime)]
		public DateTime StartDate { get; set; }
		[Required]
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
	}
}
