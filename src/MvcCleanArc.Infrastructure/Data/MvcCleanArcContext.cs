using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcCleanArc.Core.Entities;

namespace MvcCleanArc.Infrastructure.Data;

public class MvcCleanArcContext : DbContext
{
    public MvcCleanArcContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    // private void ConfigureProduct(EntityTypeBuilder<Product> builder)
    // {
    //     builder.ToTable("Product");

    //     builder.HasKey(ci => ci.Id);

    //     builder.Property(cb => cb.ProductName)
    //         .IsRequired()
    //         .HasMaxLength(100);
    // }

    // private void ConfigureCategory(EntityTypeBuilder<Category> builder)
    // {
    //     builder.ToTable("Category");

    //     builder.HasKey(ci => ci.Id);

    //     builder.Property(cb => cb.CategoryName)
    //         .IsRequired()
    //         .HasMaxLength(100);
    // }

}
