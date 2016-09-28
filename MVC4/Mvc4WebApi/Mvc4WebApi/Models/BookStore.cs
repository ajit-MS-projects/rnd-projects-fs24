using System.Data.Entity;

namespace Mvc4WebApi.Models
{
    public class BookStore : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}