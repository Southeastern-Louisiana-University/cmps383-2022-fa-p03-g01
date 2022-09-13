using FA22.P03.Web.Features.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA22.P03.Web.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(150);
            builder.Property(e => e.Description)
                .HasMaxLength(150);
        }
    }
}
