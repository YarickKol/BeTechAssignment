using DataAccesLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }

        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WarehouseAccounting;Trusted_Connection=True;");
        }
        
    }
    
}
