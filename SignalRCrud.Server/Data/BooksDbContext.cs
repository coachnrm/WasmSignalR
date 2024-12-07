using Microsoft.EntityFrameworkCore;
using SignalRCrud.Shared;

namespace SignalRCrud.Server.Data
{
    public class BooksDbContext : DbContext 
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book {get; set;}
    }
}