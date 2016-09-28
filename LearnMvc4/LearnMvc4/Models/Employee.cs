using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearnMvc4.Models
{
	public class Employee
	{
		public int Id { get; set; }
		[Required()]
		public string Name { get; set; }
		
		public Double? Salary { get; set; }
		public string Department { get; set; }
		public Designations Designation { get; set; }
	}
	public enum Designations
	{
		Contract,
		Fest,
		Manager,
		Developer
	}
}