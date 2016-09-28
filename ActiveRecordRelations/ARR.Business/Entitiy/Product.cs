using System.Collections.Generic;
using Castle.ActiveRecord;

namespace ARR.Business.Entitiy
{
	[ActiveRecord] 
	public class Product : ActiveRecordBase<Product>, IProduct
	{
		#region Implementation of IProduct

		[PrimaryKey(PrimaryKeyType.Identity)] 
		public int Id { get; set; }
		[Property]
		public string Title { get; set; }
		[Property]
		public decimal Price { get; set; }

	//	[BelongsTo(Type = typeof(Category), Update = false, Column = "CategoryId", Lazy = FetchWhen.OnInvoke, Fetch = FetchEnum.Select)]
		[BelongsTo(Type = typeof(Category), Column = "CategoryId", Lazy = FetchWhen.OnInvoke, Fetch = FetchEnum.Select)]
		public virtual ICategory CategoryId { get; set; }

		[HasMany(MapType = typeof(Image), ColumnKey = "ObjectId", Table = "Image",  Lazy = true, Inverse = false)]
		public virtual IList<IImage> Images { get; set; }

		[HasAndBelongsToMany(typeof(Orders), Table = "Orders", ColumnKey = "ID_Product", ColumnRef = "ID", Lazy = true)]
		public IList<IOrder> Orders{ get; set; }

		#endregion
	}

	[ActiveRecord]
	public class Orders : ActiveRecordBase<Orders>, IOrder
	{
		#region Implementation of IOrder

		[PrimaryKey(PrimaryKeyType.Identity)] 
		public int Id { get; set; }
		[Property]
		public string Description { get; set; }
		[Property]
		public decimal Price { get; set; }
		[HasAndBelongsToMany(typeof(Product), Table = "Product", ColumnKey = "ID_Orders", ColumnRef = "ID", Inverse = true, Lazy = true)]
		public IList<IProduct> Products { get; set; }

		#endregion
	}
}