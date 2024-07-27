using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_APPLICATION.Models;

namespace WEB_APPLICATION.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }


    }
}