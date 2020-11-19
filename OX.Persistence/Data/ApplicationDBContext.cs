using Microsoft.EntityFrameworkCore;
using OX.Application.Common.Interfaces;
using OX.Domain;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OX.Persistence.Data
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
       
        public DbSet<Company> Companies { get; set ; }
        public DbSet<Employee> Employees { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
        }
    }
}
