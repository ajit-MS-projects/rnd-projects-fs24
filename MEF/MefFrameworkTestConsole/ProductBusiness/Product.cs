using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using ProductContracts.Models;

namespace ProductBusiness
{
	[Export(typeof(IProduct))]
	
	public class Product : ActiveRecordBase<Product> ,IProduct
	{
		public int Id { get; set; }
		public String ArticleNumber { get; set; }
		public String Title { get; set; }
		public double Price { get; set; }
		public double Shipping { get; set; }
	}
}
