using MvcCleanArc.Core.Entities.Base;

namespace MvcCleanArc.Core.Entities;

public class Category : Entity
{
    public Category()
    {
        Products = new HashSet<Product>();
    }
    public string CategoryName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<Product> Products { get; private set; }
    public static Category Create(int categoryId, string name, string description = null)
    {
        var category = new Category { Id = categoryId, CategoryName = name, Description = description };
        return category;
    }
}
