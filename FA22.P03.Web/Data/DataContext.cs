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
    }
}
