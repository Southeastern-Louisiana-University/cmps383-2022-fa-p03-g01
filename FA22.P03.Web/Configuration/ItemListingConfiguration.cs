using FA22.P03.Web.Features.ItemListings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA22.P03.Web.Configuration
{
    public class ItemListingConfiguration : IEntityTypeConfiguration<ItemListing>
    {
        public void Configure(EntityTypeBuilder<ItemListing> builder)
        {
            builder.Property(e => e.Id)
                .IsRequired();
        }
    }
}
