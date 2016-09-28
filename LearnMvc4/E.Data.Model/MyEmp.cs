using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Data.Model
{
	public interface IMyEmp:IBaseEntity
	{
		string Name { get; set; }
	}

	public class MyEmp : BaseEntity, IMyEmp
	{
		public string Name { get; set; }
	}

	public interface IBaseEntity
	{
		[Key]
		int Id { get; set; }

		DateTime CreatedAt { get; set; }
		DateTime UpdatedAt { get; set; }
	}

	public class BaseEntity : IBaseEntity
	{
		[Key]
		public int Id{ get; set; }

		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}

	public class DataDbContext : DbContext
	{
		public DataDbContext() : base("SqlConnectionString")
		{
			Database.SetInitializer(new DbSeedInitializer());
		}

		public DbSet<MyEmp> MyEmp { get; set; }
	}

	public class DbSeedInitializer : CreateDatabaseIfNotExists<DataDbContext>
	{
		protected override void Seed(DataDbContext context)
		{
			base.Seed(context);
			var emp = new MyEmp() {Name = "Ajit", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow};
			context.MyEmp.Add(emp);
			context.SaveChanges();
		}
	}

}
