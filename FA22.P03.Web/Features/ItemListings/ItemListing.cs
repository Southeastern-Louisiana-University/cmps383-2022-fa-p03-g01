using FA22.P03.Web.Features.Items;
using FA22.P03.Web.Features.Listings;

namespace FA22.P03.Web.Features.ItemListings
{
    public class ItemListing
    {
        public int Id { get; set; }

        public Item? Item { get; set; }
        public Listing? Listing { get; set; }
    }
}
