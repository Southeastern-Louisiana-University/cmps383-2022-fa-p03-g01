using FA22.P03.Web.Features.ItemListings;
using FA22.P03.Web.Features.Products;

namespace FA22.P03.Web.Features.Items
{
    public class Item
    {
        public int Id { get; set; }
        public string? Condition { get; set; }

        public Product? Product { get; set; }
        public List<ItemListing>? ItemListings { get; set; }
    }

    public class ItemDto
    {
        public int Id { get; set; }
        public string? Condition { get; set; }
        public string? ProductName { get; set; }
        public int ProductId { get; set; }
    }
}
