using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace ARR.Business
{
	public static class PersistenceHelper
	{
		public static void Initialize()
		{
			IConfigurationSource source = ConfigurationManager.GetSection("activerecord") as IConfigurationSource;
			var assembly = Assembly.Load("ARR.Business");
			if (!ActiveRecordStarter.IsInitialized)
			{
				ActiveRecordStarter.Initialize(assembly, source);
			}
		}
		public static void CreateDbSchema()
		{
			if (ActiveRecordStarter.IsInitialized)
				ActiveRecordStarter.CreateSchema();
		}

		public static void CreateSchemaSql()
		{
			ActiveRecordStarter.GenerateCreationScripts(@"C:\tmp\createScript.sql");
		}

		public static PersistenceContext CreatePersistenceContext()
		{
			return new PersistenceContext();
		}

		/// <summary>
		/// Creates the persistence context.
		/// </summary>
		/// <param name="newPersistenceContext">if set to <c>true</c> [new persistence context].</param>
		/// <returns></returns>
		public static PersistenceContext CreatePersistenceContext(bool newPersistenceContext)
		{
			return new PersistenceContext(newPersistenceContext);
		}
	}
}
