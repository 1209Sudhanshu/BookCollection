using BookCollection.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Data
{
    public class Application_DbContext : DbContext
    {
        public Application_DbContext(DbContextOptions<Application_DbContext> options) : base(options)
        { 
        }

        public DbSet<Book> Books { get; set; }
       
    }
}
