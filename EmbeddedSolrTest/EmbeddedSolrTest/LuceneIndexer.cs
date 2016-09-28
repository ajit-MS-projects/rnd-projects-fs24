using System.Diagnostics;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmbeddedSolrTest
{
    public class LuceneIndexer
    {
        public void IndexText()
        {
            Directory directory = FSDirectory.Open("LuceneIndex");
            var version = new Lucene.Net.Util.Version();
            Analyzer analyzer = new StandardAnalyzer(version);
            IndexWriter writer = new IndexWriter(directory, analyzer, new Lucene.Net.Index.IndexWriter.MaxFieldLength(int.MaxValue));

            for (int i = 100; i < 110; i++)
            {
                Document doc = new Document();
                doc.Add(new Field("id", i.ToString(), Field.Store.YES, Field.Index.NO));
                doc.Add(new Field("text", "This is test ajit " + i, Field.Store.YES, Field.Index.ANALYZED));
                writer.AddDocument(doc);
            }

            writer.Optimize();
            //Close the writer
            writer.Flush(true, true, true);
			writer.Dispose();
			directory.Dispose();
        }

		public void QueryText()
		{
			Directory directory = FSDirectory.Open("LuceneIndex");
			IndexSearcher searcher = new IndexSearcher(directory);


			var filterReader = new FilterIndexReader(new MultiReader());
			SimpleFacetedSearch facetedSearch = new SimpleFacetedSearch(filterReader, "sdfs");

			var version = new Lucene.Net.Util.Version();
			Analyzer analyzer = new StandardAnalyzer(version);

			QueryParser parser = new QueryParser(version, "text", analyzer);
			Query query = parser.Parse("101");
			//Do the search
			Lucene.Net.Search.TopDocs resultDocs = searcher.Search(query, 5);

			Debug.WriteLine("Found {0} results, max score:{1}", resultDocs.TotalHits, resultDocs.MaxScore);

			var hits = resultDocs.ScoreDocs;
			foreach (var hit in hits)
			{
				var documentFromSearcher = searcher.Doc(hit.Doc);
				Debug.WriteLine(documentFromSearcher.Get("id") + " " + documentFromSearcher.Get("text"));
			}

			searcher.Dispose();
			directory.Dispose();
		}
    }
}
