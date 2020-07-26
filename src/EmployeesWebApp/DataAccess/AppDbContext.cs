using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using EmployeesWebApp.Entities;

namespace Infrastructure.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }

    }
}
