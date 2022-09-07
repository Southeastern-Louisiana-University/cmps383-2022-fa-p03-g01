using FA22.P03.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FA22.P03.Web.Controllers
{
    [ApiController]
    [Route("/api")]
    public class ProductsController : Controller
    {
        private readonly DataContext _dataContext;

        public ProductsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("/products")]
        public IActionResult GetAllProducts()
        {
            return ;
        }
    }
}
