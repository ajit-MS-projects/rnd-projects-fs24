using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WinServiceWcf
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyWcfService" in both code and config file together.
	public class MyWcfService : IMyWcfService
	{
		public int Ping()
		{
			return 1;
		}
	}
}
