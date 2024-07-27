using Microsoft.EntityFrameworkCore;
using ASP.NET_CORE_APP.Models;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace ASP.NET_CORE_APP.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
