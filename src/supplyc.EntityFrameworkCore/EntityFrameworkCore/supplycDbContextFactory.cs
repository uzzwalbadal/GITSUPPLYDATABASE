using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using supplyc.Configuration;
using supplyc.Web;

namespace supplyc.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class supplycDbContextFactory : IDesignTimeDbContextFactory<supplycDbContext>
    {
        public supplycDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<supplycDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            supplycDbContextConfigurer.Configure(builder, configuration.GetConnectionString(supplycConsts.ConnectionStringName));

            return new supplycDbContext(builder.Options);
        }
    }
}
