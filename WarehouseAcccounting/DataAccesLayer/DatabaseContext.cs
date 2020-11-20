using DataAccesLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesLayer
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)   {}

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
    }

    public class EFDBContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WarehouseAccounting;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataAccesLayer"));

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
