using FA22.P03.Web.Features.ItemListings;
using FA22.P03.Web.Features.Items;
using FA22.P03.Web.Features.Listings;
using FA22.P03.Web.Features.Products;
using Microsoft.EntityFrameworkCore;

namespace FA22.P03.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Item>? Items { get; set; }
        public DbSet<Listing>? Listings { get; set; }
        public DbSet<ItemListing>? ItemListings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                new Product
                {
                    Id = 1,
                    Name = "Super Mario World",
                    Description = "Super Nintendo (SNES) System. Mint Condition",
                    Price = 259.99m,
                },
                new Product
                {
                    Id = 2,
                    Name = "Donkey Kong 64",
                    Description = "Moderate Condition Donkey Kong 64 cartridge for the Nintendo 64",
                    Price = 199m,
                },
                new Product
                {
                    Id = 3,
                    Name = "Half-Life 2: Collector's Edition",
                    Description = "Good condition with all 5 CDs, booklets, and material from original",
                    Price = 559.99m,
                });
        }
    }
}
