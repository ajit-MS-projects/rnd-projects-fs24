using System.Collections.Generic;
using System.Linq.Expressions;
using CastleActiveRecordTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace NewTest
{
    
    
    /// <summary>
    ///This is a test class for MvcApplicationTest and is intended
    ///to contain all MvcApplicationTest Unit Tests
    ///</summary>
	[TestClass()]
	public class MvcApplicationTest
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
			PersistenceHelper.CreateDbSchema();
		}

    	//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		[TestInitialize()]
		public void MyTestInitialize()
		{

		}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion

		[TestMethod]
    	public void AddProductTest()
    	{
			
			Product p = new Product(){ArticleNumber = "A11",Price = 34.77f,Title = "This is a new product" + DateTime.Now.ToString()};
			p.Save();
    	}
		[TestMethod]
		public void AddProductTest2()
		{

			Product p = new Product() { ArticleNumber = "A2", Price = 34.77f, Title = "This is a new product" + DateTime.Now.ToString() };
			p.Save();
			p = new Product() { ArticleNumber = "A3", Price = 34.77f, Title = "This is a new product" + DateTime.Now.ToString() };
			p.Save();
		}

		[TestMethod]
		public void ReportsTest()
		{

			Report r = new Report() {Hour = 5,Date = DateTime.Now};
			
			r.Save();
		}

		[TestMethod]
		public void ReportsGetTest()
		{
			var query =
			   Report.Queryable.Where(rpt => rpt.AdvertiserId == 1).GroupBy(x => x.Hour).Select(
				   result => new Report()
				   {
					   Hour = result.Max(res => res.Hour),
					   AdImpressions = result.Sum(res => res.AdImpressions),
					   Clicks = result.Sum(res => res.Clicks),
					   ClickRate = result.Average(res => res.ClickRate)
				   });



			var list = query.ToList();
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Count > 0);
		}

		private List<IReport> ReportsGetTest2()
		{
			var query =
			   Report.Queryable.Where(rpt => rpt.AdvertiserId == 1).GroupBy(x => x.Hour).Select(
				   result => new Report()
				   {
					   Hour = result.Max(res => res.Hour),
					   AdImpressions = result.Sum(res => res.AdImpressions),
					   Clicks = result.Sum(res => res.Clicks),
					   ClickRate = result.Average(res => res.ClickRate)
				   });


			query.OrderBy("idghjghjg");

			List<IReport> list = query.ToList<IReport>();

			
			return list;
		}

		
	}
	public static class test
	{
		public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string ordering, params object[] values)
		{
			var type = typeof(T);
			var property = type.GetProperty(ordering);
			var parameter = Expression.Parameter(type, "p");
			var propertyAccess = Expression.MakeMemberAccess(parameter, property);
			var orderByExp = Expression.Lambda(propertyAccess, parameter);
			MethodCallExpression resultExp = Expression.Call(typeof(Queryable), "OrderBy", new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(orderByExp));
			return source.Provider.CreateQuery<T>(resultExp);
		}
	}
}
