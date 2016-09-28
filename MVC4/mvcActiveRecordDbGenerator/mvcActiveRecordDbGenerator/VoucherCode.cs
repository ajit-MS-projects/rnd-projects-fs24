using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace mvcActiveRecordDbGenerator
{
	[ActiveRecord]
	public class SchedulerConfig : AbstractBaseObject<SchedulerConfig>
	{
		#region Implementation of ISchedulerConfig
		[Property]
		public string ModuleName { get; set; }
		[Property]
		public int InterValInMinutes { get; set; }
		[Property]
		public string Parameters { get; set; }
		[Property]
		public DateTime FirstStart { get; set; }
		[Property]
		public DateTime LastStart { get; set; }

		#endregion
	}
	public abstract class AbstractBaseObject<T> : ActiveRecordLinqBase<T>
	{
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		/// <value>
		/// The id.
		/// </value>
		[PrimaryKey]
		public virtual long Id { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is deleted.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance is deleted; otherwise, <c>false</c>.
		/// </value>
		[Property]
		public virtual bool IsDeleted { get; set; }

		/// <summary>
		/// Gets or sets the created at timestamp.
		/// </summary>
		/// <value>
		/// The created at.
		/// </value>
		[Property(Update = false)]
		public virtual DateTime CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the updated at timestamp.
		/// </summary>
		/// <value>
		/// The updated at.
		/// </value>
		[Property]
		public virtual DateTime UpdatedAt { get; set; }


		
	}
}