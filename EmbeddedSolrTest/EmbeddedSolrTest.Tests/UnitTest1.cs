using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmbeddedSolrTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Index()
        {
            LuceneIndexer indexer = new LuceneIndexer();
            indexer.IndexText();
        }

		[TestMethod]
		public void TestMethod_Search()
		{
			LuceneIndexer indexer = new LuceneIndexer();
			indexer.QueryText();
		}
    }
}
