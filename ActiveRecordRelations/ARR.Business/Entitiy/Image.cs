using Castle.ActiveRecord;

namespace ARR.Business.Entitiy
{
	[ActiveRecord] 
	public class Image : ActiveRecordBase<Image>, IImage
	{
		[PrimaryKey(PrimaryKeyType.Identity)]
		public int Id { get; set; }
		[Property]
		public string Url { get; set; }
	}
}