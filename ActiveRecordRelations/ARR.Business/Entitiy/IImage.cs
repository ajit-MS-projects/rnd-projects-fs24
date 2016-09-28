using Castle.ActiveRecord;

namespace ARR.Business.Entitiy
{
	public interface IImage
	{
		[PrimaryKey(PrimaryKeyType.Identity)]
		int Id { get; set; }
		[Property]
		string Url { get; set; }
	}
}