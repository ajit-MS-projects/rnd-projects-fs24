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
			
			Product p = new Product(){ArticleNumber = "A114324",Price = 34.77f,Title = "This is a new product" + DateTime.Now.ToString()};
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


        /// <summary>
        //         Hour,
        //SUM(AdImpressions) AdImpressions,
        //SUM(Clicks) Clicks,
        //AVG(ClickRate) ClickRate,
        //SUM(Leads) Leads,
        //AVG(LeadsLR) LeadsLR,
        //SUM(PostViewLeads) PostViewLeads,
        //SUM(Sales) Sales,
        //AVG(SalesCR) SalesCR,
        //SUM(PostViewSales) PostViewSales,
        //SUM(SalesEUR) SalesValue,
        //SUM(CommissionTotal) TotalCommission
        /// </summary>
        [TestMethod]
        public void ReportsGetTest()
        {
            //var query = Report.Queryable.Where(rpt => rpt.AdvertiserId == 1).GroupBy(x => x.Hour).Select(result => new Report(){Id = result.Key,Hour = result.Sum()});
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

		[TestMethod]
		public void ReportsGetTest2()
		{
			//var query = Report.Queryable.Where(rpt => rpt.AdvertiserId == 1).GroupBy(x => x.Hour).Select(result => new Report(){Id = result.Key,Hour = result.Sum()});
			var query =
				Report.Queryable.Where(rpt => rpt.AdvertiserId == 1).GroupBy(x => x.Hour).Select(
					report => new Report()
					{
						Hour = report.Max(res => res.Hour),
						AdImpressions = report.Sum(res => res.AdImpressions),
						Clicks = report.Sum(res => res.Clicks),
						ClickRate = report.Average(res => res.ClickRate),
						LeadRate = report.Average(res => res.LeadRate),
						Leads = report.Sum(res => res.Leads),
						PostViewLeads = report.Sum(res => res.PostViewLeads),
						PostViewSales = report.Sum(res => res.PostViewSales),
						Sales = report.Sum(res => res.Sales),
						SalesRate = report.Average(res => res.SalesRate),
						SalesValue = report.Sum(res => res.SalesValue),
						TotalAffiliateCommission = report.Sum(res => res.TotalAffiliateCommission)

					});

			int totalRecords = query.Count();

			Assert.IsTrue(totalRecords > 0);

			var list = query.ToList();
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Count > 0);
		}
	}
}
