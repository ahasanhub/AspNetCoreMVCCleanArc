using MvcCleanArc.Core.Entities;
using MvcCleanArc.Core.Specifications.Base;

namespace MvcCleanArc.Core.Specifications;

public class ProductWithCategorySpecification : BaseSpecification<Product>
{
    public ProductWithCategorySpecification(string productName)
            : base(p => p.ProductName.ToLower().Contains(productName.ToLower()))
    {
        AddInclude(p => p.Category);
    }

    public ProductWithCategorySpecification() : base(null)
    {
        AddInclude(p => p.Category);
    }
}
