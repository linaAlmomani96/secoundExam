using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExame.Data
{
    public class HRContext:DbContext
    {
        IConfiguration configuration;
        public HRContext() { }
        public HRContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }

        public DbSet<Country> countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("HRConnection"));
            base.OnConfiguring(optionsBuilder);
        }

    }
}
