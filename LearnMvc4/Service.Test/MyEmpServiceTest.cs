using Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using E.Data.Model;

namespace Service.Test
{
    
    
    /// <summary>
    ///This is a test class for MyEmpServiceTest and is intended
    ///to contain all MyEmpServiceTest Unit Tests
    ///</summary>
	[TestClass()]
	public class MyEmpServiceTest
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
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
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
		///A test for SaveMyEmp
		///</summary>
		[TestMethod()]
		public void SaveMyEmpTest()
		{
			MyEmpService target = new MyEmpService(); 
			IMyEmp emp = new MyEmp(){Name = "rrr",CreatedAt = DateTime.Now,UpdatedAt = DateTime.Now};
			IMyEmp actual = target.SaveMyEmp(emp);
			Assert.IsNotNull(actual);
		}

		/// <summary>
		///A test for GetMyEmp
		///</summary>
		[TestMethod()]
		public void GetMyEmpTest()
		{
			MyEmpService target = new MyEmpService(); 
			int id = 1; 
			IMyEmp actual = target.GetMyEmp(id);
			Assert.IsNotNull(actual);
		}
	}
}
