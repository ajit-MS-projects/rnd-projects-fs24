using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace sqliteTest
{
	public class UsersContext : DbContext
	{
		public UsersContext()
			: base("DefaultConnection")
		{
		}

		public DbSet<tt> tts { get; set; }
	}
	public class tt
	{
		//System.Data.Entity.Infrastructure.LocalDbConnectionFactory
		//System.Data.SQLite.SQLiteFactory
		public string one { get; set; }
	}
}
