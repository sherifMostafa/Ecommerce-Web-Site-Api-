using Core.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DomainsMapping
{
    public class ProductTypeMap : IEntityTypeConfiguration<ProductType>
    {

        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("ProductTypes", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(100);

        }
         

    }
}
