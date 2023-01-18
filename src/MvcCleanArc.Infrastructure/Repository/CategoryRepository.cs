using MvcCleanArc.Core.Entities;
using MvcCleanArc.Core.Repositories;
using MvcCleanArc.Infrastructure.Data;
using MvcCleanArc.Infrastructure.Repository.Base;

namespace MvcCleanArc.Infrastructure.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(MvcCleanArcContext dbContext) : base(dbContext)
    {
    }
    public Task<Category> GetCategoryWithProductsAsync(int categoryId)
    {
        throw new NotImplementedException();
    }
}
