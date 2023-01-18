using Microsoft.EntityFrameworkCore;
using MvcCleanArc.Core.Entities;
using MvcCleanArc.Core.Repositories;
using MvcCleanArc.Core.Specifications;
using MvcCleanArc.Infrastructure.Data;
using MvcCleanArc.Infrastructure.Repository.Base;

namespace MvcCleanArc.Infrastructure.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(MvcCleanArcContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Product>> GetProductListAsync()
    {
        var spec = new ProductWithCategorySpecification();
        return await GetAsync(spec);

        // second way
        // return await GetAllAsync();
    }

    public async Task<IEnumerable<Product>> GetProductByNameAsync(string productName)
    {
        var spec = new ProductWithCategorySpecification(productName);
        return await GetAsync(spec);

        // second way
        // return await GetAsync(x => x.ProductName.ToLower().Contains(productName.ToLower()));

        // third way
        //return await _dbContext.Products
        //    .Where(x => x.ProductName.Contains(productName))
        //    .ToListAsync();
    }

    public async Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId)
    {
        return await _dbContext.Products
            .Where(x => x.CategoryId == categoryId)
            .ToListAsync();
    }
}
