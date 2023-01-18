using MvcCleanArc.Core.Entities;
using MvcCleanArc.Core.Specifications.Base;

namespace MvcCleanArc.Core.Specifications;

public sealed class CategoryWithProductsSpecification : BaseSpecification<Category>
{
    public CategoryWithProductsSpecification(int categoryId)
            : base(b => b.Id == categoryId)
    {
        AddInclude(b => b.Products);
    }
}
