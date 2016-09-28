using System.Collections.Generic;

namespace ARR.Business.Entitiy
{
	public interface IOrder
	{
		int Id { get; set; }
		string Description { get; set; }
		decimal Price { get; set; }
		IList<IProduct> Products { get; set; }
	}
}