using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using Web.Entities;

namespace Infrastructure.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<EmployeePosition> EmployeePosition { get; set; }

    }
}
