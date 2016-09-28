using System;
using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NhibernatePersistenceHelper;

namespace Services.MyTests
{
	[TestClass]
	public class UnitTest1
	{
		[ClassInitialize]
		public static void ClassInit(TestContext context)
		{
			PersistenceHelper.Initialize();
		}
		[TestMethod]
		public void LogErrorTest()
		{
			LogService.LogError(new Exception("test 1234"),"This is a test message" );

		}
		[TestMethod()]
		public void SaveEmpTest()
		{
			EmpService target = new EmpService();
			IEmp emp = new Emp();
			emp.Name = "Ajit2";
			IEmp actual;
			actual = target.SaveEmp(emp);
			Assert.IsNotNull(actual);
		}
	}
}
