using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MvcCleanArc.Infrastructure.Data;
//For designtime DbContext Creation
//https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation

public class MvcCleanArcContextFactory : IDesignTimeDbContextFactory<MvcCleanArcContext>
{
    public MvcCleanArcContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MvcCleanArcContext>();
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));
        optionsBuilder.UseMySql("Server=localhost;Database=MvcCleanArcDb;User=root;Password=shobuz03;", serverVersion);
        var dbContext = new MvcCleanArcContext(optionsBuilder.Options);
        //await AspCoreArcContextSeed.SeedAsync(dbContext, typeof(LoggerAdapter<>));
        return dbContext;
    }
}
