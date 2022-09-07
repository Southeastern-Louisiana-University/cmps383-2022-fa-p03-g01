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
            builder.ToTable("Products");

            builder.Property(e => e.Id)
                .IsRequired();
            builder.Property(e => e.Name)
                .HasMaxLength(50);
            builder.Property(e => e.Description)
                .HasMaxLength(120);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Nintendo 64",
                    Description = "Nintendo's retro console loved thoughout the ages",
                },
                new Product
                {
                    Id = 2,
                    Name = "Donkey Kong 64",
                    Description = "Donkey Kong 64 cartridge for the N64",
                },
                new Product
                {
                    Id = 3,
                    Name = "Legend of Zelda: Ocarina of Time",
                    Description = "Ocarina of Time cartridge for the N64",
                });
        }
    }
}
