using System;
using System.Collections.Generic;
using System.Data;
using NHibernate;
using NHibernate.Context;

namespace NhibernatePersistenceHelper
{
	public class PersistenceContext : IDisposable
	{
		//private TransactionScope TransactionScope { get; set; }

		public ISession Session { get; private set; }
		private ITransaction Transaction { get; set; }

		private List<bool> Commits { get; set; }
		private int RegisteredVotes { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PersistenceContext"/> class.
		/// </summary>
		internal PersistenceContext() : this(false, false)
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PersistenceContext" /> class.
		/// </summary>
		/// <param name="createNewScope">if set to <c>true</c> [create new scope].</param>
		/// <param name="withTransaction">if set to <c>true</c> [with transaction].</param>
		internal PersistenceContext(bool createNewScope, bool withTransaction)
		{
			if (!CurrentSessionContext.HasBind(PersistenceHelper.SessionFactory))
			{
				var session = PersistenceHelper.SessionFactory.OpenSession();

				CurrentSessionContext.Bind(session);
				if (withTransaction)
				{
					this.Transaction = session.BeginTransaction();
				}
				//TransactionScope = new TransactionScope();
			}

			this.Session = PersistenceHelper.SessionFactory.GetCurrentSession();
			//Session.FlushMode = FlushMode.Auto;
			this.Commits = new List<bool>();
		}
		
		internal void Register()
		{
			this.RegisteredVotes++;
		}
		internal void Unregister()
		{
			this.RegisteredVotes--;
		}

		public IDbConnection Connection
		{
			get
			{
				if (Session != null)
				{
					return Session.Connection;
				}
				return null;
			}
		}

		public void Flush()
		{
			if (this.Session != null)
			{
				this.Session.Flush();
			}
		}

		/// <summary>
		/// Votes the commit.
		/// </summary>
		public void VoteCommit()
		{
			if (this.Transaction != null)
			{
				this.Commits.Add(true);
			}
		}

		/// <summary>
		/// Votes the roll back.
		/// </summary>
		public void VoteRollBack()
		{
			if (this.Transaction!= null)
			{
				this.Commits.Add(false);
			}
		}

		
		public void Dispose()
		{
			this.Unregister();
			if (this.RegisteredVotes == 0)
			{
				this.InternalDispose();
			}
		}


		private void InternalDispose()
		{
			PersistenceHelper.RemoveFromStack(this);

			var session = CurrentSessionContext.Unbind(PersistenceHelper.SessionFactory);

			if (this.Transaction != null)
			{
				if (!this.Commits.Contains(false))
				{
					session.Transaction.Commit();
				}
				else
				{
					this.Transaction.Rollback();
				}
				
				this.Transaction.Dispose();
			}

			if (session != null)
			{
				session.Flush();
				session.Close();
				session.Dispose();
			}
			//if (this.TransactionScope!= null)
			//{
			//	this.TransactionScope.Complete();
			//}

		}

	}
}
