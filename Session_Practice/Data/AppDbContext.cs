using Microsoft.EntityFrameworkCore;

namespace Session_Practice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Price> Prices { get; set; }

    }
}
