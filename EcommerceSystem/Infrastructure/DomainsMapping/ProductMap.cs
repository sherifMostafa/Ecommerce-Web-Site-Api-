using Core.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.DomainsMapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products" , "dbo");
            builder.HasKey(k => k.Id);

            //builder.HasData(new Product[] {
            //    new Product{Id=1, Name="Product1"},
            //    new Product{Id=2, Name="Product2"},
            //    new Product{Id=3, Name="Product1"},
            //});

            builder.HasOne(p => p.ProductType).WithMany().HasForeignKey(f => f.ProductTypeId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(p => p.ProductBrand).WithMany().HasForeignKey(f => f.ProductBrandId).OnDelete(DeleteBehavior.Restrict); ;
            
           

        }

    }
}
