using MvcCleanArc.Core.Entities;
using MvcCleanArc.Core.Repositories.Base;

namespace MvcCleanArc.Core.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    Task<Category> GetCategoryWithProductsAsync(int categoryId);
}
