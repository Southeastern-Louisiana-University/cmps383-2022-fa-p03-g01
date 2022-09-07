using FA22.P03.Web.Features.ItemListings;

namespace FA22.P03.Web.Features.Listings
{
    public class Listing
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset StartUtc { get; set; }
        public DateTimeOffset EndUtc { get; set; }

        public List<ItemListing>? ItemsForSale { get; set; }
    }

    public class ListingDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset StartUtc { get; set; }
        public DateTimeOffset EndUtc { get; set; }
    }
}
