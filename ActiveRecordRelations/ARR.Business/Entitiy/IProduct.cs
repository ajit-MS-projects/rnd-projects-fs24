using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARR.Business.Entitiy
{
	public interface IProduct
	{
		int Id { get; set; }
		string Title { get; set; }
		decimal Price { get; set; }
		ICategory CategoryId { get; set; }
		IList<IImage> Images { get; set; }
		IList<IOrder> Orders { get; set; }
	}

	
}
