using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcCleanArc.Core.Entities;

namespace MvcCleanArc.Infrastructure.Data;

public class MvcCleanArcContextSeed
{
    public static async Task SeedAsync(MvcCleanArcContext AspCoreArcContext, ILoggerFactory loggerFactory, int? retry = 0)
    {
        int retryForAvailability = retry.Value;

        try
        {
            // TODO: Only run this if using a real database
            // AspCoreArcContext.Database.Migrate();
            // AspCoreArcContext.Database.EnsureCreated();

            if (!AspCoreArcContext.Categories.Any())
            {
                AspCoreArcContext.Categories.AddRange(GetPreconfiguredCategories());
                await AspCoreArcContext.SaveChangesAsync();
            }

            if (!AspCoreArcContext.Products.Any())
            {
                AspCoreArcContext.Products.AddRange(GetPreconfiguredProducts());
                await AspCoreArcContext.SaveChangesAsync();
            }
        }
        catch (Exception exception)
        {
            if (retryForAvailability < 10)
            {
                retryForAvailability++;
                var log = loggerFactory.CreateLogger<MvcCleanArcContextSeed>();
                log.LogError(exception.Message);
                await SeedAsync(AspCoreArcContext, loggerFactory, retryForAvailability);
            }
            throw;
        }
    }

    private static IEnumerable<Category> GetPreconfiguredCategories()
    {
        return new List<Category>()
            {
                new Category() { CategoryName = "Phone"},
                new Category() { CategoryName = "TV"}
            };
    }

    private static IEnumerable<Product> GetPreconfiguredProducts()
    {
        return new List<Product>()
            {
                new Product() { ProductName = "IPhone", CategoryId = 1 , UnitPrice = 19.5M , UnitsInStock = 10, QuantityPerUnit = "2", UnitsOnOrder = 1, ReorderLevel = 1, Discontinued = false },
                new Product() { ProductName = "Samsung", CategoryId = 1 , UnitPrice = 33.5M , UnitsInStock = 10, QuantityPerUnit = "2", UnitsOnOrder = 1, ReorderLevel = 1, Discontinued = false },
                new Product() { ProductName = "LG TV", CategoryId = 2 , UnitPrice = 33.5M , UnitsInStock = 10, QuantityPerUnit = "2", UnitsOnOrder = 1, ReorderLevel = 1, Discontinued = false }
            };
    }
}
