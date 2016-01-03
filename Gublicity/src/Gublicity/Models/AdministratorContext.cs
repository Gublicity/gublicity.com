using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gublicity.Models
{
    public class AdministratorContext : DbContext
    {
        public AdministratorContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            var connString = Startup.Configuration["Data:AdministratorContextConnection"];
            optionBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionBuilder);
        }


    }
}
