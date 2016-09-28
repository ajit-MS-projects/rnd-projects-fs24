using WebServiceToCsv.Data;
using WebServiceToCsv.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebServiceToCsv.Contracts;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for TyresExportServiceTest and is intended
    ///to contain all TyresExportServiceTest Unit Tests
    ///</summary>
	[TestClass()]
	public class TyresExportServiceTest
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
		///A test for TransformDataLineIntoCsv
		///</summary>
		[TestMethod()]
		[DeploymentItem("WebServiceToCsv.Services.dll")]
		public void TransformDataLineIntoCsvTest()
		{
			TyresExportService_Accessor target = new TyresExportService_Accessor(); // TODO: Initialize to an appropriate value
			IExportSettings settings = new ExportSettings(){Decimal = ".",FieldQualifier = "\"",FieldSeperator = ","};
			List<IMapping> mappings = new List<IMapping>();
			List<ISavedGetTyreRequest> savedSearches = new List<ISavedGetTyreRequest>();
			savedSearches.Add(new SavedGetTyreRequest() { ManufacturerName = "Michelin", SearchString = "1956515" });
			target.TransformDataLineIntoCsv(settings, mappings, savedSearches);
		}
	}
}
