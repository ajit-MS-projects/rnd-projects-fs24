using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServiceToCsv.Contracts.Services;
using WebServiceToCsv.Data;

namespace WebServiceToCsv.Services
{
	/// <summary>
	/// Provided direct access to db related tasks
	/// </summary>
	public class DataService : IDataService
	{
		public void CreateDbSchema()
		{
			PersistenceHelper.CreateDbSchema();
		}
	}
}
