using FA22.P03.Web.Features.Products;
using Microsoft.EntityFrameworkCore;

namespace FA22.P03.Web.Data
{
    public class MigrateAndSeed
    {
        public static void Initialize(IServiceProvider services)
        {
            var context = services.GetRequiredService<DataContext>();
            context.Database.Migrate();

            AddProducts(context);
        }

        public static void AddProducts(DataContext context)
        {
            var products = context.Set<Product>();

            if(products.Any())
            {
                return;
            }

            products.AddRange(
            new Product
            {
                Name = "Nintendo 64",
                Description = "Nintendo's retro console loved thoughout the ages",
            },
            new Product
            {
                Name = "Donkey Kong 64",
                Description = "Donkey Kong 64 cartridge for the N64",
            },
            new Product
            {
                Name = "Legend of Zelda: Ocarina of Time",
                Description = "Ocarina of Time cartridge for the N64",
            });

            context.SaveChanges();
        }
    }
}
