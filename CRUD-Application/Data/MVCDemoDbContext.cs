using CRUD_Application.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Application
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions<MVCDbContext> options) : base(options) { }
    


public DbSet<Employee> Employees { get; set; }
}
}
        

    
