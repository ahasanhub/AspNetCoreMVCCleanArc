using MvcCleanArc.Core.Entities;
using MvcCleanArc.Core.Repositories.Base;

namespace MvcCleanArc.Core.Repositories;

public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<Product>> GetProductListAsync();
    Task<IEnumerable<Product>> GetProductByNameAsync(string productName);
    Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId);
}
