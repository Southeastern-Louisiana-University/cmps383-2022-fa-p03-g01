using FA22.P03.Web.Features.Products;
using Microsoft.EntityFrameworkCore;

namespace FA22.P03.Web.Data
{
    public class MigrateAndSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DataContext>();
            context.Database.Migrate();

            AddProducts(context);
        }

        public static void AddProducts(DataContext context)
        {
            var products = context.Set<Product>();

            products.Add(
            new Product
            {
                Id = 1,
                Name = "Nintendo 64",
                Description = "Nintendo's retro console loved thoughout the ages",
            });

            products.Add(
            new Product
            {
                Id = 2,
                Name = "Donkey Kong 64",
                Description = "Donkey Kong 64 cartridge for the N64",
            });

            products.Add(
            new Product
            {
                Id = 3,
                Name = "Legend of Zelda: Ocarina of Time",
                Description = "Ocarina of Time cartridge for the N64",
            });

            context.SaveChanges();
        }
    }
}
