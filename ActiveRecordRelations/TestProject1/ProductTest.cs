using System.Collections.Generic;
using ARR.Business;
using ARR.Business.Entitiy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ProductTest and is intended
    ///to contain all ProductTest Unit Tests
    ///</summary>
	[TestClass()]
	public class ProductTest
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

		[ClassInitialize()]
		public static void MyClassInitialize(TestContext testContext)
		{
			PersistenceHelper.Initialize();
			PersistenceHelper.CreateDbSchema();
		}
		
		#endregion


		/// <summary>
		///A test for Product Constructor
		///</summary>
		[TestMethod()]
		public void NewProductTest()
		{
			Product target = new Product()
			                 	{
			                 		Price = 10.23m*DateTime.Now.Millisecond,
			                 		Title = "test" + DateTime.Now.ToString(),
			                 		CategoryId = new Category() {Id = 1},
									Images = new List<IImage>()
			                 	};
			var img = new Image() {Url = "http://test.de/1234.jpg" + new Random().Next()};
			img.Save();
			target.Images.Add(img);
			img = new Image() {Url = "http://test.de/5689.jpg" + new Random().Next()};
			img.Save();
			target.Images.Add(img);
			target.Save();
			
		}

		[TestMethod()]
		public void UpdateProductTest()
		{
			using (var pc = PersistenceHelper.CreatePersistenceContext())
			{
				Product target = Product.TryFind(1);
				var img = new Image() {Url = "http://testupdate.de/1212121.jpg" + new Random().Next()};
				img.Save();
				target.Images.Add(img);
				target.Save();
			}

		}

		[TestMethod()]
		public void NewCategoryTest()
		{
			Category target = new Category() { Name = "apparel" + new Random().Next()};
			target.Save();

		}


		[TestMethod()]
		public void NewImageTest()
		{
			Image target = new Image() { Url = "http://static.sparacuda.de/file/getimage?fileId=503f5f69d5aead1be0c315f2" + new Random().Next() };
			target.Save();

		}
	}
}
