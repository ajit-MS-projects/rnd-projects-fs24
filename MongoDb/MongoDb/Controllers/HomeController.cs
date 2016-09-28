using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace MongoDb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			var connectionString = "mongodb://localhost/?safe=true";
			var server = MongoServer.Create(connectionString);
			var database = server.GetDatabase("ProductDb");
			var collection = database.GetCollection<ProductViewModel>("Products");
			var product = new ProductViewModel { Title = "Sony Camera", ArticleNum = "A"+new Random().Next(1,999999) };
			collection.Insert(product);

			//var product = collection.FindOneById(ObjectId.Parse("506565ccd8494f33c0a32075"));

			return View(product);
        }
		public ActionResult List()
		{
			var connectionString = "mongodb://localhost/?safe=true";
			var server = MongoServer.Create(connectionString);
			var database = server.GetDatabase("ProductDb");
			var collection = database.GetCollection<ProductViewModel>("Products");

			var p = new ProductViewModel() {ArticleNum = "11", Title = "Title 111"};
			p.Cats= new List<ICategory>();
			p.Cats.Add(new Category(){CatId = 1,CatNAme = "cat1"});

			collection.Insert(p);

			List<ProductViewModel> batch = new List<ProductViewModel>();
			foreach (var item in collection.FindAll())
			{
				batch.Add(item);
			}

			return View(batch);
		}

		public ActionResult List2()
		{
			var connectionString = "mongodb://localhost/?safe=true";
			var server = MongoServer.Create(connectionString);
			var database = server.GetDatabase("ProductDb");
			var collection = database.GetCollection<ProductViewModel>("Products");

			var query = collection.AsQueryable<ProductViewModel>().Where(e => e.ArticleNum == "A123");

			return View("List", query.ToList());
		}
    }
	public class ProductViewModel
		{
		[BsonId]
		public Guid Id { get; set; }
			public string ArticleNum { get; set; }
			public string Title { get; set; }
			public List<ICategory> Cats { get; set; }
		}

	public interface ICategory
	{
		long CatId { get; set; }
		string CatNAme { get; set; }
	}

	public class Category : ICategory
	{
		public long CatId { get; set; }
		public string CatNAme { get; set; }
	}

}
