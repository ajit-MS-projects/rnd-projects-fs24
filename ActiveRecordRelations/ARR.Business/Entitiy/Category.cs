using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;

namespace ARR.Business.Entitiy
{
	[ActiveRecord] 
	public class Category :ActiveRecordBase<Category>, ICategory
	{
		[PrimaryKey(PrimaryKeyType.Identity)]
		public int Id { get; set; }
		[Property]
		public string Name { get; set; }
	}
}
