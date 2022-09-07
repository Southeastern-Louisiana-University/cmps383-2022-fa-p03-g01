﻿using FA22.P03.Web.Features.Items;

namespace FA22.P03.Web.Features.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Item>? Items { get; set; }
    }

    public class ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
