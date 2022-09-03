using Core.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DomainsMapping
{
    public class ProductBrandMap : IEntityTypeConfiguration<ProductBrand>
    {

        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.ToTable("ProductBrands", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(100);

        }


    }
}
