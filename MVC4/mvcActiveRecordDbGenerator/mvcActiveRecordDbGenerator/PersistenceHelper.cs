using System.Configuration;
using System.Reflection;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace mvcActiveRecordDbGenerator
{

	public static class PersistenceHelper
	{
		public static void Initialize()
		{
			IConfigurationSource source = ConfigurationManager.GetSection("activerecord") as IConfigurationSource;
			var assembly = Assembly.Load("mvcActiveRecordDbGenerator");
			if (!ActiveRecordStarter.IsInitialized)
			{
				ActiveRecordStarter.Initialize(assembly, source);
				ActiveRecordStarter.CreateSchema();
			}
		}
		public static void CreateDbSchema()
		{
			if (ActiveRecordStarter.IsInitialized)
				ActiveRecordStarter.CreateSchema();
			ActiveRecordStarter.GenerateCreationScripts(@"c:\sql.sql");
		}



		public static NHibernate.StaleObjectStateException MyProperty { get; set; }
	} 
}