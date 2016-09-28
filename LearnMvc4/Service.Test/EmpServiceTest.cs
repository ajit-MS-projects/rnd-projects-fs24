using NhibernatePersistenceHelper;
using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data.Model;

namespace Service.Test
{
    
    
    /// <summary>
    ///This is a test class for EmpServiceTest and is intended
    ///to contain all EmpServiceTest Unit Tests
    ///</summary>
	[TestClass()]
	public class EmpServiceTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		[ClassInitialize()]
		public static void MyClassInitialize(TestContext testContext)
		{
			PersistenceHelper.Initialize();
		}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for SaveEmp
		///</summary>
		[TestMethod()]
		public void SaveEmpTest()
		{
			EmpService target = new EmpService(); 
			IEmp emp = new Emp();
			emp.Name = "Ajit2uu";
			IEmp actual;
			actual = target.SaveEmp(emp);
			Assert.IsNotNull(actual);
		}

		/// <summary>
		///A test for GetEmp
		///</summary>
		[TestMethod()]
		public void GetEmpTest()
		{
			EmpService target = new EmpService();
			int id = 2; 
			IEmp actual = target.GetEmp(id);
			Assert.IsNotNull(actual);
		}
	}
}
