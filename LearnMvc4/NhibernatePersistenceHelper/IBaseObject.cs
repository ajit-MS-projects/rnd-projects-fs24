using System;

namespace NhibernatePersistenceHelper
{
	public interface IBaseObject
	{
		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		/// <value>
		/// The id.
		/// </value>
		long Id { get; set; }

		/// <summary>
		/// Gets or sets the created at timestamp.
		/// </summary>
		/// <value>
		/// The created at.
		/// </value>
		DateTime CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the updated at timestamp.
		/// </summary>
		/// <value>
		/// The updated at.
		/// </value>
		DateTime UpdatedAt { get; set; }

		/// <summary>
		/// Gets or sets the is deleted.
		/// </summary>
		/// <value>
		/// The is deleted.
		/// </value>
		bool IsDeleted { get; set; }
	}
}