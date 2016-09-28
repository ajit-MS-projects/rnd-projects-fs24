using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApiTest.Models
{
	public class Book
	{
		public int Id { get; set; }
		[JsonProperty(PropertyName = "BookName")]
		public string Name { get; set; }
		public decimal Price { get; set; }
	}
}