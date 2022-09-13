using FA22.P03.Web.Data;
using FA22.P03.Web.Features.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FA22.P03.Web.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DbSet<Product> _products;
        private readonly DataContext _dataContext;

        public ProductsController(DataContext dataContext)
        {
            _dataContext = dataContext;
            _products = dataContext.Set<Product>();
        }

        [HttpGet]
        public IQueryable<ProductDto> GetAllProducts()
        {
            return GetProductDtos(_products);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ProductDto> GetProductById(int id)
        {
            var product = GetProductDtos(_products.Where(x => x.Id == id)).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        private static IQueryable<ProductDto> GetProductDtos(IQueryable<Product> products)
        {
            return products
                .Select(x => new ProductDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                });
        }
    }
}
