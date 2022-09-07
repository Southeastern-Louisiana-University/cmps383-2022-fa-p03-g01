using FA22.P03.Web.Features.Listings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA22.P03.Web.Configuration
{
    public class ListingConfiguration : IEntityTypeConfiguration<Listing>
    {
        public void Configure(EntityTypeBuilder<Listing> builder)
        {
            builder.ToTable("Listings");

            builder.Property(e => e.Id)
                .IsRequired();
            builder.Property(e => e.Price)
                .HasPrecision(18, 2)
                .IsRequired();
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(e => e.StartUtc)
                .IsRequired(); 
            builder.Property(e => e.EndUtc)
                .IsRequired();
        }
    }
}
