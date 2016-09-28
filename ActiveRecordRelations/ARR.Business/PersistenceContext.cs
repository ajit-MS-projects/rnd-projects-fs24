using System;
using Castle.ActiveRecord;

namespace ARR.Business
{
	public class PersistenceContext : IDisposable
	{
		private TransactionScope transactionScope = null;

		/// <summary>
		/// Initializes a new instance of the <see cref="PersistenceContext"/> class.
		/// </summary>
		internal PersistenceContext()
			: this(false)
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PersistenceContext"/> class.
		/// </summary>
		/// <param name="createNewScope">if set to <c>true</c> [create new scope].</param>
		internal PersistenceContext(bool createNewScope)
		{
			if (createNewScope)
			{
				transactionScope = new TransactionScope(TransactionMode.New);
			}
			else
			{
				transactionScope = new TransactionScope(TransactionMode.Inherits);
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		/// <filterpriority>2</filterpriority>
		public void Dispose()
		{
			if (transactionScope != null)
			{
				transactionScope.Dispose();
			}
		}

		public void Flush()
		{
			if (transactionScope != null)
			{
				transactionScope.Flush();
			}
		}

		public void TryCommit()
		{
			if (transactionScope != null)
			{
				transactionScope.VoteCommit();
			}
		}

		public void TryRollBack()
		{
			if (transactionScope != null)
			{
				transactionScope.VoteRollBack();
			}
		}
	}
}