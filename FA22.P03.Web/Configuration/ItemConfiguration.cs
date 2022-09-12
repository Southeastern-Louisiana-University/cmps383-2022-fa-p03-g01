using FA22.P03.Web.Features.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA22.P03.Web.Configuration
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(e => e.Id)
                .IsRequired();
            builder.Property(e => e.Condition)
                .HasMaxLength(50);
        }
    }
}
