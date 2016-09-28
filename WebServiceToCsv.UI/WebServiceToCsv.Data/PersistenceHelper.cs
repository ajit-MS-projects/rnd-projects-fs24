using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace WebServiceToCsv.Data
{
	public static class PersistenceHelper
	{
		public static void Initialize()
		{
			IConfigurationSource source = ConfigurationManager.GetSection("activerecord") as IConfigurationSource;
			var assembly = Assembly.Load("WebServiceToCsv.Data");
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
	}
}