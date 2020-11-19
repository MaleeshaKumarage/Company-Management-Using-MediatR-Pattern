using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using OX.Domain;
using System.Threading.Tasks;
using System.Threading;

namespace OX.Application.Common.Interfaces
{
    public interface IApplicationDBContext
    {
        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Employees { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
