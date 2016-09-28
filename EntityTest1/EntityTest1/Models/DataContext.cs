using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace EntityTest1.Models
{
	public class DataContext : DbContext
	{
		public DataContext()
			: base("DefaultConnection")
		{
		}

		public DbSet<Netzcode> Netzcodes { get; set; }
		public DbSet<Land> Lands { get; set; }
	}

	
}
