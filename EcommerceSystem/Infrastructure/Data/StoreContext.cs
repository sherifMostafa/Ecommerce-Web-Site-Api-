
using Core.Domains;
using Infrastructure.DomainsMapping;
using InfraStructure.DomainsMapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //new ProductMap().Configure(modelBuilder.Entity<Product>());
            //new ProductTypeMap().Configure(modelBuilder.Entity<ProductType>());
            //new ProductBrandMap().Configure(modelBuilder.Entity<ProductBrand>());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

       
    }
}
