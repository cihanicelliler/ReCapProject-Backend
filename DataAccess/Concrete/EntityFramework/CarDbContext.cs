using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
    }
}
