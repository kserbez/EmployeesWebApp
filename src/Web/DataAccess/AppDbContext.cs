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



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Surname = "Маслов", Name = "Иван" },
                new Employee { Id = 2, Surname = "Прыгунок", Name = "Александр" },
                new Employee { Id = 3, Surname = "Капустина", Name = "Анастасия" }
            );

            modelBuilder.Entity<Position>().HasData(
                new Position { Id = 1, Name = "Middle Dev" },
                new Position { Id = 2, Name = "Junior Dev" },
                new Position { Id = 3, Name = "Junior QA" },
                new Position { Id = 4, Name = "Senior BA" }
            );

            modelBuilder.Entity<EmployeePosition>().HasData(
                new
                {
                    Id = 1,
                    EmployeeId = 1,
                    PositionId = 2,
                    Salary = 1500m,
                    DateFrom = new DateTime(2016, 10, 22),
                    DateTo = new DateTime(2018, 12, 14),
                },
                new
                {
                    Id = 2,
                    EmployeeId = 1,
                    PositionId = 1,
                    Salary = 1500m,
                    DateFrom = new DateTime(2018, 12, 15),
                },
                new
                {
                    Id = 3,
                    EmployeeId = 2,
                    PositionId = 3,
                    Salary = 600m,
                    DateFrom = new DateTime(2016, 5, 1),
                    DateTo = new DateTime(2019, 10, 22),
                },
                new
                {
                    Id = 4,
                    EmployeeId = 3,
                    PositionId = 4,
                    Salary = 1800m,
                    DateFrom = new DateTime(2015, 11, 11),
                }
            );
        }
    }
}
