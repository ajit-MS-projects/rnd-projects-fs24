using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using ProductContracts.Models;

namespace ProductBusiness
{
	[Export(typeof(IProduct))]
	[ActiveRecord] 
	public class Product : ActiveRecordBase<Product> ,IProduct
	{
		[PrimaryKey] 
		public int Id { get; set; }
		[Property]
		public String ArticleNumber { get; set; }
		[Property]
		public String Title { get; set; }
		[Property]
		public double Price { get; set; }
		[Property]
		public double Shipping { get; set; }
	}
}
