using System.Data.Entity;

namespace RepositoryAndUnitOfWork

{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("name =NorthwindConnection")
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

    }

}